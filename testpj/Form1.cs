using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace testpj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPP.Text = Properties.Settings.Default.Python_Path;
            txtIP.Text = Properties.Settings.Default.Input_Path;
            txtOP.Text = Properties.Settings.Default.Output_Path;
        }

        private void btnPP_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Browse For Folder";
            OFD.Filter = "All file | *.*";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                txtPP.Text = OFD.FileName;
            }

            Properties.Settings.Default.Python_Path = txtPP.Text;
            Properties.Settings.Default.Save();
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtIP.Text = folderBrowserDialog.SelectedPath;
            }
            
            Properties.Settings.Default.Input_Path = txtIP.Text;
            Properties.Settings.Default.Save();
        }

        private void btnOP_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtOP.Text = folderBrowserDialog.SelectedPath;
            }

            Properties.Settings.Default.Output_Path = txtOP.Text;
            Properties.Settings.Default.Save();
        }

        private bool ValidationCheck()
        {
            if (string.IsNullOrWhiteSpace(txtPP.Text))
            {
                MessageBox.Show("Please enter the Python Path.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIP.Text))
            {
                MessageBox.Show("Please enter the Input Path.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOP.Text))
            {
                MessageBox.Show("Please enter the Output Path.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnEnabaleSet(bool Chk)
        {
            btnPP.Enabled = Chk;
            btnOP.Enabled = Chk;
            btnIP.Enabled = Chk;
            button1.Enabled = Chk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidationCheck() == false)
            {
                return;
            }

            btnEnabaleSet(false);

            // Python 스크립트 파일 경로
            string pythonFilePath = txtPP.Text;
            
            // 전달할 인자
            int index = pythonFilePath.LastIndexOf(@"\");  // 특정 문자의 마지막 위치

            string path = pythonFilePath.Substring(0, index); // @"D:/Dev/Mexico/test/";

            string inputPath = txtIP.Text;
            string outputPath = txtOP.Text;

            // ProcessStartInfo를 사용하여 Python 스크립트 실행
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python", // Python 실행 파일 경로
                Arguments = $"{pythonFilePath} \"{path}\" \"{inputPath}\" \"{outputPath}\"",// \"{outputPath}\"", // 스크립트와 인자
                RedirectStandardOutput = true, // 표준 출력 리디렉션
                RedirectStandardError = true,  // 표준 에러 리디렉션 추가
                UseShellExecute = false, // 쉘 사용 여부
                CreateNoWindow = true // 새 창 생성 여부
                //Verb = "runas"
            };

            try
            {
                using (Process process = Process.Start(psi))
                {
                    // Python 표준 출력 및 오류 읽기
                    string result = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit(); // Python 스크립트 종료 대기

                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show($"Error: {error}", "Python Error");
                    }
                    else
                    {
                        MessageBox.Show(result, "Python Output");
                        System.Diagnostics.Process.Start(txtOP.Text);
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            finally
            {
                btnEnabaleSet(true);
            }
        }

    }
}
