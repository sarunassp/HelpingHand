﻿using System.Drawing;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using GREEDY.Models;
using GREEDY.Extensions;

namespace GREEDY.OCRs
{
    public class EmguOcr : IOcr
    {
        private readonly Emgu.CV.OCR.Tesseract _tesseract;
        private static IAppConfig AppConfig => new AppConfig();

        public EmguOcr ()
        {
            _tesseract = new Emgu.CV.OCR.Tesseract
            (
                AppConfig.TesseractDataPath,
                AppConfig.OcrLanguage,
                OcrEngineMode.Default
            );
        }
        
        public Receipt ConvertImage (Bitmap image)
        {
            _tesseract.SetImage (new Image<Bgr, byte> (image));
            _tesseract.Recognize ();
            return _tesseract.GetReceipt ();
        }
    }
}