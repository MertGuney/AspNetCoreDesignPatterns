using Microsoft.AspNetCore.Mvc;

namespace WebApp.CommandPattern.Command
{
    public class CreatePdfTableActionCommand<T> : ITableActionCommand
    {
        private readonly PdfFile<T> _pdfFile;

        public CreatePdfTableActionCommand(PdfFile<T> pdfFile)
        {
            _pdfFile = pdfFile;
        }

        public IActionResult Execute()
        {
            var excelMemoryStream = _pdfFile.Create();
            return new FileContentResult(excelMemoryStream.ToArray(), _pdfFile.fileType) { FileDownloadName = _pdfFile.fileName };
        }
    }
}
