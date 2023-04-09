namespace FileCombine
{
    partial class FormMenu
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
            this.btnAnalyzer = new System.Windows.Forms.Button();
            this.btnRenamer = new System.Windows.Forms.Button();
            this.btnArchiver = new System.Windows.Forms.Button();
            this.btnCleaner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnalyzer
            // 
            this.btnAnalyzer.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnalyzer.Location = new System.Drawing.Point(297, 282);
            this.btnAnalyzer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyzer.Name = "btnAnalyzer";
            this.btnAnalyzer.Size = new System.Drawing.Size(206, 44);
            this.btnAnalyzer.TabIndex = 7;
            this.btnAnalyzer.Text = "ANALYZER";
            this.btnAnalyzer.UseVisualStyleBackColor = false;
            this.btnAnalyzer.Click += new System.EventHandler(this.btnAnalyzer_Click);
            // 
            // btnRenamer
            // 
            this.btnRenamer.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnRenamer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenamer.Location = new System.Drawing.Point(297, 220);
            this.btnRenamer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenamer.Name = "btnRenamer";
            this.btnRenamer.Size = new System.Drawing.Size(206, 44);
            this.btnRenamer.TabIndex = 6;
            this.btnRenamer.Text = "RENAMER";
            this.btnRenamer.UseVisualStyleBackColor = false;
            this.btnRenamer.Click += new System.EventHandler(this.btnRenamer_Click);
            // 
            // btnArchiver
            // 
            this.btnArchiver.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnArchiver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArchiver.Location = new System.Drawing.Point(297, 160);
            this.btnArchiver.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiver.Name = "btnArchiver";
            this.btnArchiver.Size = new System.Drawing.Size(206, 44);
            this.btnArchiver.TabIndex = 5;
            this.btnArchiver.Text = "ARCHIVER";
            this.btnArchiver.UseVisualStyleBackColor = false;
            this.btnArchiver.Click += new System.EventHandler(this.btnArchiver_Click);
            // 
            // btnCleaner
            // 
            this.btnCleaner.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCleaner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCleaner.Location = new System.Drawing.Point(297, 95);
            this.btnCleaner.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleaner.Name = "btnCleaner";
            this.btnCleaner.Size = new System.Drawing.Size(206, 44);
            this.btnCleaner.TabIndex = 4;
            this.btnCleaner.Text = "CLEANER";
            this.btnCleaner.UseVisualStyleBackColor = false;
            this.btnCleaner.Click += new System.EventHandler(this.btnCleaner_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.btnAnalyzer);
            this.Controls.Add(this.btnRenamer);
            this.Controls.Add(this.btnArchiver);
            this.Controls.Add(this.btnCleaner);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormMenu";
            this.Text = "File Combine";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAnalyzer;
        private Button btnRenamer;
        private Button btnArchiver;
        private Button btnCleaner;
    }
}