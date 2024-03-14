using DarkestSave.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkestSave
{
    public partial class MainForm : Form
    {
        Config config = new Config();
        string configFilePath = @"Configs/Config.txt";
        DataGridViewRow setectedRow;
        string oldFileName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(File.Exists(configFilePath) )
            {
                config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(configFilePath));
            }
            if(config != null && !string.IsNullOrEmpty(config.SavePath))
            {
                this.txtSavePath.Text = config.SavePath;
                LoadSave();
            }
        }

        private void btnSelectSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtSavePath.Text = ofd.SelectedPath;
                if(config == null)
                {
                    config = new Config();
                }
                this.config.SavePath = ofd.SelectedPath;
                File.WriteAllText(configFilePath, JsonConvert.SerializeObject(config));
                LoadSave();
            }
        }

        private void LoadSave()
        {
            this.cbSaveLocation.SelectedIndex = 0;
            RefreshSaveLocation();
        }

        private void cbSaveLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.dataGridSaveFile.DataSource = null;
            //RefreshSaveLocation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int loca = this.cbSaveLocation.SelectedIndex + 1;
            var path = Path.Combine(config.SavePath, "Save");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string direPath = Path.Combine(config.SavePath, $"profile_{this.cbSaveLocation.SelectedIndex}");
            string zipFile = Path.Combine(path, $"{loca}_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.zip");
            ZipFile.CreateFromDirectory(direPath, zipFile);
            RefreshSaveLocation();
        }

        private void RefreshSaveLocation()
        {
            int loca = this.cbSaveLocation.SelectedIndex + 1;
            var path = Path.Combine(config.SavePath, "Save");
            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path);
                var zipFiles = files.Where(f => f.EndsWith(".zip")).ToList();
                List<ZipFileModel> zipModels = new List<ZipFileModel>();
                foreach (var zipFile in zipFiles)
                {
                    FileInfo file = new FileInfo(zipFile);
                    ZipFileModel zipModel = new ZipFileModel(Path.GetFileNameWithoutExtension(file.Name),
                        file.FullName,file.CreationTime);
                    zipModels.Add(zipModel);
                }
                zipModels.Sort((z, a) =>
                {
                    return (int)(a.CreateTime.Ticks/1000 - z.CreateTime.Ticks/1000);
                });
                this.dataGridSaveFile.DataSource = zipModels;
            }
        }

        private void dataGridSaveFile_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dataGridSaveFile.ClearSelection();
                    dataGridSaveFile.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void reName_Click(object sender, EventArgs e)
        {
            var cell = dataGridSaveFile.SelectedRows[0].Cells["FileName"];
            cell.ReadOnly = false;
        }

        private void readSave_Click(object sender, EventArgs e)
        {
            var model = dataGridSaveFile.SelectedRows[0].DataBoundItem as ZipFileModel;
            if (MessageBox.Show($"确定要读取存档{model.FileName}到存档位{cbSaveLocation.Text}吗？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                UncompressZip(model.FilePath, Path.Combine(config.SavePath, $"profile_{this.cbSaveLocation.SelectedIndex}"));
                MessageBox.Show("已完成");
            }
        }

        private void deleteSave_Click(object sender, EventArgs e)
        {
            var model = dataGridSaveFile.SelectedRows[0].DataBoundItem as ZipFileModel;
            if (MessageBox.Show($"确定要删除{model.FileName}吗？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                File.Delete(model.FilePath);
                RefreshSaveLocation();
            }
        }

        private void dataGridSaveFile_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var fileModel = dataGridSaveFile.Rows[e.RowIndex].DataBoundItem as ZipFileModel;
            oldFileName = fileModel.FileName;
        }

        private void dataGridSaveFile_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var fileModel = dataGridSaveFile.Rows[e.RowIndex].DataBoundItem as ZipFileModel;
            if(!string.IsNullOrEmpty(oldFileName) && oldFileName != fileModel.FileName)
            {
                var files = Directory.GetFiles(Path.GetDirectoryName(fileModel.FilePath));
                var fileNames = files.Select(f => Path.GetFileNameWithoutExtension(f)).ToList();
                string fileName = fileModel.FileName;
                if (fileNames.Any(f => f == fileModel.FileName))
                {
                    MessageBox.Show("文件名已存在");
                    fileModel.FileName = oldFileName;
                }
                else
                {
                    string newFilePath = Path.Combine(Path.GetDirectoryName(fileModel.FilePath), fileModel.FileName + ".zip");
                    File.Move(fileModel.FilePath, newFilePath);
                    fileModel.FilePath = newFilePath;
                }
            }
            dataGridSaveFile.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
            oldFileName = null;
        }

        private void UncompressZip(string zipFile, string outPath)
        {
            using (FileStream fs = new FileStream(zipFile, FileMode.Open))
            {
                using (ZipArchive zr = new ZipArchive(fs))
                {
                    foreach (var en in zr.Entries)
                    {
                        FileInfo path = new FileInfo(Path.Combine(outPath, en.FullName));
                        if (!path.Directory.Exists)
                        {
                            path.Directory.Create();
                        }
                        if (en.Name == "")
                        {
                            Directory.CreateDirectory(path.FullName);
                        }
                        else
                        {
                            en.ExtractToFile(path.FullName, true);
                        }
                    }
                }
            }
        }
    }

    class ZipFileModel
    {
        public ZipFileModel(string name, string path, DateTime dateTime)
        {
            this.FileName = name;
            this.FilePath = path;
            this.CreateTime = dateTime;
        }

        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
