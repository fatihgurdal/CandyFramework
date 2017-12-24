using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyFramework.Setup
{
    public partial class MainForm : MetroForm
    {
        private static int sleep = 200;
        private static int total = 0;
        public MainForm()
        {
            InitializeComponent();
            this.Icon = Setup.Properties.Resources.Candy1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var folders = Directory.GetDirectories(path);
            var top = 0;
            foreach (var item in folders)
            {
                var dic = Path.GetFileName(item);
                if (dic.StartsWith("Visual Studio"))
                {
                    var checkBox = new MetroCheckBox();
                    checkBox.Text = dic;
                    checkBox.Top = top;
                    top += 23;
                    checkBox.Size = new Size(200, 15);
                    pnl_Vs.Controls.Add(checkBox);
                }
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            pb_Install.Value = 0;
            var baseFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            List<string> visualStudioPaths = new List<string>();
            foreach (var control in pnl_Vs.Controls)
            {
                if (control is MetroCheckBox)
                {
                    var checkBox = (MetroCheckBox)control;
                    if (checkBox.Checked)
                    {
                        visualStudioPaths.Add(Path.Combine(baseFolder, checkBox.Text));
                    }
                }
            }
            var source = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CopyFolder");
            if (Directory.Exists(source))
            {
                lblStatus.Text = "Yükleme Başlıyor...";
                StartInstall(visualStudioPaths, source);
                
            }
            else
            {
                MetroMessageBox.Show(this, "CopyFolder klasörü bulunamadığından yükleme başarısız", "Yükeleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void StartInstall(List<string> visualStudioPaths, string source)
        {

            IProgress<InstallModel> progress = new Progress<InstallModel>(value =>
            {

                pb_Install.Value = value.BarSize;
                if (string.IsNullOrEmpty(value.LabelText) == false)
                {
                    lblStatus.Text = value.LabelText;
                }
            });
            int docCount = Directory.GetFiles(source, "*", SearchOption.AllDirectories).Length;
            int folCount = Directory.GetDirectories(source, "*", SearchOption.AllDirectories).Length;

            total = docCount + folCount;
            pb_Install.Maximum = total;
            sleep = 3000 / total;
            await Task.Run(() =>
            {
                var reportModel = new InstallModel();

                foreach (var target in visualStudioPaths)
                {
                    int pValue = 0;
                    reportModel.BarSize = pValue;
                    reportModel.LabelText = Path.GetFileName(target) + " Yükleniyor...";                    
                    progress.Report(reportModel);
                    CreateFolderOrCopyFile(target, source, progress, ref pValue);
                }
                reportModel.BarSize = pb_Install.Maximum;
                reportModel.LabelText ="Bitti.";

                progress.Report(reportModel);
            });

        }
        private void CreateFolderOrCopyFile(string target, string source, IProgress<InstallModel> progress, ref int pValue)
        {
            var reportModel = new InstallModel();
            foreach (var item in Directory.GetFiles(source))
            {
                pValue += 1;
                reportModel.BarSize = pValue;
                progress.Report(reportModel);
                var targetFullName = Path.Combine(target, Path.GetFileName(item));
                File.Copy(item, targetFullName, true);
                Thread.Sleep(sleep);
            }
            foreach (var item in Directory.GetDirectories(source))
            {
                pValue += 1;
                reportModel.BarSize = pValue;
                progress.Report(reportModel);

                var existingFolder = Path.Combine(target, Path.GetFileName(item));
                if (Directory.Exists(existingFolder) == false)
                {
                    Directory.CreateDirectory(existingFolder);
                }
                var newSource = Path.Combine(source, item);
                Thread.Sleep(sleep);

                CreateFolderOrCopyFile(existingFolder, newSource, progress, ref pValue);
            }
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fatihgurdal/CandyFramework");
        }
    }
}
