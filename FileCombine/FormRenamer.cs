using FileProcessor;
using FileProcessor.Renamer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCombine
{
    public partial class FormRenamer : Form
    {
        private Finder finder;
        private Renamer renamer;

        public FormRenamer()
        {
            InitializeComponent();

            finder = new Finder();
            renamer = new Renamer();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DirBrowser.ShowDialog(this);
            txtbxDir.Text = DirBrowser.SelectedPath;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            lViewAnalyzedFiles.Items.Clear();
            finder.Container.Files.Clear();

            string rootPath = DirBrowser.SelectedPath;
            finder.FileMasks = txtbxFilePatterns.Text.Split("\r\n");

            try
            {
                finder.FindFiles(rootPath);
            }
            catch (Exception)
            {
                MessageBox.Show("Set Directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var f in finder.Container.Files)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems[0].Text = f.Name;
                item.Tag = new FileInfo(f.FullName);
                item.SubItems.Add(f.LastWriteTime.ToString());
                item.SubItems.Add((f.Length / 1024).ToString() + " Kb");
                item.Checked = true;
                item.ImageIndex = 0;

                lViewAnalyzedFiles.Items.Add(item);
            }

            btnRename.Enabled = true;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lViewAnalyzedFiles.CheckedItems)
            {
                renamer.Files.Add((FileInfo)item.Tag);
            }

            renamer.SetMode(combBxGPart.SelectedItem switch
            {
                "UUID" => RenamerMode.UUID,
                "Ordinal number" => RenamerMode.AUTOINCREMENT,
                "Random string" => RenamerMode.RANDOM_STRING,
                _ => RenamerMode.AUTOINCREMENT,
            });

            string prefix = $"{combBxPrefix.Text}{combBxConnector.Text}";

            Report report = renamer.Rename(prefix);

            btnAnalyze_Click(sender, e);
        }
    }
}
