﻿using System;
using System.Windows.Forms;
using GREEDY.refactor.Services;

namespace GREEDY.refactor.View
{
    public partial class Greedy : Form
    {
        private readonly IReceiptService _receiptService;

        public Greedy (IReceiptService receiptService)
        {
            _receiptService = receiptService;
            InitializeComponent ();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            var processedReceipt = _receiptService.ProcessReceiptImage ();
            // show (processedReceipt);
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemList_CellContentClick()
        {
            
        }
    }
}
