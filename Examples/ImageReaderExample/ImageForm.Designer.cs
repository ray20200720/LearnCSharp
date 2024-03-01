namespace ImageReaderExample
{
    partial class ImageForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnImageRotate = new System.Windows.Forms.Button();
            this.btnImageCrop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 330);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(40, 381);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(157, 44);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnImageRotate
            // 
            this.btnImageRotate.Location = new System.Drawing.Point(219, 381);
            this.btnImageRotate.Name = "btnImageRotate";
            this.btnImageRotate.Size = new System.Drawing.Size(157, 44);
            this.btnImageRotate.TabIndex = 2;
            this.btnImageRotate.Text = "Image Rotate";
            this.btnImageRotate.UseVisualStyleBackColor = true;
            this.btnImageRotate.Click += new System.EventHandler(this.btnImageRotate_Click);
            // 
            // btnImageCrop
            // 
            this.btnImageCrop.Location = new System.Drawing.Point(405, 381);
            this.btnImageCrop.Name = "btnImageCrop";
            this.btnImageCrop.Size = new System.Drawing.Size(157, 44);
            this.btnImageCrop.TabIndex = 3;
            this.btnImageCrop.Text = "Image Crop";
            this.btnImageCrop.UseVisualStyleBackColor = true;
            this.btnImageCrop.Click += new System.EventHandler(this.btnImageCrop_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImageCrop);
            this.Controls.Add(this.btnImageRotate);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ImageForm";
            this.Text = "ImageReaderExample";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnImageRotate;
        private System.Windows.Forms.Button btnImageCrop;
    }
}

