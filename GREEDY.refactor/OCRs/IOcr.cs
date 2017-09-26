using System.Drawing;
using GREEDY.refactor.Models;

namespace GREEDY.refactor.OCRs
{
    public interface IOcr
    {
        Receipt ConvertImage (Bitmap image);
    }
}