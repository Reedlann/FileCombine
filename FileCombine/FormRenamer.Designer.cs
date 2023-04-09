namespace FileCombine
{
    partial class FormRenamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRenamer));
            this.lViewAnalyzedFiles = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.colSize = new System.Windows.Forms.ColumnHeader();
            this.imgListIcon = new System.Windows.Forms.ImageList(this.components);
            this.txtbxDir = new System.Windows.Forms.TextBox();
            this.lblSetDir = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSetFilePatterns = new System.Windows.Forms.Label();
            this.txtbxFilePatterns = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.DirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSetRenamePattern = new System.Windows.Forms.Label();
            this.combBxPrefix = new System.Windows.Forms.ComboBox();
            this.combBxConnector = new System.Windows.Forms.ComboBox();
            this.combBxGPart = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lViewAnalyzedFiles
            // 
            this.lViewAnalyzedFiles.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lViewAnalyzedFiles.BackColor = System.Drawing.SystemColors.Window;
            this.lViewAnalyzedFiles.CheckBoxes = true;
            this.lViewAnalyzedFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDate,
            this.colSize});
            this.lViewAnalyzedFiles.Location = new System.Drawing.Point(14, 9);
            this.lViewAnalyzedFiles.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lViewAnalyzedFiles.Name = "lViewAnalyzedFiles";
            this.lViewAnalyzedFiles.Size = new System.Drawing.Size(523, 399);
            this.lViewAnalyzedFiles.SmallImageList = this.imgListIcon;
            this.lViewAnalyzedFiles.TabIndex = 1;
            this.lViewAnalyzedFiles.TileSize = new System.Drawing.Size(210, 32);
            this.lViewAnalyzedFiles.UseCompatibleStateImageBehavior = false;
            this.lViewAnalyzedFiles.View = System.Windows.Forms.View.Details;
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
            this.imgListIcon.Images.SetKeyName(0, "загружено.png");
            // 
            // txtbxDir
            // 
            this.txtbxDir.Location = new System.Drawing.Point(544, 24);
            this.txtbxDir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtbxDir.Name = "txtbxDir";
            this.txtbxDir.Size = new System.Drawing.Size(268, 22);
            this.txtbxDir.TabIndex = 6;
            // 
            // lblSetDir
            // 
            this.lblSetDir.AutoSize = true;
            this.lblSetDir.Location = new System.Drawing.Point(544, 8);
            this.lblSetDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetDir.Name = "lblSetDir";
            this.lblSetDir.Size = new System.Drawing.Size(76, 14);
            this.lblSetDir.TabIndex = 8;
            this.lblSetDir.Text = "Set Directory";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Location = new System.Drawing.Point(818, 24);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(68, 21);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSetFilePatterns
            // 
            this.lblSetFilePatterns.AutoSize = true;
            this.lblSetFilePatterns.Location = new System.Drawing.Point(544, 67);
            this.lblSetFilePatterns.Name = "lblSetFilePatterns";
            this.lblSetFilePatterns.Size = new System.Drawing.Size(180, 14);
            this.lblSetFilePatterns.TabIndex = 13;
            this.lblSetFilePatterns.Text = "Set File Patterns (not necessarily)";
            // 
            // txtbxFilePatterns
            // 
            this.txtbxFilePatterns.Location = new System.Drawing.Point(544, 83);
            this.txtbxFilePatterns.Multiline = true;
            this.txtbxFilePatterns.Name = "txtbxFilePatterns";
            this.txtbxFilePatterns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxFilePatterns.Size = new System.Drawing.Size(268, 59);
            this.txtbxFilePatterns.TabIndex = 12;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnalyze.Location = new System.Drawing.Point(544, 168);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(342, 35);
            this.btnAnalyze.TabIndex = 14;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnRename
            // 
            this.btnRename.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnRename.Enabled = false;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRename.Location = new System.Drawing.Point(545, 373);
            this.btnRename.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(342, 35);
            this.btnRename.TabIndex = 16;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // DirBrowser
            // 
            this.DirBrowser.OkRequiresInteraction = true;
            this.DirBrowser.ShowHiddenFiles = true;
            this.DirBrowser.ShowNewFolderButton = false;
            // 
            // lblSetRenamePattern
            // 
            this.lblSetRenamePattern.AutoSize = true;
            this.lblSetRenamePattern.Location = new System.Drawing.Point(545, 277);
            this.lblSetRenamePattern.Name = "lblSetRenamePattern";
            this.lblSetRenamePattern.Size = new System.Drawing.Size(111, 14);
            this.lblSetRenamePattern.TabIndex = 17;
            this.lblSetRenamePattern.Text = "Set Rename Pattern";
            // 
            // combBxPrefix
            // 
            this.combBxPrefix.FormattingEnabled = true;
            this.combBxPrefix.Items.AddRange(new object[] {
            "img",
            "video",
            "txt",
            "movie",
            "file",
            "data"});
            this.combBxPrefix.Location = new System.Drawing.Point(545, 294);
            this.combBxPrefix.Name = "combBxPrefix";
            this.combBxPrefix.Size = new System.Drawing.Size(144, 22);
            this.combBxPrefix.TabIndex = 18;
            // 
            // combBxConnector
            // 
            this.combBxConnector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBxConnector.FormattingEnabled = true;
            this.combBxConnector.Items.AddRange(new object[] {
            "_",
            ".",
            " ",
            "-",
            ","});
            this.combBxConnector.Location = new System.Drawing.Point(695, 294);
            this.combBxConnector.Name = "combBxConnector";
            this.combBxConnector.Size = new System.Drawing.Size(45, 22);
            this.combBxConnector.TabIndex = 19;
            // 
            // combBxGPart
            // 
            this.combBxGPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBxGPart.FormattingEnabled = true;
            this.combBxGPart.Items.AddRange(new object[] {
            "UUID",
            "Ordinal number",
            "Random string"});
            this.combBxGPart.Location = new System.Drawing.Point(746, 294);
            this.combBxGPart.Name = "combBxGPart";
            this.combBxGPart.Size = new System.Drawing.Size(140, 22);
            this.combBxGPart.TabIndex = 20;
            // 
            // FormRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 419);
            this.Controls.Add(this.combBxGPart);
            this.Controls.Add(this.combBxConnector);
            this.Controls.Add(this.combBxPrefix);
            this.Controls.Add(this.lblSetRenamePattern);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.lblSetFilePatterns);
            this.Controls.Add(this.txtbxFilePatterns);
            this.Controls.Add(this.txtbxDir);
            this.Controls.Add(this.lblSetDir);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lViewAnalyzedFiles);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormRenamer";
            this.Text = "Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lViewAnalyzedFiles;
        private ColumnHeader colName;
        private ColumnHeader colDate;
        private ColumnHeader colSize;
        private TextBox txtbxDir;
        private Label lblSetDir;
        private Button btnBrowse;
        private Label lblSetFilePatterns;
        private TextBox txtbxFilePatterns;
        private Button btnAnalyze;
        private Button btnRename;
        private FolderBrowserDialog DirBrowser;
        private ImageList imgListIcon;
        private Label lblSetRenamePattern;
        private ComboBox combBxPrefix;
        private ComboBox combBxConnector;
        private ComboBox combBxGPart;
    }
}