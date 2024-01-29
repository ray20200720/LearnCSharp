using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsServiceInstallExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsServiceExisted(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach(ServiceController sc in services)
            {
                if (sc.ServiceName.ToLower() == serviceName.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        private bool InstallService(string serviceFilePath)
        {
            try
            {
                using(AssemblyInstaller installer = new AssemblyInstaller())
                {
                    installer.UseNewContext = true;
                    installer.Path = serviceFilePath;
                    IDictionary savedState = new Hashtable();
                    installer.Install(savedState);
                    installer.Commit(savedState);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private bool UnInstallService(string serviceFilePath)
        {
            try
            {
                using (AssemblyInstaller installer = new AssemblyInstaller())
                {
                    installer.UseNewContext = true;
                    installer.Path = serviceFilePath;
                    installer.Uninstall(null);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private bool StartService(string serviceName)
        {
            try
            {
                using (ServiceController controller = new ServiceController(serviceName))
                {
                    if(controller.Status == ServiceControllerStatus.Stopped)
                    {
                        controller.Start();
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private bool StopService(string serviceName)
        {
            try
            {
                using (ServiceController controller = new ServiceController(serviceName))
                {
                    if (controller.Status == ServiceControllerStatus.Running)
                    {
                        controller.Stop();
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private string ServiceName
        {
            get { return this.txt_ServiceName.Text.Trim(); }
        }

        private string ServicePath
        {
            get { return this.txt_Path.Text.Trim(); }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(ServiceName))
            {

            }
            if (this.InstallService(ServicePath))
            {
                MessageBox.Show("服務安裝成功", "服務安裝");
            }
            else
            {
                MessageBox.Show("服務安裝失敗", "服務安裝");
            }
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(ServiceName))
            {
                if (this.StopService(ServiceName) && this.UnInstallService(ServicePath))
                {
                    MessageBox.Show("服務卸載成功", "服務卸載");
                }
                else
                {
                    MessageBox.Show("服務卸載失敗", "服務卸載");
                }
            }
            else
            {
                MessageBox.Show("服務卸載失敗: 服務不存在", "服務卸載");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(this.IsServiceExisted(ServiceName))
            {
                if (this.StartService(ServiceName))
                {
                    MessageBox.Show("服務啟動成功", "服務啟動");
                }
                else
                {
                    MessageBox.Show("服務啟動失敗", "服務啟動");
                }
            }
            else
            {
                MessageBox.Show("服務啟動失敗: 服務不存在", "服務啟動");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(ServiceName))
            {
                if (this.StopService(ServiceName))
                {
                    MessageBox.Show("服務停止成功", "服務停止");
                }
                else
                {
                    MessageBox.Show("服務停止失敗", "服務停止");
                }
            }
            else
            {
                MessageBox.Show("服務停止失敗: 服務不存在", "服務停止");
            }

        }
    }
}
