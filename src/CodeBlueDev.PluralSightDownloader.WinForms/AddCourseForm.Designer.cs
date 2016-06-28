namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    partial class AddCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseForm));
            this._courseTitleLabel = new System.Windows.Forms.Label();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._primaryAuthorLabel = new System.Windows.Forms.Label();
            this._shortDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _courseTitleLabel
            // 
            this._courseTitleLabel.AutoSize = true;
            this._courseTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._courseTitleLabel.Location = new System.Drawing.Point(12, 9);
            this._courseTitleLabel.Name = "_courseTitleLabel";
            this._courseTitleLabel.Size = new System.Drawing.Size(40, 13);
            this._courseTitleLabel.TabIndex = 0;
            this._courseTitleLabel.Text = ":Title:";
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(399, 227);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "&Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(318, 227);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 2;
            this._okButton.Text = "&OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _primaryAuthorLabel
            // 
            this._primaryAuthorLabel.AutoSize = true;
            this._primaryAuthorLabel.Location = new System.Drawing.Point(12, 39);
            this._primaryAuthorLabel.Name = "_primaryAuthorLabel";
            this._primaryAuthorLabel.Size = new System.Drawing.Size(78, 13);
            this._primaryAuthorLabel.TabIndex = 3;
            this._primaryAuthorLabel.Text = ":PrimaryAuthor:";
            // 
            // _shortDescriptionLabel
            // 
            this._shortDescriptionLabel.Location = new System.Drawing.Point(12, 60);
            this._shortDescriptionLabel.Name = "_shortDescriptionLabel";
            this._shortDescriptionLabel.Size = new System.Drawing.Size(462, 40);
            this._shortDescriptionLabel.TabIndex = 4;
            this._shortDescriptionLabel.Text = ":Description:";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 262);
            this.Controls.Add(this._shortDescriptionLabel);
            this.Controls.Add(this._primaryAuthorLabel);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._courseTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCourseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add PluralSight Course";
            this.Load += new System.EventHandler(this.AddCourseFormOnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _courseTitleLabel;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Label _primaryAuthorLabel;
        private System.Windows.Forms.Label _shortDescriptionLabel;
    }
}