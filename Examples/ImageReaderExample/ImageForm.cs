using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageReaderExample
{
    public partial class ImageForm : Form
    {
        private int zoomLevel = 0;

        public ImageForm()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "請選擇要開啟的圖片";
            openFileDialog.Filter = "(*.jpg;*.bmp;*.png)|*.jpeg;*.jpg;*.bmp;*.png|All Files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnImageRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                zoomLevel++;
                if (zoomLevel > 4)
                    zoomLevel = 4;
            }
            else if (e.Delta < 0)
            {
                zoomLevel--;
                if (zoomLevel < -3)
                    zoomLevel = -3;
            }

            zoomPicturebox();
        }

        private void zoomPicturebox()
        {
            switch (zoomLevel)
            {
                case -3:
                    pictureBox1.Width -= 210;
                    pictureBox1.Height -= 210;
                    break;
                case -2:
                    pictureBox1.Width -= 155;
                    pictureBox1.Height -= 155;
                    break;
                case -1:
                    pictureBox1.Width -= 65;
                    pictureBox1.Height -= 65;
                    break;
                case 0:
                    pictureBox1.Size = new Size(850, 1100);
                    break;
                case 1:
                    pictureBox1.Width += 75;
                    pictureBox1.Height += 75;
                    break;
                case 2:
                    pictureBox1.Width += 150;
                    pictureBox1.Height += 150;
                    break;
                case 3:
                    pictureBox1.Width += 175;
                    pictureBox1.Height += 175;
                    break;
                case 4:
                    pictureBox1.Width += 200;
                    pictureBox1.Height += 200;
                    break;
            }

            pictureBox1.Refresh(); // 刷新 PictureBox 控件，防止图像变得模糊
        }

        private void CropImage(Rectangle cropRegion)
        {
            // 创建一个新的 Bitmap 对象，大小与裁剪区域相同
            Bitmap croppedImage = new Bitmap(cropRegion.Width, cropRegion.Height);

            // 使用 Graphics 对象将原始图像的指定区域绘制到新的 Bitmap 中
            using (Graphics graphics = Graphics.FromImage(croppedImage))
            {
                graphics.DrawImage(pictureBox1.Image, new Rectangle(0, 0, cropRegion.Width, cropRegion.Height), cropRegion, GraphicsUnit.Pixel);
            }

            // 将裁剪后的图像设置到 PictureBox 控件中
            pictureBox1.Image = croppedImage;

            // 保存
            croppedImage.Save(DateTime.Now.ToString("yyyyMMddhhmmss") + ".png");
        }

        private void btnImageCrop_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                CropImage(new Rectangle(0, 100, 1280, 145));
            }
        }
    }
}
