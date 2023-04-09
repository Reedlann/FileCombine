using FileProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCombine
{
    public partial class FormCleaner : Form
    {
        private Finder finder;

        public FormCleaner()
        {
            InitializeComponent();

            finder = new Finder();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            RootDirBrowser.ShowDialog(this);
            txtbxRootDir.Text = RootDirBrowser.SelectedPath;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            long size = 0;

            lViewAnalyzedItem.Items.Clear();
            finder.Container.Dirs.Clear();
            finder.Container.Files.Clear();

            string rootPath = RootDirBrowser.SelectedPath;
            finder.DirMasks = txtbxDirPatterns.Text.Split("\r\n");
            finder.FileMasks = txtbxFilePatterns.Text.Split("\r\n");

            try
            {
                if (cbxDir.Checked && cbxFile.Checked)
                    finder.FindAll(rootPath);
                else if (cbxDir.Checked && !cbxFile.Checked)
                    finder.FindDirectoriesRecursive(rootPath);
                else if (!cbxDir.Checked && cbxFile.Checked)
                    finder.FindFilesRecursive(rootPath);
            }
            catch (Exception)
            {
                MessageBox.Show("Set Root Directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var d in finder.Container.Dirs)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems[0].Text = d.Name;
                item.Tag = new DirectoryInfo(d.FullName);
                item.SubItems.Add(d.LastWriteTime.ToString());
                item.ImageIndex = 0;

                lViewAnalyzedItem.Items.Add(item);
            }

            foreach (var f in finder.Container.Files)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems[0].Text = f.Name;
                item.Tag = new FileInfo(f.FullName);
                item.SubItems.Add(f.LastWriteTime.ToString());
                item.SubItems.Add((f.Length / 1024).ToString() + " Kb");
                item.ImageIndex = 1;

                lViewAnalyzedItem.Items.Add(item);
                size += f.Length;
            }

            lblCount.Text = $"Count: {lViewAnalyzedItem.Items.Count}";
            lblSize.Text = $"All size: {size / 1024} Kb";

            btnClear.Enabled = true;
            cbxRecycleBin.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lViewAnalyzedItem.CheckedItems)
            {
                Cleaner.Clean(item.Tag as FileSystemInfo, cbxRecycleBin.Checked);
                lViewAnalyzedItem.Items.Remove(item);
            }
        }
    }
}
