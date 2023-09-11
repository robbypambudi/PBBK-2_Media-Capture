namespace MediaCapture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxWebCamList = new ComboBox();
            buttonStart = new Button();
            buttonCapture = new Button();
            buttonSaveImage = new Button();
            buttonExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebCamList
            // 
            comboBoxWebCamList.FormattingEnabled = true;
            comboBoxWebCamList.Location = new Point(11, 11);
            comboBoxWebCamList.Name = "comboBoxWebCamList";
            comboBoxWebCamList.Size = new Size(125, 23);
            comboBoxWebCamList.TabIndex = 0;
            comboBoxWebCamList.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(142, 11);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // buttonCapture
            // 
            buttonCapture.Location = new Point(223, 11);
            buttonCapture.Name = "buttonCapture";
            buttonCapture.Size = new Size(75, 23);
            buttonCapture.TabIndex = 2;
            buttonCapture.Text = "Capture";
            buttonCapture.UseVisualStyleBackColor = true;
            buttonCapture.Click += buttonCapture_Click;
            // 
            // buttonSaveImage
            // 
            buttonSaveImage.Location = new Point(303, 11);
            buttonSaveImage.Name = "buttonSaveImage";
            buttonSaveImage.Size = new Size(75, 23);
            buttonSaveImage.TabIndex = 3;
            buttonSaveImage.Text = "Save Image";
            buttonSaveImage.UseVisualStyleBackColor = true;
            buttonSaveImage.Click += buttonSaveImage_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(713, 10);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += button1_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(11, 49);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(777, 379);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(391, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(383, 373);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonExit);
            Controls.Add(buttonSaveImage);
            Controls.Add(buttonCapture);
            Controls.Add(buttonStart);
            Controls.Add(comboBoxWebCamList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWebCamList;
        private Button buttonStart;
        private Button buttonCapture;
        private Button buttonSaveImage;
        private Button buttonExit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}