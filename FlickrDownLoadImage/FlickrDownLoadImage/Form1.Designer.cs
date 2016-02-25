namespace FlickrDownLoadImage
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtx_Message01 = new System.Windows.Forms.RichTextBox();
            this.btnDownLoad01 = new System.Windows.Forms.Button();
            this.dtP_TimeTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtP_TimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDownload_Single = new System.Windows.Forms.Button();
            this.txtURL1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAsync = new System.Windows.Forms.Button();
            this.txtShutterStock_tag = new System.Windows.Forms.TextBox();
            this.txtShutterStockID = new System.Windows.Forms.TextBox();
            this.txtImageID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chx_DlOrg = new System.Windows.Forms.CheckBox();
            this.btn_Download_L = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 278);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download by Date";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtx_Message01);
            this.groupBox1.Controls.Add(this.btnDownLoad01);
            this.groupBox1.Controls.Add(this.dtP_TimeTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtP_TimeFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Explorer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rtx_Message01
            // 
            this.rtx_Message01.Location = new System.Drawing.Point(422, 19);
            this.rtx_Message01.Name = "rtx_Message01";
            this.rtx_Message01.Size = new System.Drawing.Size(324, 58);
            this.rtx_Message01.TabIndex = 5;
            this.rtx_Message01.Text = "";
            // 
            // btnDownLoad01
            // 
            this.btnDownLoad01.Location = new System.Drawing.Point(298, 19);
            this.btnDownLoad01.Name = "btnDownLoad01";
            this.btnDownLoad01.Size = new System.Drawing.Size(95, 57);
            this.btnDownLoad01.TabIndex = 4;
            this.btnDownLoad01.Text = "Download Image";
            this.btnDownLoad01.UseVisualStyleBackColor = true;
            this.btnDownLoad01.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtP_TimeTo
            // 
            this.dtP_TimeTo.Location = new System.Drawing.Point(78, 57);
            this.dtP_TimeTo.Name = "dtP_TimeTo";
            this.dtP_TimeTo.Size = new System.Drawing.Size(188, 20);
            this.dtP_TimeTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date To";
            // 
            // dtP_TimeFrom
            // 
            this.dtP_TimeFrom.Location = new System.Drawing.Point(78, 19);
            this.dtP_TimeFrom.Name = "dtP_TimeFrom";
            this.dtP_TimeFrom.Size = new System.Drawing.Size(188, 20);
            this.dtP_TimeFrom.TabIndex = 1;
            this.dtP_TimeFrom.Value = new System.DateTime(2015, 11, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date From";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Download_L);
            this.tabPage2.Controls.Add(this.chx_DlOrg);
            this.tabPage2.Controls.Add(this.txtStatus);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnDownload_Single);
            this.tabPage2.Controls.Add(this.txtURL1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Download Single";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(88, 60);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "status";
            // 
            // btnDownload_Single
            // 
            this.btnDownload_Single.Location = new System.Drawing.Point(683, 12);
            this.btnDownload_Single.Name = "btnDownload_Single";
            this.btnDownload_Single.Size = new System.Drawing.Size(75, 23);
            this.btnDownload_Single.TabIndex = 2;
            this.btnDownload_Single.Text = "DownLoad";
            this.btnDownload_Single.UseVisualStyleBackColor = true;
            this.btnDownload_Single.Click += new System.EventHandler(this.btnDownload_Single_Click);
            // 
            // txtURL1
            // 
            this.txtURL1.Location = new System.Drawing.Point(88, 14);
            this.txtURL1.Name = "txtURL1";
            this.txtURL1.Size = new System.Drawing.Size(573, 20);
            this.txtURL1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "URL";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAsync);
            this.tabPage3.Controls.Add(this.txtShutterStock_tag);
            this.tabPage3.Controls.Add(this.txtShutterStockID);
            this.tabPage3.Controls.Add(this.txtImageID);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(804, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "async shutterstock";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(139, 147);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(75, 23);
            this.btnAsync.TabIndex = 6;
            this.btnAsync.Text = "Sync";
            this.btnAsync.UseVisualStyleBackColor = true;
            // 
            // txtShutterStock_tag
            // 
            this.txtShutterStock_tag.Location = new System.Drawing.Point(139, 98);
            this.txtShutterStock_tag.Name = "txtShutterStock_tag";
            this.txtShutterStock_tag.Size = new System.Drawing.Size(547, 20);
            this.txtShutterStock_tag.TabIndex = 5;
            // 
            // txtShutterStockID
            // 
            this.txtShutterStockID.Location = new System.Drawing.Point(139, 57);
            this.txtShutterStockID.Name = "txtShutterStockID";
            this.txtShutterStockID.Size = new System.Drawing.Size(170, 20);
            this.txtShutterStockID.TabIndex = 4;
            // 
            // txtImageID
            // 
            this.txtImageID.Location = new System.Drawing.Point(139, 21);
            this.txtImageID.Name = "txtImageID";
            this.txtImageID.Size = new System.Drawing.Size(100, 20);
            this.txtImageID.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ShutterStockID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ImageID";
            // 
            // chx_DlOrg
            // 
            this.chx_DlOrg.AutoSize = true;
            this.chx_DlOrg.Location = new System.Drawing.Point(231, 62);
            this.chx_DlOrg.Name = "chx_DlOrg";
            this.chx_DlOrg.Size = new System.Drawing.Size(122, 17);
            this.chx_DlOrg.TabIndex = 5;
            this.chx_DlOrg.Text = "DownLoad Original?";
            this.chx_DlOrg.UseVisualStyleBackColor = true;
            // 
            // btn_Download_L
            // 
            this.btn_Download_L.Location = new System.Drawing.Point(683, 58);
            this.btn_Download_L.Name = "btn_Download_L";
            this.btn_Download_L.Size = new System.Drawing.Size(75, 23);
            this.btn_Download_L.TabIndex = 6;
            this.btn_Download_L.Text = "Download L";
            this.btn_Download_L.UseVisualStyleBackColor = true;
            this.btn_Download_L.Click += new System.EventHandler(this.btn_Download_L_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 273);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtP_TimeTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtP_TimeFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtx_Message01;
        private System.Windows.Forms.Button btnDownLoad01;
        private System.Windows.Forms.Button btnDownload_Single;
        private System.Windows.Forms.TextBox txtURL1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtShutterStock_tag;
        private System.Windows.Forms.TextBox txtShutterStockID;
        private System.Windows.Forms.TextBox txtImageID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.CheckBox chx_DlOrg;
        private System.Windows.Forms.Button btn_Download_L;
    }
}

