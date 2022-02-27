using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApp.CommandPattern.Command
{
    public class CreateExcelTableActionCommand<T> : ITableActionCommand
    {
        private readonly ExcelFile<T> _excelFile;

        public CreateExcelTableActionCommand(ExcelFile<T> excelFile)
        {
            _excelFile = excelFile;
        }

        public IActionResult Execute()
        {
            var excelMemoryStream = _excelFile.Create();
            return new FileContentResult(excelMemoryStream.ToArray(), _excelFile.fileType) { FileDownloadName = _excelFile.fileName };
        }
    }
}
