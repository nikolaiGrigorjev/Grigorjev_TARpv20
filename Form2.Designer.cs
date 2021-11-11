namespace WindowsFormss
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnText = new System.Windows.Forms.Button();
            this.joke = new System.Windows.Forms.Label();
            this.bqq = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pilt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pilt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnText.Location = new System.Drawing.Point(223, 39);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(382, 86);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "Вернутся ";
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // joke
            // 
            this.joke.AutoSize = true;
            this.joke.Location = new System.Drawing.Point(352, 223);
            this.joke.Name = "joke";
            this.joke.Size = new System.Drawing.Size(0, 13);
            this.joke.TabIndex = 1;
            this.joke.Click += new System.EventHandler(this.label1_Click);
            // 
            // bqq
            // 
            this.bqq.BackColor = System.Drawing.Color.Wheat;
            this.bqq.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bqq.Location = new System.Drawing.Point(50, 269);
            this.bqq.Name = "bqq";
            this.bqq.Size = new System.Drawing.Size(195, 159);
            this.bqq.TabIndex = 2;
            this.bqq.Text = "Click me ";
            this.bqq.UseVisualStyleBackColor = false;
            this.bqq.Click += new System.EventHandler(this.bqq_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "13dac232d708db7cdfc4f7729baca16f.jpg");
            // 
            // pilt
            // 
            this.pilt.Location = new System.Drawing.Point(322, 296);
            this.pilt.Name = "pilt";
            this.pilt.Size = new System.Drawing.Size(139, 113);
            this.pilt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pilt.TabIndex = 5;
            this.pilt.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pilt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bqq);
            this.Controls.Add(this.joke);
            this.Controls.Add(this.btnText);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pilt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Label joke;
        private System.Windows.Forms.Button bqq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pilt;
    }
}