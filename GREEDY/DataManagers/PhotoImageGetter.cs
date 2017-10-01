using System;
using System.Drawing;

namespace GREEDY.DataManagers
{
    class PhotoImageGetter : IImageGetter
    {
        
        // why using emgu.cv? and its a suummary it should state what it does, not how
        /// <summary>
        /// Gets image from camera using Emgu.CV
        /// </summary>
        /// <returns></returns>
        public Bitmap GetImage()
        {
            throw new NotImplementedException ();
        }
    }
}
