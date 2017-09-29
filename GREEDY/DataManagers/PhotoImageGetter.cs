using System.Drawing;

namespace GREEDY.DataManagers
{
    class PhotoImageGetter : IImageGetter
    {
        /// <summary>
        /// Gets image from {TBD} (We imagine two possibilities to get a receipt. 
        /// From camera using Emgu.CV and from local file system, such like personal phone (if we create an apps) or
        /// computer (if we create a web application)
        /// </summary>
        /// <returns></returns>
        public Bitmap GetImage()
        {
            return null;
        }
    }
}
