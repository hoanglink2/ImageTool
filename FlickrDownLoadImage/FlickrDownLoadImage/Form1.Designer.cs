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
            this.btn_Download_L = new System.Windows.Forms.Button();
            this.chx_DlOrg = new System.Windows.Forms.CheckBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDownload_Single = new System.Windows.Forms.Button();
            this.txtURL1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn3_WriteTag = new System.Windows.Forms.Button();
            this.txt3_IndexTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt3_IndexFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt3_folderName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt3_database = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt2_SaveURL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt2_SaveFolder = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
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
            this.tabPage1.Text = "1. Download by Date";
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
            this.tabPage2.Controls.Add(this.txt2_SaveFolder);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt2_SaveURL);
            this.tabPage2.Controls.Add(this.label8);
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
            this.tabPage2.Text = "2. Download Single";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn3_WriteTag);
            this.tabPage5.Controls.Add(this.txt3_IndexTo);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.txt3_IndexFrom);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.txt3_folderName);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.txt3_database);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(804, 252);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "3. Write tag";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn3_WriteTag
            // 
            this.btn3_WriteTag.Location = new System.Drawing.Point(372, 182);
            this.btn3_WriteTag.Name = "btn3_WriteTag";
            this.btn3_WriteTag.Size = new System.Drawing.Size(75, 23);
            this.btn3_WriteTag.TabIndex = 8;
            this.btn3_WriteTag.Text = "Start Write";
            this.btn3_WriteTag.UseVisualStyleBackColor = true;
            this.btn3_WriteTag.Click += new System.EventHandler(this.btn3_WriteTag_Click);
            // 
            // txt3_IndexTo
            // 
            this.txt3_IndexTo.Location = new System.Drawing.Point(100, 153);
            this.txt3_IndexTo.Name = "txt3_IndexTo";
            this.txt3_IndexTo.Size = new System.Drawing.Size(100, 20);
            this.txt3_IndexTo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Index To";
            // 
            // txt3_IndexFrom
            // 
            this.txt3_IndexFrom.Location = new System.Drawing.Point(100, 108);
            this.txt3_IndexFrom.Name = "txt3_IndexFrom";
            this.txt3_IndexFrom.Size = new System.Drawing.Size(100, 20);
            this.txt3_IndexFrom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Index From";
            // 
            // txt3_folderName
            // 
            this.txt3_folderName.Location = new System.Drawing.Point(100, 66);
            this.txt3_folderName.Name = "txt3_folderName";
            this.txt3_folderName.Size = new System.Drawing.Size(347, 20);
            this.txt3_folderName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "folderName";
            // 
            // txt3_database
            // 
            this.txt3_database.Location = new System.Drawing.Point(100, 26);
            this.txt3_database.Name = "txt3_database";
            this.txt3_database.Size = new System.Drawing.Size(347, 20);
            this.txt3_database.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Database ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "save";
            // 
            // txt2_SaveURL
            // 
            this.txt2_SaveURL.Location = new System.Drawing.Point(88, 117);
            this.txt2_SaveURL.Name = "txt2_SaveURL";
            this.txt2_SaveURL.Size = new System.Drawing.Size(573, 20);
            this.txt2_SaveURL.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "save Folder";
            // 
            // txt2_SaveFolder
            // 
            this.txt2_SaveFolder.Location = new System.Drawing.Point(168, 155);
            this.txt2_SaveFolder.Name = "txt2_SaveFolder";
            this.txt2_SaveFolder.Size = new System.Drawing.Size(168, 20);
            this.txt2_SaveFolder.TabIndex = 10;
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
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.CheckBox chx_DlOrg;
        private System.Windows.Forms.Button btn_Download_L;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txt3_database;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt3_folderName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt3_IndexTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt3_IndexFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn3_WriteTag;
        private System.Windows.Forms.TextBox txt2_SaveURL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt2_SaveFolder;
        private System.Windows.Forms.Label label9;
    }
}

