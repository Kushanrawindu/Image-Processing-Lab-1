namespace FirstProgram
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.graybtn = new System.Windows.Forms.Button();
            this.thresholdbtn = new System.Windows.Forms.Button();
            this.negativebtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 365);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(946, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(438, 365);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // graybtn
            // 
            this.graybtn.Location = new System.Drawing.Point(654, 163);
            this.graybtn.Name = "graybtn";
            this.graybtn.Size = new System.Drawing.Size(136, 35);
            this.graybtn.TabIndex = 2;
            this.graybtn.Text = "Gray Scale >>";
            this.graybtn.UseVisualStyleBackColor = true;
            this.graybtn.Click += new System.EventHandler(this.graybtn_Click);
            // 
            // thresholdbtn
            // 
            this.thresholdbtn.Location = new System.Drawing.Point(654, 253);
            this.thresholdbtn.Name = "thresholdbtn";
            this.thresholdbtn.Size = new System.Drawing.Size(136, 35);
            this.thresholdbtn.TabIndex = 3;
            this.thresholdbtn.Text = "Threshold >>";
            this.thresholdbtn.UseVisualStyleBackColor = true;
            this.thresholdbtn.Click += new System.EventHandler(this.thresholdbtn_Click);
            // 
            // negativebtn
            // 
            this.negativebtn.Location = new System.Drawing.Point(654, 348);
            this.negativebtn.Name = "negativebtn";
            this.negativebtn.Size = new System.Drawing.Size(136, 35);
            this.negativebtn.TabIndex = 4;
            this.negativebtn.Text = "Negative >>";
            this.negativebtn.UseVisualStyleBackColor = true;
            this.negativebtn.Click += new System.EventHandler(this.negativebtn_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(264, 541);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(113, 44);
            this.loadbtn.TabIndex = 5;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 745);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.negativebtn);
            this.Controls.Add(this.thresholdbtn);
            this.Controls.Add(this.graybtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button graybtn;
        private System.Windows.Forms.Button thresholdbtn;
        private System.Windows.Forms.Button negativebtn;
        private System.Windows.Forms.Button loadbtn;
    }
}

