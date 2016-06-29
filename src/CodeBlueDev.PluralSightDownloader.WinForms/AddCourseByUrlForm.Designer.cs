namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    partial class AddCourseByUrlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseByUrlForm));
            this._addCourseByUrlLabel = new System.Windows.Forms.Label();
            this._coursesToAddTextBox = new System.Windows.Forms.TextBox();
            this._addCourseByUrlAdditionalInformationLabel = new System.Windows.Forms.Label();
            this._addButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._ctrlEnterInformationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _addCourseByUrlLabel
            // 
            this._addCourseByUrlLabel.AutoSize = true;
            this._addCourseByUrlLabel.Location = new System.Drawing.Point(12, 9);
            this._addCourseByUrlLabel.Name = "_addCourseByUrlLabel";
            this._addCourseByUrlLabel.Size = new System.Drawing.Size(150, 13);
            this._addCourseByUrlLabel.TabIndex = 0;
            this._addCourseByUrlLabel.Text = "Add PluralSight Courses by Url";
            // 
            // _coursesToAddTextBox
            // 
            this._coursesToAddTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._coursesToAddTextBox.Location = new System.Drawing.Point(12, 25);
            this._coursesToAddTextBox.Multiline = true;
            this._coursesToAddTextBox.Name = "_coursesToAddTextBox";
            this._coursesToAddTextBox.Size = new System.Drawing.Size(560, 183);
            this._coursesToAddTextBox.TabIndex = 1;
            // 
            // _addCourseByUrlAdditionalInformationLabel
            // 
            this._addCourseByUrlAdditionalInformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addCourseByUrlAdditionalInformationLabel.AutoSize = true;
            this._addCourseByUrlAdditionalInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addCourseByUrlAdditionalInformationLabel.Location = new System.Drawing.Point(12, 211);
            this._addCourseByUrlAdditionalInformationLabel.Name = "_addCourseByUrlAdditionalInformationLabel";
            this._addCourseByUrlAdditionalInformationLabel.Size = new System.Drawing.Size(439, 13);
            this._addCourseByUrlAdditionalInformationLabel.TabIndex = 2;
            this._addCourseByUrlAdditionalInformationLabel.Text = "Add one course Url per line (e.g. https://app.pluralsight.com/library/courses/pat" +
    "terns-library)";
            // 
            // _addButton
            // 
            this._addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._addButton.Location = new System.Drawing.Point(416, 227);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 23);
            this._addButton.TabIndex = 3;
            this._addButton.Text = "&Add";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(497, 227);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 4;
            this._cancelButton.Text = "&Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _ctrlEnterInformationLabel
            // 
            this._ctrlEnterInformationLabel.AutoSize = true;
            this._ctrlEnterInformationLabel.Location = new System.Drawing.Point(12, 232);
            this._ctrlEnterInformationLabel.Name = "_ctrlEnterInformationLabel";
            this._ctrlEnterInformationLabel.Size = new System.Drawing.Size(156, 13);
            this._ctrlEnterInformationLabel.TabIndex = 5;
            this._ctrlEnterInformationLabel.Text = "Use Ctrl+Enter to go to next line";
            // 
            // AddCourseByUrlForm
            // 
            this.AcceptButton = this._addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this._ctrlEnterInformationLabel);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._addButton);
            this.Controls.Add(this._addCourseByUrlAdditionalInformationLabel);
            this.Controls.Add(this._coursesToAddTextBox);
            this.Controls.Add(this._addCourseByUrlLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "AddCourseByUrlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add by Urls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _addCourseByUrlLabel;
        private System.Windows.Forms.TextBox _coursesToAddTextBox;
        private System.Windows.Forms.Label _addCourseByUrlAdditionalInformationLabel;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _ctrlEnterInformationLabel;
    }
}