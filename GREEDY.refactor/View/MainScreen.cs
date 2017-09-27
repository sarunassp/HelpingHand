using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GREEDY.refactor.Services;

namespace GREEDY.refactor.View
{
    public partial class MainScreen : Form
    {
        private readonly IReceiptService _receiptService;

        public MainScreen(IReceiptService receiptService)
        {
            _receiptService = receiptService;
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void InsertPhoto_btnOCR_Click(object sender, EventArgs e)
        {
            var processedReceipt = _receiptService.ProcessReceiptImage();
            // show (processedReceipt);
        }

        private void TakePhoto_btnOCR_Click(object sender, EventArgs e)
        {
            var processedReceipt = _receiptService.ProcessReceiptImage();
            // show (processedReceipt);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
