using Application.DTOs.Chapters;
using Application.Interface.IExternalService;
using Tesseract;

public class ExtractTextFromImageService : IExtractTextFromImageService
{
    private readonly string _tessdataPath;
    public ExtractTextFromImageService(string tessdataPath = null)
    {
        _tessdataPath = tessdataPath ?? Path.Combine(AppContext.BaseDirectory, "tessdata");
    }
    public List<ChapterDTO> ExtractChapters(Stream imageStream)
    {
        var tempPath = Path.GetTempFileName();
        using (var fs = File.OpenWrite(tempPath))
        {
            imageStream.CopyTo(fs);
        }

        var result = new List<ChapterDTO>();
        try
        {
            // Debug check
            Console.WriteLine("Tesseract path: " + _tessdataPath);
            Console.WriteLine("eng.traineddata exists: " + File.Exists(Path.Combine(_tessdataPath, "eng.traineddata")));
            Console.WriteLine("vie.traineddata exists: " + File.Exists(Path.Combine(_tessdataPath, "vie.traineddata")));

            using var engine = new TesseractEngine(_tessdataPath, "eng+vie", EngineMode.Default);
            using var img = Pix.LoadFromFile(tempPath);
            using var page = engine.Process(img);

            string text = page.GetText();

            result.Add(new ChapterDTO
            {
                Title = "Toàn bộ ảnh",
                Content = text
            });
        }
        finally
        {
            if (File.Exists(tempPath)) File.Delete(tempPath);
        }

        return result;
    }
}
