using System.Drawing;
using System.Windows.Forms;

namespace GREEDY.DataManagers
{
    class FileImageGetter : IImageGetter
    {
        private readonly IAppConfig _config;

        public FileImageGetter(IAppConfig config)
        {
            _config = config;
        }

        public OpenFileDialog GetPathDialog = new OpenFileDialog();

        public Bitmap GetImage()
        {
            using (GetPathDialog)
            {
                if (GetPathDialog.ShowDialog() == DialogResult.OK)
                {
                    //GetPathDialog.InitialDirectory = "C:\\";
                    //GetPathDialog.Filter = "Image Files(*.PNG; *.JPG; *.GIF)| *.PNG; *.JPG; *.GIF | All files(*.*) | *.*";
                    GetPathDialog.Filter = _config.Filter;
                    GetPathDialog.FilterIndex = 2;
                    GetPathDialog.RestoreDirectory = true;
                    var GetImagePath = GetPathDialog.FileName;

                    if (GetImagePath == "")
                    {
                        // what do you think about this part? how can I write exception if user close a window and do not select a picture/file?
                        return null;
                    }
                    else
                    {
                        var imageBitmap = new Bitmap(GetImagePath);
                        return imageBitmap;
                    }

                }
                return null;
                
            };
        }
    }
}
