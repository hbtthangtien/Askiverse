using Application.DTOs.Chapters;
using Application.Interface.IExternalService;
using System.Text.RegularExpressions;
using Tesseract;

public class ExtractTextFromImageService : IExtractTextFromImageService
{
    private readonly string _tessdataPath;
    public ExtractTextFromImageService(string tessdataPath = null)
    {
        _tessdataPath = tessdataPath ?? Path.Combine(AppContext.BaseDirectory, "tessdata");
    }
    //public List<ChapterDTO> ExtractChapters(Stream imageStream)
    //{
    //    var tempPath = Path.GetTempFileName();
    //    using (var fs = File.OpenWrite(tempPath))
    //    {
    //        imageStream.CopyTo(fs);
    //    }

    //    var result = new List<ChapterDTO>();
    //    try
    //    {
    //        // Debug check
    //        Console.WriteLine("Tesseract path: " + _tessdataPath);
    //        Console.WriteLine("eng.traineddata exists: " + File.Exists(Path.Combine(_tessdataPath, "eng.traineddata")));
    //        Console.WriteLine("vie.traineddata exists: " + File.Exists(Path.Combine(_tessdataPath, "vie.traineddata")));

    //        using var engine = new TesseractEngine(_tessdataPath, "eng+vie+chi_sim+chi_tra+chi_sim_vert+chi_tra_vert", EngineMode.Default);
    //        using var img = Pix.LoadFromFile(tempPath);
    //        using var page = engine.Process(img);

    //        string text = page.GetText();

    //        result.Add(new ChapterDTO
    //        {
    //            Title = "Toàn bộ ảnh",
    //            Content = text
    //        });
    //    }
    //    finally
    //    {
    //        if (File.Exists(tempPath)) File.Delete(tempPath);
    //    }

    //    return result;
    //}

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
            using var img = Pix.LoadFromFile(tempPath);

            string[] langs = { "chi_sim", "chi_tra" };
            foreach (var lang in langs)
            {
                using var engine = new TesseractEngine(_tessdataPath, $"eng+vie+{lang}", EngineMode.Default);
                using var page = engine.Process(img);
                string text = page.GetText();

                if (!string.IsNullOrWhiteSpace(text))
                {
                    string cleanedText = ContainsChineseCharacters(text)
                           ? CleanText(text)
                           : text;
                    result.Add(new ChapterDTO
                    {
                        Title = "Toàn bộ ảnh",
                        Content = cleanedText
                    });
                }
            }
        }
        finally
        {
            if (File.Exists(tempPath)) File.Delete(tempPath);
        }

        return result;
    }
    private string CleanText(string input)
    {
        var cleaned = Regex.Replace(input, @"[^a-zA-Z0-9\s.,!?;:'""()\-+=/*\u4e00-\u9fff]", "");
        cleaned = Regex.Replace(cleaned, @"\s{2,}", " ");
        return cleaned.Trim();
    }

    // Hàm kiểm tra nếu có ký tự Trung Quốc
    private bool ContainsChineseCharacters(string input)
    {
        return input.Any(c => c >= 0x4E00 && c <= 0x9FFF);
    }
}
