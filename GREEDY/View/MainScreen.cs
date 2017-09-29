using System;
using System.Windows.Forms;
using GREEDY.Services;
using GREEDY.DataManagers;

namespace GREEDY.View
{
    public partial class MainScreen : Form
    {
        private readonly IReceiptService _receiptService;
        private readonly IImageGetter _photoImageGetter;
        private readonly IImageGetter _fileImageGetter;
  //      private readonly IAppConfig _config;

        public MainScreen(ReceiptService receiptService)
        {
            _receiptService = receiptService;
 //           _config = config;
            _photoImageGetter = new PhotoImageGetter();
            _fileImageGetter = new FileImageGetter();
            InitializeComponent();
        }

        private void InserFile_Button_Click(object sender, EventArgs e)
        {
            var image = _fileImageGetter.GetImage();
            Application.UseWaitCursor = true;
            InserFile_Button.Enabled = false;
            var processedReceipt = _receiptService.ProcessReceiptImage(image);
            
            //var receipt = await new EmguOcr().UseOCRAsync(ImageForOCR.FileName);

            Application.UseWaitCursor = false;
            InserFile_Button.Enabled = true;
            GC.Collect();
            // show (processedReceipt);
        }

        private void PictureFromCamera_Button_Click(object sender, EventArgs e)
        {
            var image = _photoImageGetter.GetImage();
            var processedReceipt = _receiptService.ProcessReceiptImage(image);
            // show (processedReceipt);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void XMLdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataViewScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
