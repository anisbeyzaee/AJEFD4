namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLocal = new System.Windows.Forms.Button();
            this.BackGround_pictureBox = new System.Windows.Forms.PictureBox();
            this.Classification_Lable = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.btn_Classify = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.ImageDisplay_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplay_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLocal.Location = new System.Drawing.Point(203, 188);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(75, 23);
            this.btnLocal.TabIndex = 0;
            this.btnLocal.Text = "Local ";
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // BackGround_pictureBox
            // 
            this.BackGround_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackGround_pictureBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackGround_pictureBox.Location = new System.Drawing.Point(299, 22);
            this.BackGround_pictureBox.Name = "BackGround_pictureBox";
            this.BackGround_pictureBox.Size = new System.Drawing.Size(1141, 732);
            this.BackGround_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGround_pictureBox.TabIndex = 1;
            this.BackGround_pictureBox.TabStop = false;
            // 
            // Classification_Lable
            // 
            this.Classification_Lable.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Classification_Lable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Classification_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classification_Lable.Location = new System.Drawing.Point(978, 718);
            this.Classification_Lable.Name = "Classification_Lable";
            this.Classification_Lable.Size = new System.Drawing.Size(440, 15);
            this.Classification_Lable.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(12, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Web";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_fileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fileName.HideSelection = false;
            this.textBox_fileName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_fileName.Location = new System.Drawing.Point(318, 720);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(610, 13);
            this.textBox_fileName.TabIndex = 5;
            // 
            // btn_Classify
            // 
            this.btn_Classify.Location = new System.Drawing.Point(12, 227);
            this.btn_Classify.Name = "btn_Classify";
            this.btn_Classify.Size = new System.Drawing.Size(266, 23);
            this.btn_Classify.TabIndex = 6;
            this.btn_Classify.Text = "Classify";
            this.btn_Classify.UseVisualStyleBackColor = true;
            this.btn_Classify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_log.Location = new System.Drawing.Point(12, 273);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(266, 410);
            this.textBox_log.TabIndex = 7;
            // 
            // ImageDisplay_PictureBox
            // 
            this.ImageDisplay_PictureBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ImageDisplay_PictureBox.Location = new System.Drawing.Point(318, 43);
            this.ImageDisplay_PictureBox.Name = "ImageDisplay_PictureBox";
            this.ImageDisplay_PictureBox.Size = new System.Drawing.Size(1100, 669);
            this.ImageDisplay_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageDisplay_PictureBox.TabIndex = 8;
            this.ImageDisplay_PictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1452, 766);
            this.Controls.Add(this.ImageDisplay_PictureBox);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.btn_Classify);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Classification_Lable);
            this.Controls.Add(this.BackGround_pictureBox);
            this.Controls.Add(this.btnLocal);
            this.Name = "Form1";
            this.Text = "AJE Fire Detection Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDisplay_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.PictureBox BackGround_pictureBox;
        private System.Windows.Forms.TextBox Classification_Lable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Button btn_Classify;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.PictureBox ImageDisplay_PictureBox;
    }
}

