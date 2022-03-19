using LazZiya.ImageResize;
using System.Drawing;
using System.IO;

namespace WebApp.AdapterPattern.Services
{
    public class AdvanceImageProcess : IAdvanceImageProcess
    {
        public void AddWatermarkImage(Stream stream, string text, string filePath, Color color, Color outlineColor)
        {
            using (var img = Image.FromStream(stream))
            {
                var t0ps = new TextWatermarkOptions
                {
                    TextColor = color,
                    OutlineColor = outlineColor
                };
                img.AddTextWatermark(text, t0ps).SaveAs(filePath);
            }
        }
    }
}
