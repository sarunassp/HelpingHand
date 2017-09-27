using GREEDY.refactor.Services;

namespace GREEDY.refactor.View
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
            this.insertPictureButton = new System.Windows.Forms.Button();
            this.XMLdataGridView = new System.Windows.Forms.DataGridView();
            this.GreedyLogo = new System.Windows.Forms.PictureBox();
            this.TakeAPictureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.XMLdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreedyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // insertPictureButton
            // 
            this.insertPictureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.insertPictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertPictureButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPictureButton.Location = new System.Drawing.Point(12, 320);
            this.insertPictureButton.Name = "insertPictureButton";
            this.insertPictureButton.Size = new System.Drawing.Size(137, 50);
            this.insertPictureButton.TabIndex = 0;
            this.insertPictureButton.Text = "ĮKELTI NUOTRAUKĄ";
            this.insertPictureButton.UseVisualStyleBackColor = false;
            this.insertPictureButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // XMLdataGridView
            // 
            this.XMLdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XMLdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.XMLdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XMLdataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.XMLdataGridView.Location = new System.Drawing.Point(12, 376);
            this.XMLdataGridView.Name = "XMLdataGridView";
            this.XMLdataGridView.Size = new System.Drawing.Size(293, 272);
            this.XMLdataGridView.TabIndex = 2;
            this.XMLdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GreedyLogo
            // 
            this.GreedyLogo.Image = ((System.Drawing.Image)(resources.GetObject("GreedyLogo.Image")));
            this.GreedyLogo.Location = new System.Drawing.Point(12, 12);
            this.GreedyLogo.Name = "GreedyLogo";
            this.GreedyLogo.Size = new System.Drawing.Size(293, 293);
            this.GreedyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GreedyLogo.TabIndex = 4;
            this.GreedyLogo.TabStop = false;
            this.GreedyLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TakeAPictureButton
            // 
            this.TakeAPictureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.TakeAPictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TakeAPictureButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeAPictureButton.Location = new System.Drawing.Point(168, 320);
            this.TakeAPictureButton.Name = "TakeAPictureButton";
            this.TakeAPictureButton.Size = new System.Drawing.Size(137, 50);
            this.TakeAPictureButton.TabIndex = 5;
            this.TakeAPictureButton.Text = "FOTOGRAFUOTI ČEKĮ";
            this.TakeAPictureButton.UseVisualStyleBackColor = false;
            this.TakeAPictureButton.Click += new System.EventHandler(this.TakePhoto_btnOCR_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 660);
            this.Controls.Add(this.TakeAPictureButton);
            this.Controls.Add(this.GreedyLogo);
            this.Controls.Add(this.XMLdataGridView);
            this.Controls.Add(this.insertPictureButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "GREEDY";
            ((System.ComponentModel.ISupportInitialize)(this.XMLdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreedyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertPictureButton;
        private System.Windows.Forms.DataGridView XMLdataGridView;
        private System.Windows.Forms.PictureBox GreedyLogo;
        private System.Windows.Forms.Button TakeAPictureButton;
        private ReceiptService receiptService;

        public MainScreen(ReceiptService receiptService)
        {
            this.receiptService = receiptService;
        }
    }
}