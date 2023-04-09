namespace FileCombine
{
    partial class FormArchiver
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
            this.txtbxDir = new System.Windows.Forms.TextBox();
            this.lblSetDir = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtbxFileTitle = new System.Windows.Forms.TextBox();
            this.cmbbxExtention = new System.Windows.Forms.ComboBox();
            this.txtbxDestination = new System.Windows.Forms.TextBox();
            this.lblSetDestination = new System.Windows.Forms.Label();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCompress = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtbxDir
            // 
            this.txtbxDir.Location = new System.Drawing.Point(14, 36);
            this.txtbxDir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtbxDir.Name = "txtbxDir";
            this.txtbxDir.Size = new System.Drawing.Size(268, 22);
            this.txtbxDir.TabIndex = 7;
            // 
            // lblSetDir
            // 
            this.lblSetDir.AutoSize = true;
            this.lblSetDir.Location = new System.Drawing.Point(14, 21);
            this.lblSetDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetDir.Name = "lblSetDir";
            this.lblSetDir.Size = new System.Drawing.Size(43, 14);
            this.lblSetDir.TabIndex = 9;
            this.lblSetDir.Text = "Set Dir";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Location = new System.Drawing.Point(288, 36);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(68, 21);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtbxFileTitle
            // 
            this.txtbxFileTitle.Location = new System.Drawing.Point(14, 170);
            this.txtbxFileTitle.Name = "txtbxFileTitle";
            this.txtbxFileTitle.Size = new System.Drawing.Size(133, 22);
            this.txtbxFileTitle.TabIndex = 10;
            // 
            // cmbbxExtention
            // 
            this.cmbbxExtention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxExtention.FormattingEnabled = true;
            this.cmbbxExtention.Items.AddRange(new object[] {
            ".zip"});
            this.cmbbxExtention.Location = new System.Drawing.Point(153, 170);
            this.cmbbxExtention.Name = "cmbbxExtention";
            this.cmbbxExtention.Size = new System.Drawing.Size(45, 22);
            this.cmbbxExtention.TabIndex = 20;
            // 
            // txtbxDestination
            // 
            this.txtbxDestination.Location = new System.Drawing.Point(14, 102);
            this.txtbxDestination.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtbxDestination.Name = "txtbxDestination";
            this.txtbxDestination.Size = new System.Drawing.Size(268, 22);
            this.txtbxDestination.TabIndex = 21;
            // 
            // lblSetDestination
            // 
            this.lblSetDestination.AutoSize = true;
            this.lblSetDestination.Location = new System.Drawing.Point(14, 86);
            this.lblSetDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetDestination.Name = "lblSetDestination";
            this.lblSetDestination.Size = new System.Drawing.Size(86, 14);
            this.lblSetDestination.TabIndex = 23;
            this.lblSetDestination.Text = "Set Destination";
            // 
            // btnBrowseDest
            // 
            this.btnBrowseDest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowseDest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseDest.Location = new System.Drawing.Point(288, 103);
            this.btnBrowseDest.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(68, 21);
            this.btnBrowseDest.TabIndex = 22;
            this.btnBrowseDest.Text = "Browse...";
            this.btnBrowseDest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseDest.UseVisualStyleBackColor = false;
            this.btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 153);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 14);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Title";
            // 
            // btnCompress
            // 
            this.btnCompress.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCompress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompress.Location = new System.Drawing.Point(12, 229);
            this.btnCompress.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(344, 33);
            this.btnCompress.TabIndex = 25;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = false;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // FormArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 281);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtbxDestination);
            this.Controls.Add(this.lblSetDestination);
            this.Controls.Add(this.btnBrowseDest);
            this.Controls.Add(this.cmbbxExtention);
            this.Controls.Add(this.txtbxFileTitle);
            this.Controls.Add(this.txtbxDir);
            this.Controls.Add(this.lblSetDir);
            this.Controls.Add(this.btnBrowse);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormArchiver";
            this.Text = "Archiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbxDir;
        private Label lblSetDir;
        private Button btnBrowse;
        private TextBox txtbxFileTitle;
        private ComboBox cmbbxExtention;
        private TextBox txtbxDestination;
        private Label lblSetDestination;
        private Button btnBrowseDest;
        private Label lblTitle;
        private Button btnCompress;
        private FolderBrowserDialog folderBrowser;
    }
}