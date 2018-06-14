using System.IO;
namespace PhotoPhoto
{
    partial class IPhoto
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSrcTotalCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSrc = new MetroFramework.Controls.MetroButton();
            this.txtSrc = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDest = new MetroFramework.Controls.MetroButton();
            this.txtDest = new MetroFramework.Controls.MetroTextBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSubFolderDescription = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.lblCbDescription = new MetroFramework.Controls.MetroLabel();
            this.cbFolderStructure = new MetroFramework.Controls.MetroComboBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(20, 416);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(533, 23);
            this.progressBar.Style = MetroFramework.MetroColorStyle.Orange;
            this.progressBar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSrcTotalCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSrc);
            this.groupBox1.Controls.Add(this.txtSrc);
            this.groupBox1.Location = new System.Drawing.Point(20, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "원본경로";
            // 
            // lblSrcTotalCount
            // 
            this.lblSrcTotalCount.AutoSize = true;
            this.lblSrcTotalCount.Location = new System.Drawing.Point(106, 60);
            this.lblSrcTotalCount.Name = "lblSrcTotalCount";
            this.lblSrcTotalCount.Size = new System.Drawing.Size(0, 12);
            this.lblSrcTotalCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "선택된 파일 수 :";
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(452, 21);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(75, 21);
            this.btnSrc.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSrc.TabIndex = 1;
            this.btnSrc.Text = "...";
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(6, 21);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.ReadOnly = true;
            this.txtSrc.Size = new System.Drawing.Size(440, 21);
            this.txtSrc.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtSrc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDest);
            this.groupBox2.Controls.Add(this.txtDest);
            this.groupBox2.Location = new System.Drawing.Point(20, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 60);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대상경로";
            // 
            // btnDest
            // 
            this.btnDest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDest.Location = new System.Drawing.Point(452, 21);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 21);
            this.btnDest.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDest.TabIndex = 3;
            this.btnDest.Text = "...";
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(6, 21);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(440, 21);
            this.txtDest.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtDest.TabIndex = 2;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWworker_RunWorkerComplete);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(391, 372);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSubFolderDescription);
            this.groupBox3.Controls.Add(this.metroComboBox1);
            this.groupBox3.Controls.Add(this.lblCbDescription);
            this.groupBox3.Controls.Add(this.cbFolderStructure);
            this.groupBox3.Location = new System.Drawing.Point(20, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "옵션설정";
            // 
            // lblSubFolderDescription
            // 
            this.lblSubFolderDescription.AutoSize = true;
            this.lblSubFolderDescription.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSubFolderDescription.Location = new System.Drawing.Point(144, 64);
            this.lblSubFolderDescription.Name = "lblSubFolderDescription";
            this.lblSubFolderDescription.Size = new System.Drawing.Size(68, 15);
            this.lblSubFolderDescription.TabIndex = 7;
            this.lblSubFolderDescription.Text = "metroLabel1";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 19;
            this.metroComboBox1.Location = new System.Drawing.Point(9, 59);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(129, 25);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroComboBox1.TabIndex = 6;
            // 
            // lblCbDescription
            // 
            this.lblCbDescription.AutoSize = true;
            this.lblCbDescription.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCbDescription.Location = new System.Drawing.Point(144, 33);
            this.lblCbDescription.Name = "lblCbDescription";
            this.lblCbDescription.Size = new System.Drawing.Size(68, 15);
            this.lblCbDescription.TabIndex = 5;
            this.lblCbDescription.Text = "metroLabel1";
            // 
            // cbFolderStructure
            // 
            this.cbFolderStructure.FontSize = MetroFramework.MetroLinkSize.Small;
            this.cbFolderStructure.FormattingEnabled = true;
            this.cbFolderStructure.ItemHeight = 19;
            this.cbFolderStructure.Location = new System.Drawing.Point(9, 28);
            this.cbFolderStructure.Name = "cbFolderStructure";
            this.cbFolderStructure.Size = new System.Drawing.Size(129, 25);
            this.cbFolderStructure.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbFolderStructure.TabIndex = 4;
            this.cbFolderStructure.SelectedIndexChanged += new System.EventHandler(this.cbFolderStructure_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(478, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(20, 354);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 15);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "대상파일";
            // 
            // IPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(573, 459);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPhoto";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "PhotoPhoto";
            this.Load += new System.EventHandler(this.PhotoPhoto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSrc;
        private MetroFramework.Controls.MetroTextBox txtSrc;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnDest;
        private MetroFramework.Controls.MetroTextBox txtDest;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private MetroFramework.Controls.MetroButton btnStart;
        private System.Windows.Forms.Label lblSrcTotalCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cbFolderStructure;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroLabel lblCbDescription;
        private MetroFramework.Controls.MetroLabel lblSubFolderDescription;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

