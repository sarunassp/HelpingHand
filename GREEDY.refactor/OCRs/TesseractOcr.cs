using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using GREEDY.refactor.Extensions;
using GREEDY.refactor.Models;
using Tesseract;

namespace GREEDY.refactor.OCRs
{
    // currently doesn't work cause the nuget is shit
    public class TesseractOcr : IOcr
    {
        private readonly TesseractEngine _tesseract;
        private readonly IAppConfig _config;
        
        public TesseractOcr (IAppConfig config)
        {
            _config = config;
            _tesseract = new TesseractEngine 
            (
                _config.TesseractDataPath,
                _config.OcrLanguage,
                EngineMode.TesseractAndCube
            );
        }
        
        public Receipt ConvertImage (Bitmap image)
        {
            var page = _tesseract.Process(image);
            return page.GetReceipt ();
        }
    }
}