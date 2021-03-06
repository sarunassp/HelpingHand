﻿using GREEDY.Services;

namespace GREEDY.View
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.InserFile_Button = new System.Windows.Forms.Button();
            this.PictureFromCamera_Button = new System.Windows.Forms.Button();
            this.XMLdataGridView = new System.Windows.Forms.DataGridView();
            this.DataViewScrollBar = new System.Windows.Forms.VScrollBar();
            this.GREEDYLOGO = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.XMLdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREEDYLOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // InserFile_Button
            // 
            this.InserFile_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.InserFile_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InserFile_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.InserFile_Button.Location = new System.Drawing.Point(10, 317);
            this.InserFile_Button.Name = "InserFile_Button";
            this.InserFile_Button.Size = new System.Drawing.Size(137, 48);
            this.InserFile_Button.TabIndex = 0;
            this.InserFile_Button.Text = "ĮKELTI NUOTRAUKĄ";
            this.InserFile_Button.UseVisualStyleBackColor = false;
            this.InserFile_Button.Click += new System.EventHandler(this.InserFile_Button_Click);
            // 
            // PictureFromCamera_Button
            // 
            this.PictureFromCamera_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.PictureFromCamera_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureFromCamera_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.PictureFromCamera_Button.Location = new System.Drawing.Point(169, 317);
            this.PictureFromCamera_Button.Name = "PictureFromCamera_Button";
            this.PictureFromCamera_Button.Size = new System.Drawing.Size(137, 48);
            this.PictureFromCamera_Button.TabIndex = 2;
            this.PictureFromCamera_Button.Text = "FOTOGRAFUOTI ČEKĮ";
            this.PictureFromCamera_Button.UseVisualStyleBackColor = false;
            this.PictureFromCamera_Button.Click += new System.EventHandler(this.PictureFromCamera_Button_Click);
            // 
            // XMLdataGridView
            // 
            this.XMLdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.XMLdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XMLdataGridView.Location = new System.Drawing.Point(12, 371);
            this.XMLdataGridView.Name = "XMLdataGridView";
            this.XMLdataGridView.Size = new System.Drawing.Size(294, 265);
            this.XMLdataGridView.TabIndex = 3;
            this.XMLdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XMLdataGridView_CellContentClick);
            // 
            // DataViewScrollBar
            // 
            this.DataViewScrollBar.Location = new System.Drawing.Point(291, 371);
            this.DataViewScrollBar.Name = "DataViewScrollBar";
            this.DataViewScrollBar.Size = new System.Drawing.Size(15, 265);
            this.DataViewScrollBar.TabIndex = 4;
            this.DataViewScrollBar.Visible = false;
            this.DataViewScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataViewScrollBar_Scroll);
            // 
            // GREEDYLOGO
            // 
            this.GREEDYLOGO.ErrorImage = global::GREEDY.Properties.Resources.MainLogo;
            this.GREEDYLOGO.Image = global::GREEDY.Properties.Resources.MainLogo;
            this.GREEDYLOGO.InitialImage = global::GREEDY.Properties.Resources.MainLogo;
            this.GREEDYLOGO.Location = new System.Drawing.Point(10, 12);
            this.GREEDYLOGO.Name = "GREEDYLOGO";
            this.GREEDYLOGO.Size = new System.Drawing.Size(296, 299);
            this.GREEDYLOGO.TabIndex = 1;
            this.GREEDYLOGO.TabStop = false;
            this.GREEDYLOGO.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(318, 646);
            this.Controls.Add(this.DataViewScrollBar);
            this.Controls.Add(this.XMLdataGridView);
            this.Controls.Add(this.PictureFromCamera_Button);
            this.Controls.Add(this.GREEDYLOGO);
            this.Controls.Add(this.InserFile_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "GREEDY";
            ((System.ComponentModel.ISupportInitialize)(this.XMLdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREEDYLOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InserFile_Button;
        private System.Windows.Forms.PictureBox GREEDYLOGO;
        private System.Windows.Forms.Button PictureFromCamera_Button;
        private System.Windows.Forms.DataGridView XMLdataGridView;
        private System.Windows.Forms.VScrollBar DataViewScrollBar;

        //private ReceiptService receiptService;

        //public MainScreen(ReceiptService receiptService)
        //{
        //    this.receiptService = receiptService;
        //}
    }
}