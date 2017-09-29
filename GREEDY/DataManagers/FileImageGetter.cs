using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using GREEDY.Models;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using GREEDY.OCRs;
using GREEDY.View;

namespace GREEDY.DataManagers
{
    class FileImageGetter : IImageGetter
    {
        //private readonly IAppConfig _config;

        //public FileImageGetter(IAppConfig config)
        //{
        //    _config = config;
        //}

        OpenFileDialog GetPathDialog = new OpenFileDialog();

        public Bitmap GetImage()
        {
            using (GetPathDialog)
            {
 //               if(GetPathDialog.ShowDialog() == DialogResult.OK)
//                {

                // norreturetusi konstantas prikist. kokie pasiulymai?
                //GetPathDialog.InitialDirectory = "C:\\";
                //GetPathDialog.Filter = "Image Files(*.PNG; *.JPG; *.GIF)| *.PNG; *.JPG; *.GIF | All files(*.*) | *.*";
                GetPathDialog.Filter = "Image Files(*.PNG; *.JPG; *.GIF)| *.PNG; *.JPG; *.GIF";
                GetPathDialog.FilterIndex = 2;
                GetPathDialog.RestoreDirectory = true;

                    var GetImagePath = GetPathDialog.FileName;
                    var imageBitmap = new Bitmap(GetImagePath);
                    return imageBitmap;
//                }
            };


            //    if (GetPathDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        Application.UseWaitCursor = true;
            //        return Bitmap(GetPathDialog);

            //}





        }

        //public async Task<Bitmap> GetImageAsync()
        //{
        //    var BitmapPicture = await Task.Run(() => new );
        //    return BitmapPicture;
        //}
    }
}
