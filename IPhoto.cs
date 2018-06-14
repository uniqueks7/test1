using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace PhotoPhoto
{
    public partial class IPhoto : MetroForm
    {
        private string srcDir = "";
        private string destDir = "";
        private int totalFileCount = 0;
        List<string> getFiles;
        int folderStructure = 0;


        public IPhoto()
        {
            InitializeComponent();
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowNewFolderButton = true;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                txtSrc.Text = fb.SelectedPath;
                srcDir = fb.SelectedPath;
                searchedFiles();
                progressBar.Value = 0;
                lblSrcTotalCount.Text = totalFileCount + "개";
            }   
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowNewFolderButton = true;
            if(fb.ShowDialog() == DialogResult.OK)
            {
                txtDest.Text = fb.SelectedPath;
                destDir = fb.SelectedPath;
                progressBar.Value = 0;
            }
            
        }

        private void searchedFiles()
        {
            var allowedExtensions = new[] { ".jpg", ".gif", ".bmp", ".mp4", ".avi", ".jpeg", ".png", ".tif", ".tiff", ".raw" };

            getFiles = Directory.GetFiles(srcDir).Where(file => allowedExtensions.Any(file.ToLower().EndsWith)).ToList();

            totalFileCount = getFiles.Count();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (txtSrc.Text != "" && txtDest.Text != "")
            {
                int fileCount = 0;
                int progressPercent = 0;
                int copyCount = 0;

                MessageBox.Show("선택된 총 파일 수: " + totalFileCount.ToString());                

                foreach (var srcFile in getFiles)
                {
                    string justFileName = srcFile.Substring(srcFile.LastIndexOf("\\") + 1);
                    string createdDir = "";
                    string destFile = "";

                    DateTime modifyDate = File.GetLastWriteTime(srcFile);

                    if (!Directory.Exists(destDir + @"\" + modifyDate.ToString("yyyy월 MM월 dd일")))
                    {
                        createdDir = destDir + @"\" + Directory.CreateDirectory(destDir + @"\" + modifyDate.ToString("yyyy월 MM월 dd일")).ToString();
                        destFile = Path.Combine(createdDir, justFileName);
                    }
                    else
                    {
                        createdDir = destDir + @"\" + modifyDate.ToString("yyyy월 MM월 dd일").ToString();
                        destFile = Path.Combine(createdDir, justFileName);
                    }
                    if (!File.Exists(destFile))
                    {
                        File.Copy(srcFile, destFile);
                        copyCount = copyCount + 1;
                    }
                    progressPercent = ((++fileCount * 100) / totalFileCount);
                    bgWorker.ReportProgress(progressPercent);
                }
                
                MessageBox.Show(totalFileCount + "개의 파일 중 " + copyCount + "개의 파일을 복사하였습니다.");
            }
            else
            {
                MessageBox.Show("원본 및 대상 경로를 선택해 주세요!");
            }
            
        }

        void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            if (!bgWorker.IsBusy)
            {
                if (cbFolderStructure.SelectedIndex == 0)
                {
                    MessageBox.Show("폴더 생성 방식을 선택해 주세요");
                }
                else
                {
                    bgWorker.RunWorkerAsync();
                }
                    
            }
            else
            {
                MessageBox.Show("현재 작업중입니다.");
            }   
        }

        private void bgWworker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            // 에러가 있는지 체크
            if (e.Error != null)
            {
                //lblMsg.Text = e.Error.Message;
                MessageBox.Show(e.Error.Message, "Error");
                return;
            }
        }

        private void PhotoPhoto_Load(object sender, EventArgs e)
        {
            cbFolderStructure.Items.Add("---선택---");
            cbFolderStructure.Items.Add("yyyy년 MM월 dd일");
            cbFolderStructure.Items.Add("yyyy-MM-dd");
            cbFolderStructure.Items.Add("yyyy년\\MM월\\dd일");
            cbFolderStructure.Items.Add("yyyy\\MM\\dd");
            lblCbDescription.Text = "";
            lblSubFolderDescription.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bgWorker.CancelAsync();            
        }

        private void cbFolderStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFolderStructure.SelectedIndex)
            {
                case 0:
                    lblCbDescription.Text = "";
                    folderStructure = 0;
                    break;
                case 1:
                    lblCbDescription.Text = "대상 경로에 [예 - D:\\2000년 01월 01일]와 같이 단일폴더로 생성합니다.";
                    folderStructure = 1;
                    break;
                case 2:
                    lblCbDescription.Text = "대상 경로에 [예 - D:\\2000-01-01]와 같이 단일폴더로 생성합니다.";
                    folderStructure = 2;
                    break;
                case 3:
                    lblCbDescription.Text = "대상 경로에 [예 - D:\\2000년\\01월\\01월]와 같이 트리형태로 생성합니다.";
                    folderStructure = 3;
                    break;
                case 4:
                    lblCbDescription.Text = "대상 경로에 [예 - D:\\2000\\01\\01]와 같이 트리형태로 생성합니다.";
                    folderStructure = 4;
                    break;
            }
        }
    }
}
