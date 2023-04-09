using FileProcessor.Archive;
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
    public partial class FormArchiver : Form
    {
        private ArchiveEngine archiveEngine;

        public FormArchiver()
        {
            InitializeComponent();
            archiveEngine = new ArchiveEngine();
            cmbbxExtention.SelectedIndex = 0;
        }

        private string GetRootDirPath(string path)
        {
            int startIndex = 0;

            startIndex = path.LastIndexOf("\\");

            string newPath = path.Remove(startIndex);

            return newPath;
        } 

        private string GetDirTitle(string path)
        {
            int startIndex = 0;

            startIndex = path.LastIndexOf("\\") + 1;

            return path.Substring(startIndex);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            txtbxDir.Text = folderBrowser.SelectedPath;
            txtbxDestination.Text = GetRootDirPath(folderBrowser.SelectedPath);
            txtbxFileTitle.Text = GetDirTitle(folderBrowser.SelectedPath);
        }

        private void btnBrowseDest_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            txtbxDestination.Text = folderBrowser.SelectedPath;
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            string destination = $"{txtbxDestination.Text}\\{txtbxFileTitle.Text}{cmbbxExtention.Text}";

            try
            {
                archiveEngine.CompressDirectory(txtbxDir.Text, destination);

                MessageBox.Show("The archive was successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
