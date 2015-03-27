namespace PluralSightDownloader.WinForms
{
    partial class AboutForm
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
            this._projectLabel = new System.Windows.Forms.Label();
            this._assemblyInfoLabel = new System.Windows.Forms.Label();
            this._referencedAssembliesTextBox = new System.Windows.Forms.TextBox();
            this._closeButton = new System.Windows.Forms.Button();
            this._licenseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _projectLabel
            // 
            this._projectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._projectLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._projectLabel.Location = new System.Drawing.Point(12, 9);
            this._projectLabel.Name = "_projectLabel";
            this._projectLabel.Size = new System.Drawing.Size(560, 23);
            this._projectLabel.TabIndex = 0;
            this._projectLabel.Text = "ProjectLabel";
            this._projectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _assemblyInfoLabel
            // 
            this._assemblyInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._assemblyInfoLabel.Location = new System.Drawing.Point(12, 32);
            this._assemblyInfoLabel.Name = "_assemblyInfoLabel";
            this._assemblyInfoLabel.Size = new System.Drawing.Size(560, 60);
            this._assemblyInfoLabel.TabIndex = 1;
            this._assemblyInfoLabel.Text = "AssemblyInfo";
            this._assemblyInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _referencedAssembliesTextBox
            // 
            this._referencedAssembliesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._referencedAssembliesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this._referencedAssembliesTextBox.Location = new System.Drawing.Point(16, 95);
            this._referencedAssembliesTextBox.Multiline = true;
            this._referencedAssembliesTextBox.Name = "_referencedAssembliesTextBox";
            this._referencedAssembliesTextBox.ReadOnly = true;
            this._referencedAssembliesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._referencedAssembliesTextBox.Size = new System.Drawing.Size(556, 163);
            this._referencedAssembliesTextBox.TabIndex = 2;
            // 
            // _closeButton
            // 
            this._closeButton.Location = new System.Drawing.Point(497, 264);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(75, 23);
            this._closeButton.TabIndex = 1;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // _licenseButton
            // 
            this._licenseButton.Location = new System.Drawing.Point(15, 264);
            this._licenseButton.Name = "_licenseButton";
            this._licenseButton.Size = new System.Drawing.Size(75, 23);
            this._licenseButton.TabIndex = 3;
            this._licenseButton.Text = "License";
            this._licenseButton.UseVisualStyleBackColor = true;
            this._licenseButton.Click += new System.EventHandler(this._licenseButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 299);
            this.Controls.Add(this._licenseButton);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._referencedAssembliesTextBox);
            this.Controls.Add(this._assemblyInfoLabel);
            this.Controls.Add(this._projectLabel);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _projectLabel;
        private System.Windows.Forms.Label _assemblyInfoLabel;
        private System.Windows.Forms.TextBox _referencedAssembliesTextBox;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.Button _licenseButton;
    }
}