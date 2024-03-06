using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms屏幕截图
{
    public partial class Form1 : Form
    {
        // https://www.cnblogs.com/fornet/archive/2013/03/09/2976182.html
        public Form1()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt(
            IntPtr hdcDest,//目标设备的句柄
            int nXDest,//目标对象的左上角x坐标
            int nYDest,//目标对象的左上角Y坐标
            int nWidth,//目标对象的矩形宽度
            int nHeight,//目标对象的矩形长度
            IntPtr hdcSrc,//源设备的句柄
            int nXSrc,//源对象的左上角x坐标
            int nYSrc,//源对象的左上角y坐标
            System.Int32 dwRop//光栅的操作值
            );
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr CreateDC(
            string lpszDriver,//驱动名称
            string lpszDevice,//设备名称
            string lpszOutput,//无用，设为null
            IntPtr lpInitData//任意的打印机数据
            );
        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr dc1 = CreateDC("DISPLAY", null, null, (IntPtr)null);
            //创建显示器的DC
            Graphics g1 = Graphics.FromHdc(dc1);
            //由一个指定设备的句柄创建一个新的Graphics对象
            Image MyImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, g1);
            //根据屏幕大小创建一个与之相同大小的Bitmap对象
            Graphics g2 = Graphics.FromImage(MyImage);


            //获得屏幕的句柄
            IntPtr dc3 = g1.GetHdc();
            //获得位图的句柄
            IntPtr dc2 = g2.GetHdc();

            BitBlt(dc2, 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, dc3, 0, 0, 13369376);
            g1.ReleaseHdc(dc3);
            //释放屏幕句柄
            g2.ReleaseHdc(dc2);
            //释放位图句柄

            MyImage.Save("D:\\MyJpeg.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
