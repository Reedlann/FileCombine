namespace FileCombine
{
    partial class FormCleaner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCleaner));
            this.lViewAnalyzedItem = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.colSize = new System.Windows.Forms.ColumnHeader();
            this.imgListIcon = new System.Windows.Forms.ImageList(this.components);
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.cbxRecycleBin = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtbxRootDir = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSetRootDir = new System.Windows.Forms.Label();
            this.txtbxDirPatterns = new System.Windows.Forms.TextBox();
            this.txtbxFilePatterns = new System.Windows.Forms.TextBox();
            this.lblSetDirPatterns = new System.Windows.Forms.Label();
            this.lblSetFilePatterns = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.RootDirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxDir = new System.Windows.Forms.CheckBox();
            this.cbxFile = new System.Windows.Forms.CheckBox();
            this.lblAnalyze = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lViewAnalyzedItem
            // 
            this.lViewAnalyzedItem.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lViewAnalyzedItem.BackColor = System.Drawing.SystemColors.Window;
            this.lViewAnalyzedItem.CheckBoxes = true;
            this.lViewAnalyzedItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDate,
            this.colSize});
            this.lViewAnalyzedItem.Location = new System.Drawing.Point(12, 11);
            this.lViewAnalyzedItem.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lViewAnalyzedItem.Name = "lViewAnalyzedItem";
            this.lViewAnalyzedItem.Size = new System.Drawing.Size(523, 427);
            this.lViewAnalyzedItem.SmallImageList = this.imgListIcon;
            this.lViewAnalyzedItem.TabIndex = 0;
            this.lViewAnalyzedItem.TileSize = new System.Drawing.Size(210, 32);
            this.lViewAnalyzedItem.UseCompatibleStateImageBehavior = false;
            this.lViewAnalyzedItem.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 280;
            // 
            // colDate
            // 
            this.colDate.Text = "Date of change";
            this.colDate.Width = 120;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 120;
            // 
            // imgListIcon
            // 
            this.imgListIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIcon.ImageStream")));
            this.imgListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIcon.Images.SetKeyName(0, "kisspng-directory-computer-icons-clip-art-folders-5abf1ab69e2588.4481766415224736" +
        "546478.jpg");
            this.imgListIcon.Images.SetKeyName(1, "загружено.png");
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnalyze.Location = new System.Drawing.Point(551, 311);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(342, 37);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // cbxRecycleBin
            // 
            this.cbxRecycleBin.AutoSize = true;
            this.cbxRecycleBin.Checked = true;
            this.cbxRecycleBin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRecycleBin.Enabled = false;
            this.cbxRecycleBin.Location = new System.Drawing.Point(551, 377);
            this.cbxRecycleBin.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbxRecycleBin.Name = "cbxRecycleBin";
            this.cbxRecycleBin.Size = new System.Drawing.Size(132, 18);
            this.cbxRecycleBin.TabIndex = 2;
            this.cbxRecycleBin.Text = "Move to Recycle Bin";
            this.cbxRecycleBin.UseVisualStyleBackColor = true;
            // 
            // txtbxRootDir
            // 
            this.txtbxRootDir.Location = new System.Drawing.Point(551, 34);
            this.txtbxRootDir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtbxRootDir.Name = "txtbxRootDir";
            this.txtbxRootDir.Size = new System.Drawing.Size(268, 22);
            this.txtbxRootDir.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Location = new System.Drawing.Point(825, 34);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(68, 22);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSetRootDir
            // 
            this.lblSetRootDir.AutoSize = true;
            this.lblSetRootDir.Location = new System.Drawing.Point(551, 17);
            this.lblSetRootDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetRootDir.Name = "lblSetRootDir";
            this.lblSetRootDir.Size = new System.Drawing.Size(70, 14);
            this.lblSetRootDir.TabIndex = 5;
            this.lblSetRootDir.Text = "Set Root Dir";
            // 
            // txtbxDirPatterns
            // 
            this.txtbxDirPatterns.Location = new System.Drawing.Point(551, 80);
            this.txtbxDirPatterns.Multiline = true;
            this.txtbxDirPatterns.Name = "txtbxDirPatterns";
            this.txtbxDirPatterns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxDirPatterns.Size = new System.Drawing.Size(268, 63);
            this.txtbxDirPatterns.TabIndex = 6;
            // 
            // txtbxFilePatterns
            // 
            this.txtbxFilePatterns.Location = new System.Drawing.Point(551, 168);
            this.txtbxFilePatterns.Multiline = true;
            this.txtbxFilePatterns.Name = "txtbxFilePatterns";
            this.txtbxFilePatterns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxFilePatterns.Size = new System.Drawing.Size(268, 63);
            this.txtbxFilePatterns.TabIndex = 7;
            // 
            // lblSetDirPatterns
            // 
            this.lblSetDirPatterns.AutoSize = true;
            this.lblSetDirPatterns.Location = new System.Drawing.Point(551, 63);
            this.lblSetDirPatterns.Name = "lblSetDirPatterns";
            this.lblSetDirPatterns.Size = new System.Drawing.Size(123, 14);
            this.lblSetDirPatterns.TabIndex = 10;
            this.lblSetDirPatterns.Text = "Set Directory Patterns";
            // 
            // lblSetFilePatterns
            // 
            this.lblSetFilePatterns.AutoSize = true;
            this.lblSetFilePatterns.Location = new System.Drawing.Point(551, 151);
            this.lblSetFilePatterns.Name = "lblSetFilePatterns";
            this.lblSetFilePatterns.Size = new System.Drawing.Size(91, 14);
            this.lblSetFilePatterns.TabIndex = 11;
            this.lblSetFilePatterns.Text = "Set File Patterns";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(551, 243);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 14);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "Count: ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(551, 265);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 14);
            this.lblSize.TabIndex = 13;
            this.lblSize.Text = "Full size: ";
            // 
            // RootDirBrowser
            // 
            this.RootDirBrowser.OkRequiresInteraction = true;
            this.RootDirBrowser.RootFolder = System.Environment.SpecialFolder.CommonDocuments;
            this.RootDirBrowser.ShowHiddenFiles = true;
            this.RootDirBrowser.ShowNewFolderButton = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnClear.Enabled = false;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(551, 401);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(342, 37);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxDir
            // 
            this.cbxDir.AutoSize = true;
            this.cbxDir.Checked = true;
            this.cbxDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDir.Location = new System.Drawing.Point(603, 289);
            this.cbxDir.Name = "cbxDir";
            this.cbxDir.Size = new System.Drawing.Size(76, 18);
            this.cbxDir.TabIndex = 16;
            this.cbxDir.Text = "Directory";
            this.cbxDir.UseVisualStyleBackColor = true;
            // 
            // cbxFile
            // 
            this.cbxFile.AutoSize = true;
            this.cbxFile.Checked = true;
            this.cbxFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFile.Location = new System.Drawing.Point(676, 289);
            this.cbxFile.Name = "cbxFile";
            this.cbxFile.Size = new System.Drawing.Size(44, 18);
            this.cbxFile.TabIndex = 17;
            this.cbxFile.Text = "File";
            this.cbxFile.UseVisualStyleBackColor = true;
            // 
            // lblAnalyze
            // 
            this.lblAnalyze.AutoSize = true;
            this.lblAnalyze.Location = new System.Drawing.Point(551, 290);
            this.lblAnalyze.Name = "lblAnalyze";
            this.lblAnalyze.Size = new System.Drawing.Size(52, 14);
            this.lblAnalyze.TabIndex = 18;
            this.lblAnalyze.Text = "Analyze:";
            // 
            // FormCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 449);
            this.Controls.Add(this.lblAnalyze);
            this.Controls.Add(this.cbxFile);
            this.Controls.Add(this.cbxDir);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblSetFilePatterns);
            this.Controls.Add(this.lblSetDirPatterns);
            this.Controls.Add(this.txtbxFilePatterns);
            this.Controls.Add(this.txtbxDirPatterns);
            this.Controls.Add(this.txtbxRootDir);
            this.Controls.Add(this.lblSetRootDir);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cbxRecycleBin);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.lViewAnalyzedItem);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FormCleaner";
            this.Text = "File Cleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lViewAnalyzedItem;
        private Button btnAnalyze;
        private CheckBox cbxRecycleBin;
        private OpenFileDialog openFileDialog;
        private TextBox txtbxRootDir;
        private Button btnBrowse;
        private Label lblSetRootDir;
        private TextBox txtbxDirPatterns;
        private TextBox txtbxFilePatterns;
        private Label lblSetDirPatterns;
        private Label lblSetFilePatterns;
        private Label lblCount;
        private Label lblSize;
        private FolderBrowserDialog RootDirBrowser;
        private Button btnClear;
        private CheckBox cbxDir;
        private CheckBox cbxFile;
        private Label lblAnalyze;
        private ColumnHeader colName;
        private ColumnHeader colDate;
        private ColumnHeader colSize;
        private ImageList imgListIcon;
    }
}