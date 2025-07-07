using Application.DTOs.ExportDocx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IExternalService
{
    public interface IExportFileDocxService
    {
        byte[] Export(ExamTemplateDto exma);
    }
}
