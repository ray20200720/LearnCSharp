using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFileUploadExample
{
    public partial class UploadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Reference: https://www.twblogs.net/a/5ea4db616052e135c9308e70
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //【1】判斷文件是否存在
            if (fileup.HasFile)
            {
                //【2】獲取文件的大小，判斷是否符合設置要求
                //1mb=1024kb
                //1kb=1024byte
                double fileLength = fileup.FileContent.Length / (1024.0 * 1024.0);
                //獲取配置文件中上傳文件大小的限制
                double limitLength = Convert.ToDouble(ConfigurationManager.AppSettings["fileMaxLength"]) / 1024.0;
                if (fileLength > limitLength)
                {
                    lblMsg.Text = $"上傳文件不能超過{limitLength}MB";
                    return;
                }
                //【3】獲取文件名，判斷文件擴展名是否符合要求
                string fileName = fileup.FileName;
                //判斷文件是否是exe文件，則不能上傳
                if (fileName.Substring(fileName.LastIndexOf(".")).ToLower() == ".exe")
                {
                    lblMsg.Text = "不能上傳應用程序";
                    return;
                }
                //【4】修改文件名稱
                //一般情況下，上傳的文件服務器中保存時不會採取原文件名，因爲客戶端用戶是非常龐大的，所以要保證每個客戶端上傳的文件不能被覆蓋
                fileName = DateTime.Now.ToString("yyyyMMddhhmmssms") + "_" + fileName;
                //【5】獲取服務器中存儲文件的路徑
                //"~"代表應用程序的根目錄，從服務器的根目錄尋找
                string path = Server.MapPath("~/UPFiles");
                //【6】上傳文件
                try
                {
                    fileup.SaveAs(path + "/" + fileName);
                    lblMsg.Text = "文件上傳成功！";
                }
                catch (Exception ex)
                {
                    lblMsg.Text = $"文件上傳失敗：{ex.Message}";
                }

            }
        }
    }
}