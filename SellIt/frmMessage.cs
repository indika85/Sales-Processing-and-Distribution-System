using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Diagnostics;

namespace SellIt
{
    public partial class frmMessage : Form
    {
        public string reportName = Application.StartupPath + "\\Temp_SysInfoReport.txt";
        public string fileName = Application.StartupPath+"\\SellIt_Log.txt";
        public string error;
        public Size defaultSize;
        public Size expandedSize;
        public static frmMessage fm = null;
        public frmMessage()
        {
            if (fm == null)
                fm = this;
          InitializeComponent();
        }
        public frmMessage(Exception ex)
        {
            if (fm == null)
                fm = this;
            defaultSize = new Size(467, 215);
            expandedSize = new Size(467, 452);
            error = ex.ToString();
            

            InitializeComponent();
            this.riBoMessage.Text = ex.Message.ToString();
            setErrors();
            createLog(ex);
        }
        public void setErrors()
        {
            richTextBox1.Text = error;
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            this.Size = defaultSize;
            btnDetails.Text = "Details ->>";
            btnSend.Focus();
            TopMost = true;
            createErrorReport();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            linkLabel2.Visible = false;
           if (btnDetails.Text == "Details ->>")
            {
                this.Size = expandedSize;
                btnDetails.Text = "<<- Simple";
                setErrors();
            }
            else
            {
                this.Size = defaultSize;
                btnDetails.Text = "Details ->>";
            }
        }

        private void frmMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Desk.Enabled = true;
            deleteReport();
            fm = null;
        }

        private void getSysInfo()
        {

        }

        private void createLog(Exception ex)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    StreamWriter logWriter = File.AppendText(fileName);
                    logWriter.WriteLine("==========================================================================");
                    logWriter.WriteLine("System Date : " + DateTime.Now.ToString());
                    logWriter.WriteLine(ex.ToString());
                    logWriter.Close();
                }
                else
                {
                    StreamWriter logWriter = File.CreateText(fileName);
                    logWriter.WriteLine("SellIt Log File. " + "  ---DO NOT MODIFY THE CONTENT OF THIS FILE!----");
                    logWriter.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void createErrorReport()
        {
          //"Win32_DiskDrive"
          //"Win32_OperatingSystem"
          //"Win32_Processor"
          //"Win32_ComputerSystem"
          //"Win32_StartupCommand"
          //"Win32_ProgramGroup",
          //"Win32_SystemDevices"

            ManagementObjectSearcher s = new ManagementObjectSearcher("SELECT LocalDateTime, MaxProcessMemorySize,FreeVirtualMemory,FreePhysicalMemory,FreeSpaceInPagingFiles,Caption,CSDVersion FROM Win32_OperatingSystem");
            //MessageBox.Show(s.Get().Count.ToString());
            try
            {
                foreach (ManagementObject obj in s.Get())
                {
                    PropertyDataCollection col = obj.Properties;
                    foreach (PropertyData sp in col)
                    {
                        StreamWriter reportWriter;
                        reportWriter = File.AppendText(reportName);
                        reportWriter.WriteLine(sp.Name.ToString() + " - " + sp.Value.ToString());
                        reportWriter.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void deleteReport()
        {
            if (File.Exists(reportName))
                File.Delete(reportName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            deleteReport();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.Visible = true;
            if (btnDetails.Text == "Details ->>")
            {
                this.Size = expandedSize;
                btnDetails.Text = "<<- Simple";
            }

            string message = string.Empty;
            if(File.Exists(reportName))
            {
                try
                {
                    StreamReader reportReader = new StreamReader(reportName);
                    message=reportReader.ReadToEnd().ToString();
                    reportReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            richTextBox1.Text=message;
            if (File.Exists(fileName))
            {
                //MessageBox.Show("llll");
                FileInfo f=new FileInfo(fileName);
                richTextBox1.Text += "\n" + "Following Log file will also be included" +"\n"+ f.FullName.ToString()+"\n"+"Size of the file : " +(f.Length/1024).ToString()+" KB";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (File.Exists(fileName))
                Process.Start(fileName);
            
        }
    }
}