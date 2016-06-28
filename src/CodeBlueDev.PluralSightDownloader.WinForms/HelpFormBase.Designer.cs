namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    public /*abstract*/ partial class HelpFormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpFormBase));
            this.ProductTitle = new System.Windows.Forms.Label();
            this.ContentInfoLabel = new System.Windows.Forms.Label();
            this.ContentInfoTextBox = new System.Windows.Forms.TextBox();
            this._closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductTitle
            // 
            this.ProductTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductTitle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTitle.Location = new System.Drawing.Point(12, 9);
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.Size = new System.Drawing.Size(560, 23);
            this.ProductTitle.TabIndex = 1;
            this.ProductTitle.Text = "ProductTitle";
            this.ProductTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContentInfoLabel
            // 
            this.ContentInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentInfoLabel.Location = new System.Drawing.Point(12, 32);
            this.ContentInfoLabel.Name = "ContentInfoLabel";
            this.ContentInfoLabel.Size = new System.Drawing.Size(560, 60);
            this.ContentInfoLabel.TabIndex = 2;
            this.ContentInfoLabel.Text = "ContentInfo";
            this.ContentInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContentInfoTextBox
            // 
            this.ContentInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentInfoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ContentInfoTextBox.Location = new System.Drawing.Point(12, 95);
            this.ContentInfoTextBox.Multiline = true;
            this.ContentInfoTextBox.Name = "ContentInfoTextBox";
            this.ContentInfoTextBox.ReadOnly = true;
            this.ContentInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ContentInfoTextBox.Size = new System.Drawing.Size(560, 176);
            this.ContentInfoTextBox.TabIndex = 3;
            // 
            // _closeButton
            // 
            this._closeButton.Location = new System.Drawing.Point(497, 277);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(75, 23);
            this._closeButton.TabIndex = 1;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // HelpFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this.ContentInfoTextBox);
            this.Controls.Add(this.ContentInfoLabel);
            this.Controls.Add(this.ProductTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HelpFormBase";
            this.Load += new System.EventHandler(this.HelpFormBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _closeButton;
        protected System.Windows.Forms.Label ProductTitle;
        protected System.Windows.Forms.Label ContentInfoLabel;
        protected System.Windows.Forms.TextBox ContentInfoTextBox;
    }
}