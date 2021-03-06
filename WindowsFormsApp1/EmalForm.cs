using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Net.Mime;
//using DevExpress.Utils;
using System.Threading;

using Microsoft.Extensions.Configuration;
using EmailSend;
using static EmailSend.StartJsonConfig;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class EmalForm : Form
    {
        public EmalForm()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var str = " Hellow Word "; 
            //MessageBox.Show($"我的第一个{str.Trim()}！");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)

        {

            if (WindowState == FormWindowState.Minimized)

            {

                this.Hide();

                this.notifyIcon1.Visible = true;

                //弹气泡/通知框提示

                this.notifyIcon1.ShowBalloonTip(20, "EmailSend.EXE", "软件最小化", ToolTipIcon.Info);

            }

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)

        {

            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {

                this.Show();

                this.WindowState = System.Windows.Forms.FormWindowState.Normal;

            }
            else
            {
                this.Hide();
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

            }

        }

        private void ExitMainFormMenuitem_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var str = AppConfigurtaionServices.Configuration["ConnectionStrings:YX"];

            for (int i = 0; i <1; i++)
            {
                textBox2.Text += Guid.NewGuid().ToString() + Environment.NewLine+ str;
                i++;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #region 使用委托，异步 或  多线程

        #endregion


        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtSendyj.Text.Replace(" ", ""))|| 
                    string.IsNullOrEmpty(txtSendSQM.Text.Replace(" ", ""))|| 
                    string.IsNullOrEmpty(cmbyx.Text.Replace(" ", ""))||
                    string.IsNullOrEmpty(textBox2.Text.Replace(" ", ""))
                    )
                {
                    MessageBox.Show("必填项为空");
                    return;
                }

                //实例化一个SmtpClient类。
                SmtpClient client = new SmtpClient();
                //在这里我使用的是qq邮箱，所以是smtp.qq.com，如果你使用的是126邮箱，那么就是smtp.126.com。
                client.Host = "smtp.qq.com";
                //使用安全加密连接。
                client.EnableSsl = false;
                //不和请求一块发送。
                client.UseDefaultCredentials = false;
                //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
                client.Credentials = new NetworkCredential(txtSendyj.Text.Replace(" ",""), txtSendSQM.Text.Replace(" ", ""));
                //实例化一个发送邮件类。
                MailMessage mailMessage = new MailMessage();
                //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
                mailMessage.From = new MailAddress(txtSendyj.Text.Replace(" ", ""));
                //收件人邮箱地址。

                var sjr = cmbyx.Text.Split(';') ;

                for (int i = 0; i < sjr.Length; i++)
                {
                    //使用异步
                    delegate_Emailcom run = new delegate_Emailcom(Emailcom);
                    IAsyncResult result = run.BeginInvoke(mailMessage, sjr[i], null, null);

                }

                /*
                for (int i = 0; i < sjr.Length; i++)
                {
                    Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");

                    if (!r.IsMatch(sjr[i].ToString()))
                    {
                        textBox3.Text += $"{sjr[i].ToString()}不是邮箱格式" + Environment.NewLine + Environment.NewLine;
                        continue;
                    }
                    mailMessage.To.Add(new MailAddress(sjr[i].ToString()));

                }
                */

                //邮件标题。
                mailMessage.Subject = "QQ邮箱管理员";
                string verificationcode = createrandom();
                //邮件内容。
                mailMessage.Body =  verificationcode;

                string fileName = lblfj.Text;

                if (!string.IsNullOrEmpty(fileName))
                {               
                    if (File.Exists(fileName))
                    {
                        //构造一个附件对象
                        Attachment attach = new Attachment(fileName);
                        //得到文件的信息
                        ContentDisposition disposition = attach.ContentDisposition;
                        disposition.CreationDate = System.IO.File.GetCreationTime(fileName);
                        disposition.ModificationDate = System.IO.File.GetLastWriteTime(fileName);
                        disposition.ReadDate = System.IO.File.GetLastAccessTime(fileName);
                        //向邮件添加附件
                        mailMessage.Attachments.Add(attach);
                    }
                    else
                    {
                        textBox3.Text += "文件" + fileName + "未找到！" + Environment.NewLine + Environment.NewLine;
                        return;
                    }
                }
                //发送
                client.Send(mailMessage);
                textBox3.Text +="添加成功";
            }
            catch (Exception ex)
            {
                textBox3.Text +=ex.Message;
            }

        }

        private static readonly object SequenceLock = new object();
        public delegate void  delegate_Emailcom(MailMessage obj, string sjr);

        private void Emailcom(MailMessage obj,string sjr) 
        {
            lock (SequenceLock)
            {
                    Regex r = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");

                    if (!r.IsMatch(sjr))
                    {
                        textBox3.Text += $"{sjr}不是邮箱格式" + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                    obj.To.Add(new MailAddress(sjr.ToString()));
                   }
                    
            }
        }


        //生成6位数字和大写字母的验证码
        private string createrandom()
        {
            return textBox2.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2_Click(null,null);
        }

        private void btnyz_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            lblfj.Text = openFileDialog.FileName;
            
        }

        private void lblfj_Click(object sender, EventArgs e)
        {

        }

        private void btnLoding_Click(object sender, EventArgs e)
        {
            //using (WaitDialogForm dlg = new WaitDialogForm("请等待...", "正在发送...", new Size(250, 70), ParentForm))
            //{
                for (int i = 0; i < 1000; i++)
                {
                    Application.DoEvents();
                    button2_Click(null,null);
                }
            //}
        }

        private void menuItem_Show_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }

        private void menuItem_Hide_Click(object sender, EventArgs e)
        {
            HideMainForm();
        }

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            ExitMainForm();
        }

        #region 私有方法　处理窗体的　显示　隐藏　关闭(退出)
        private void ExitMainForm()
        {
            if (MessageBox.Show("您确定要退出化验数据接收程序吗？", "确认退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.notifyIcon1.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        private void HideMainForm()
        {
            this.Hide();
        }

        private void ShowMainForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }
        #endregion


        /// <summary>
        /// 超链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://zhidao.baidu.com/question/1608648715083706787.html";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //不使用shell启动
            p.StartInfo.RedirectStandardInput = true;//喊cmd接受标准输入
            p.StartInfo.RedirectStandardOutput = false;//不想听cmd讲话所以不要他输出
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示窗口
            p.Start();

            //向cmd窗口发送输入信息 后面的&exit告诉cmd运行好之后就退出
            p.StandardInput.WriteLine("start " + url + "&exit");
            p.StandardInput.AutoFlush = true;
            p.WaitForExit();//等待程序执行完退出进程
            p.Close();
        }
    }
}
