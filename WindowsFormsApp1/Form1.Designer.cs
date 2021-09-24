namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtyzm = new System.Windows.Forms.TextBox();
            this.lblyzm = new System.Windows.Forms.Label();
            this.lblyx = new System.Windows.Forms.Label();
            this.btnyz = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnsf = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblfj = new System.Windows.Forms.Label();
            this.btnLoding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSendyj = new System.Windows.Forms.TextBox();
            this.txtSendSQM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbyx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.menuItem;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuItem
            // 
            this.menuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyIcon1ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.隐藏ToolStripMenuItem,
            this.退出ToolStripMenuItem1,
            this.退出ToolStripMenuItem2});
            this.menuItem.Name = "menuItem";
            resources.ApplyResources(this.menuItem, "menuItem");
            // 
            // notifyIcon1ToolStripMenuItem
            // 
            this.notifyIcon1ToolStripMenuItem.Name = "notifyIcon1ToolStripMenuItem";
            resources.ApplyResources(this.notifyIcon1ToolStripMenuItem, "notifyIcon1ToolStripMenuItem");
            this.notifyIcon1ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Show_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.ExitMainFormMenuitem_Click);
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            resources.ApplyResources(this.隐藏ToolStripMenuItem, "隐藏ToolStripMenuItem");
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.menuItem_Hide_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            resources.ApplyResources(this.退出ToolStripMenuItem1, "退出ToolStripMenuItem1");
            // 
            // 退出ToolStripMenuItem2
            // 
            this.退出ToolStripMenuItem2.Name = "退出ToolStripMenuItem2";
            resources.ApplyResources(this.退出ToolStripMenuItem2, "退出ToolStripMenuItem2");
            this.退出ToolStripMenuItem2.Click += new System.EventHandler(this.menuItem_Exit_Click);
            // 
            // txtyzm
            // 
            resources.ApplyResources(this.txtyzm, "txtyzm");
            this.txtyzm.Name = "txtyzm";
            // 
            // lblyzm
            // 
            resources.ApplyResources(this.lblyzm, "lblyzm");
            this.lblyzm.Name = "lblyzm";
            // 
            // lblyx
            // 
            resources.ApplyResources(this.lblyx, "lblyx");
            this.lblyx.ForeColor = System.Drawing.Color.DeepPink;
            this.lblyx.Name = "lblyx";
            // 
            // btnyz
            // 
            resources.ApplyResources(this.btnyz, "btnyz");
            this.btnyz.Name = "btnyz";
            this.btnyz.UseVisualStyleBackColor = true;
            this.btnyz.Click += new System.EventHandler(this.btnyz_Click);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // btnsf
            // 
            resources.ApplyResources(this.btnsf, "btnsf");
            this.btnsf.Name = "btnsf";
            this.btnsf.UseVisualStyleBackColor = true;
            this.btnsf.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // lblfj
            // 
            resources.ApplyResources(this.lblfj, "lblfj");
            this.lblfj.Name = "lblfj";
            this.lblfj.Click += new System.EventHandler(this.lblfj_Click);
            // 
            // btnLoding
            // 
            resources.ApplyResources(this.btnLoding, "btnLoding");
            this.btnLoding.Name = "btnLoding";
            this.btnLoding.UseVisualStyleBackColor = true;
            this.btnLoding.Click += new System.EventHandler(this.btnLoding_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtSendyj
            // 
            resources.ApplyResources(this.txtSendyj, "txtSendyj");
            this.txtSendyj.Name = "txtSendyj";
            // 
            // txtSendSQM
            // 
            resources.ApplyResources(this.txtSendSQM, "txtSendSQM");
            this.txtSendSQM.Name = "txtSendSQM";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cmbyx
            // 
            resources.ApplyResources(this.cmbyx, "cmbyx");
            this.cmbyx.Name = "cmbyx";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Name = "label2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Name = "label8";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnsf;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnLoding);
            this.Controls.Add(this.btnsf);
            this.Controls.Add(this.btnyz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblyx);
            this.Controls.Add(this.lblfj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblyzm);
            this.Controls.Add(this.cmbyx);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtSendSQM);
            this.Controls.Add(this.txtSendyj);
            this.Controls.Add(this.txtyzm);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblyzm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnyz;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblyx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsf;
        private System.Windows.Forms.TextBox txtyzm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblfj;
        private System.Windows.Forms.Button btnLoding;
        private System.Windows.Forms.ContextMenuStrip menuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyIcon1ToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripSeparator 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSendyj;
        private System.Windows.Forms.TextBox txtSendSQM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cmbyx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

