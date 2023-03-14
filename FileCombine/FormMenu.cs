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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCleaner_Click(object sender, EventArgs e)
        {
            FormCleaner formCleaner = new FormCleaner();
            formCleaner.ShowDialog();
        }

        private void btnArchiver_Click(object sender, EventArgs e)
        {
            FormArchiver formArchiver = new FormArchiver();
            formArchiver.ShowDialog();
        }

        private void btnRenamer_Click(object sender, EventArgs e)
        {
            FormRenamer formRenamer = new FormRenamer();
            formRenamer.ShowDialog();
        }

        private void btnAnalyzer_Click(object sender, EventArgs e)
        {
            FormAnalyzer formAnalyzer = new FormAnalyzer();
            formAnalyzer.ShowDialog();
        }
    }
}
