namespace _1.draw
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorlbl = new System.Windows.Forms.Label();
            this.linebtn = new System.Windows.Forms.Button();
            this.circlebtn = new System.Windows.Forms.Button();
            this.rectbtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mMoveLbl = new System.Windows.Forms.Label();
            this.mDownLbl = new System.Windows.Forms.Label();
            this.mUpLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(93, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 299);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // colorlbl
            // 
            this.colorlbl.BackColor = System.Drawing.Color.Red;
            this.colorlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorlbl.Location = new System.Drawing.Point(93, 9);
            this.colorlbl.Name = "colorlbl";
            this.colorlbl.Size = new System.Drawing.Size(32, 23);
            this.colorlbl.TabIndex = 1;
            this.colorlbl.Click += new System.EventHandler(this.colorlbl_Click);
            // 
            // linebtn
            // 
            this.linebtn.Location = new System.Drawing.Point(12, 47);
            this.linebtn.Name = "linebtn";
            this.linebtn.Size = new System.Drawing.Size(75, 23);
            this.linebtn.TabIndex = 2;
            this.linebtn.Text = "Line";
            this.linebtn.UseVisualStyleBackColor = true;
            this.linebtn.Click += new System.EventHandler(this.linebtn_Click);
            // 
            // circlebtn
            // 
            this.circlebtn.Location = new System.Drawing.Point(12, 88);
            this.circlebtn.Name = "circlebtn";
            this.circlebtn.Size = new System.Drawing.Size(75, 23);
            this.circlebtn.TabIndex = 3;
            this.circlebtn.Text = "Circle";
            this.circlebtn.UseVisualStyleBackColor = true;
            this.circlebtn.Click += new System.EventHandler(this.circlebtn_Click);
            // 
            // rectbtn
            // 
            this.rectbtn.Location = new System.Drawing.Point(12, 127);
            this.rectbtn.Name = "rectbtn";
            this.rectbtn.Size = new System.Drawing.Size(75, 23);
            this.rectbtn.TabIndex = 4;
            this.rectbtn.Text = "Rectangle";
            this.rectbtn.UseVisualStyleBackColor = true;
            this.rectbtn.Click += new System.EventHandler(this.rectbtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(292, 8);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(239, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Width:";
            // 
            // mMoveLbl
            // 
            this.mMoveLbl.AutoSize = true;
            this.mMoveLbl.Location = new System.Drawing.Point(12, 177);
            this.mMoveLbl.Name = "mMoveLbl";
            this.mMoveLbl.Size = new System.Drawing.Size(22, 13);
            this.mMoveLbl.TabIndex = 7;
            this.mMoveLbl.Text = "0:0";
            // 
            // mDownLbl
            // 
            this.mDownLbl.AutoSize = true;
            this.mDownLbl.Location = new System.Drawing.Point(12, 206);
            this.mDownLbl.Name = "mDownLbl";
            this.mDownLbl.Size = new System.Drawing.Size(22, 13);
            this.mDownLbl.TabIndex = 8;
            this.mDownLbl.Text = "0:0";
            // 
            // mUpLbl
            // 
            this.mUpLbl.AutoSize = true;
            this.mUpLbl.Location = new System.Drawing.Point(12, 234);
            this.mUpLbl.Name = "mUpLbl";
            this.mUpLbl.Size = new System.Drawing.Size(22, 13);
            this.mUpLbl.TabIndex = 9;
            this.mUpLbl.Text = "0:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 353);
            this.Controls.Add(this.mUpLbl);
            this.Controls.Add(this.mDownLbl);
            this.Controls.Add(this.mMoveLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rectbtn);
            this.Controls.Add(this.circlebtn);
            this.Controls.Add(this.linebtn);
            this.Controls.Add(this.colorlbl);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(288, 295);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint++";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label colorlbl;
        private System.Windows.Forms.Button linebtn;
        private System.Windows.Forms.Button circlebtn;
        private System.Windows.Forms.Button rectbtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mMoveLbl;
        private System.Windows.Forms.Label mDownLbl;
        private System.Windows.Forms.Label mUpLbl;
    }
}

