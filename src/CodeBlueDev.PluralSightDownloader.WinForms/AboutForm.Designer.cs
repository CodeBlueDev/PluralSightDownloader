namespace CodeBlueDev.PluralSightDownloader.WinForms
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this._licenseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _licenseButton
            // 
            this._licenseButton.Location = new System.Drawing.Point(12, 277);
            this._licenseButton.Name = "_licenseButton";
            this._licenseButton.Size = new System.Drawing.Size(75, 23);
            this._licenseButton.TabIndex = 3;
            this._licenseButton.Text = "License";
            this._licenseButton.UseVisualStyleBackColor = true;
            this._licenseButton.Click += new System.EventHandler(this.LicenseButtonOnClick);
            // 
            // AboutForm
            // 
            this.Controls.Add(this._licenseButton);
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutFormOnLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _licenseButton;
    }
}