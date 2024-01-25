using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryExample;

namespace WebApplicationFileUploadImageExample.Pages
{
    public partial class PictureUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if(this.fileSelect.FileName == "")
            {
                this.labTipMsg.Text = "上傳檔案不能為空";
                return;
            }

            // 如果確認了上傳檔案,判斷檔案類型是否符合要求
            if (this.fileSelect.HasFile)
            {
                //1、檢查上傳的檔案路徑是否存在
                //獲取當前程序集的檔案路徑
                string applicationPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
                //獲取上傳的資料夾名稱
                string uploadFolder = ConfigurationManager.AppSettings["UploadImage"] == null ? "UploadImages" : ConfigurationManager.AppSettings["UploadImage"].ToString();
                //獲取限制檔案大小 MB
                int uploadSize = ConfigurationManager.AppSettings["UploadFileSize"] == null ? 4 : Convert.ToInt32(ConfigurationManager.AppSettings["UploadFileSize"]);
                //獲取程序集檔案路徑+資料夾路径
                string toServerPath = applicationPath + "\\" + uploadFolder;
                //拼接上年月資料夾(D:\\UploadFiles\\202401)
                toServerPath = toServerPath + "\\" + DateTime.Now.ToString(ConstName.DateFormat.yyyyMM);
                //判斷服務器檔案夾路徑是否存在 
                if(!Directory.Exists(toServerPath))
                {
                    //不存在則創建
                    Directory.CreateDirectory(toServerPath);
                }

                //獲取上傳檔案的後綴
                string fileExt = Path.GetExtension(this.fileSelect.FileName).ToLower();
                string[] fileExts = { ".jpg", ".jpeg", ".gif", ".png", ".bmp", ".ico" };
                //判斷檔案類型是否符合要求
                if(fileExts.Contains(fileExt))
                {
                    //檢查檔案大小
                    if(fileSelect.PostedFile.ContentLength > (uploadSize * 1024 * 1024))
                    {
                        this.labTipMsg.Text = string.Format("上傳檔案超過最大限制{0}MB!", uploadSize);
                    }
                    else
                    {
                        try
                        {
                            // 獲取新檔案名稱(包含後綴名), ex: my_pic.jpg
                            string newFileName = this.fileSelect.FileName;
                            //獲取絕對路徑，ex：D:\Project\LearnCSharpByExample\Example\UploadImages\202401\test_211104171831.jpg
                            string newFilePath = toServerPath + "\\" + newFileName;
                            //獲取相對路徑，ex：\UploadImages\202401\my_pic.jpg
                            string relativePath = newFilePath.Substring(applicationPath.Length, newFilePath.Length - applicationPath.Length);
                            //拼接返回應用圖片路徑(將符號（\）替換成符號（/）), 如： ~/UploadImages/202111/test_211104171831.png
                            string appImgPath = "~" + relativePath.Replace('\\', '/');

                            //檢查保存是否已存在，存在不做保存
                            if (!System.IO.File.Exists(newFilePath))
                            {
                                //3、保存上傳的檔案
                                this.fileSelect.SaveAs(newFilePath);
                            }
                            //顯示圖片  "~/UploadImage/" + FileUpload1.FileName;
                            this.imgShow.ImageUrl = appImgPath;

                            this.labTipMsg.Text = "上傳檔案成功!";
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
                else
                {
                    this.labTipMsg.Text = "只能上傳後綴名為 .gif, .jpg, .bmp, .png的檔案";
                }
            }
        }
    }
}