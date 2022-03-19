using System.IO;

namespace WebApp.AdapterPattern.Services
{
    public interface IImageProcess
    {
        void AddWatermark(string text, string fileName, Stream imageStream);
    }
}
