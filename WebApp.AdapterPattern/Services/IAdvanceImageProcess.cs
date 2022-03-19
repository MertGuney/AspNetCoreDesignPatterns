using System.Drawing;
using System.IO;

namespace WebApp.AdapterPattern.Services
{
    public interface IAdvanceImageProcess
    {
        //void AddWatermark(string text, string fileName, Stream imageStream);
        void AddWatermarkImage(Stream stream, string text, string filePath, Color color, Color outlineColor);
    }
}
