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
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._addCourseTabControl = new System.Windows.Forms.TabControl();
            this._downloadSettingsTabPage = new System.Windows.Forms.TabPage();
            this._courseInformationTabPage = new System.Windows.Forms.TabPage();
            this._courseReleaseDateValueLabel = new System.Windows.Forms.Label();
            this._courseReleaseDateDescriptionLabel = new System.Windows.Forms.Label();
            this._courseDurationValueLabel = new System.Windows.Forms.Label();
            this._courseDurationDescriptionLabel = new System.Windows.Forms.Label();
            this._courseRatingDescriptionLabel = new System.Windows.Forms.Label();
            this._courseRatingValueLabel = new System.Windows.Forms.Label();
            this._courseLevelValueLabel = new System.Windows.Forms.Label();
            this._courseLevelDescriptionLabel = new System.Windows.Forms.Label();
            this._shortDescriptionTextBox = new System.Windows.Forms.TextBox();
            this._shortDescriptionLabel = new System.Windows.Forms.Label();
            this._courseDescriptionTextBox = new System.Windows.Forms.TextBox();
            this._courseDescriptionLabel = new System.Windows.Forms.Label();
            this._authorDescriptionLabel = new System.Windows.Forms.Label();
            this._authorsListBox = new System.Windows.Forms.ListBox();
            this._tableOfContentsTabPage = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this._addCourseTabControl.SuspendLayout();
            this._courseInformationTabPage.SuspendLayout();
            this._tableOfContentsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(399, 330);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "&Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(318, 330);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 2;
            this._okButton.Text = "&OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _addCourseTabControl
            // 
            this._addCourseTabControl.Controls.Add(this._downloadSettingsTabPage);
            this._addCourseTabControl.Controls.Add(this._courseInformationTabPage);
            this._addCourseTabControl.Controls.Add(this._tableOfContentsTabPage);
            this._addCourseTabControl.Location = new System.Drawing.Point(13, 13);
            this._addCourseTabControl.Name = "_addCourseTabControl";
            this._addCourseTabControl.SelectedIndex = 0;
            this._addCourseTabControl.Size = new System.Drawing.Size(461, 301);
            this._addCourseTabControl.TabIndex = 3;
            // 
            // _downloadSettingsTabPage
            // 
            this._downloadSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this._downloadSettingsTabPage.Name = "_downloadSettingsTabPage";
            this._downloadSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._downloadSettingsTabPage.Size = new System.Drawing.Size(453, 285);
            this._downloadSettingsTabPage.TabIndex = 0;
            this._downloadSettingsTabPage.Text = "Download Settings";
            this._downloadSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // _courseInformationTabPage
            // 
            this._courseInformationTabPage.Controls.Add(this._courseReleaseDateValueLabel);
            this._courseInformationTabPage.Controls.Add(this._courseReleaseDateDescriptionLabel);
            this._courseInformationTabPage.Controls.Add(this._courseDurationValueLabel);
            this._courseInformationTabPage.Controls.Add(this._courseDurationDescriptionLabel);
            this._courseInformationTabPage.Controls.Add(this._courseRatingDescriptionLabel);
            this._courseInformationTabPage.Controls.Add(this._courseRatingValueLabel);
            this._courseInformationTabPage.Controls.Add(this._courseLevelValueLabel);
            this._courseInformationTabPage.Controls.Add(this._courseLevelDescriptionLabel);
            this._courseInformationTabPage.Controls.Add(this._shortDescriptionTextBox);
            this._courseInformationTabPage.Controls.Add(this._shortDescriptionLabel);
            this._courseInformationTabPage.Controls.Add(this._courseDescriptionTextBox);
            this._courseInformationTabPage.Controls.Add(this._courseDescriptionLabel);
            this._courseInformationTabPage.Controls.Add(this._authorDescriptionLabel);
            this._courseInformationTabPage.Controls.Add(this._authorsListBox);
            this._courseInformationTabPage.Location = new System.Drawing.Point(4, 22);
            this._courseInformationTabPage.Name = "_courseInformationTabPage";
            this._courseInformationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._courseInformationTabPage.Size = new System.Drawing.Size(453, 275);
            this._courseInformationTabPage.TabIndex = 1;
            this._courseInformationTabPage.Text = "Course Information";
            this._courseInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // _courseReleaseDateValueLabel
            // 
            this._courseReleaseDateValueLabel.AutoSize = true;
            this._courseReleaseDateValueLabel.Location = new System.Drawing.Point(67, 71);
            this._courseReleaseDateValueLabel.Name = "_courseReleaseDateValueLabel";
            this._courseReleaseDateValueLabel.Size = new System.Drawing.Size(78, 13);
            this._courseReleaseDateValueLabel.TabIndex = 22;
            this._courseReleaseDateValueLabel.Text = ":Release Date:";
            // 
            // _courseReleaseDateDescriptionLabel
            // 
            this._courseReleaseDateDescriptionLabel.AutoSize = true;
            this._courseReleaseDateDescriptionLabel.Location = new System.Drawing.Point(6, 71);
            this._courseReleaseDateDescriptionLabel.Name = "_courseReleaseDateDescriptionLabel";
            this._courseReleaseDateDescriptionLabel.Size = new System.Drawing.Size(55, 13);
            this._courseReleaseDateDescriptionLabel.TabIndex = 21;
            this._courseReleaseDateDescriptionLabel.Text = "Released:";
            // 
            // _courseDurationValueLabel
            // 
            this._courseDurationValueLabel.AutoSize = true;
            this._courseDurationValueLabel.Location = new System.Drawing.Point(67, 50);
            this._courseDurationValueLabel.Name = "_courseDurationValueLabel";
            this._courseDurationValueLabel.Size = new System.Drawing.Size(53, 13);
            this._courseDurationValueLabel.TabIndex = 20;
            this._courseDurationValueLabel.Text = ":Duration:";
            // 
            // _courseDurationDescriptionLabel
            // 
            this._courseDurationDescriptionLabel.AutoSize = true;
            this._courseDurationDescriptionLabel.Location = new System.Drawing.Point(6, 50);
            this._courseDurationDescriptionLabel.Name = "_courseDurationDescriptionLabel";
            this._courseDurationDescriptionLabel.Size = new System.Drawing.Size(50, 13);
            this._courseDurationDescriptionLabel.TabIndex = 19;
            this._courseDurationDescriptionLabel.Text = "Duration:";
            // 
            // _courseRatingDescriptionLabel
            // 
            this._courseRatingDescriptionLabel.AutoSize = true;
            this._courseRatingDescriptionLabel.Location = new System.Drawing.Point(6, 29);
            this._courseRatingDescriptionLabel.Name = "_courseRatingDescriptionLabel";
            this._courseRatingDescriptionLabel.Size = new System.Drawing.Size(41, 13);
            this._courseRatingDescriptionLabel.TabIndex = 18;
            this._courseRatingDescriptionLabel.Text = "Rating:";
            // 
            // _courseRatingValueLabel
            // 
            this._courseRatingValueLabel.AutoSize = true;
            this._courseRatingValueLabel.Location = new System.Drawing.Point(67, 29);
            this._courseRatingValueLabel.Name = "_courseRatingValueLabel";
            this._courseRatingValueLabel.Size = new System.Drawing.Size(44, 13);
            this._courseRatingValueLabel.TabIndex = 17;
            this._courseRatingValueLabel.Text = ":Rating:";
            // 
            // _courseLevelValueLabel
            // 
            this._courseLevelValueLabel.AutoSize = true;
            this._courseLevelValueLabel.Location = new System.Drawing.Point(67, 8);
            this._courseLevelValueLabel.Name = "_courseLevelValueLabel";
            this._courseLevelValueLabel.Size = new System.Drawing.Size(39, 13);
            this._courseLevelValueLabel.TabIndex = 16;
            this._courseLevelValueLabel.Text = ":Level:";
            // 
            // _courseLevelDescriptionLabel
            // 
            this._courseLevelDescriptionLabel.AutoSize = true;
            this._courseLevelDescriptionLabel.Location = new System.Drawing.Point(6, 8);
            this._courseLevelDescriptionLabel.Name = "_courseLevelDescriptionLabel";
            this._courseLevelDescriptionLabel.Size = new System.Drawing.Size(36, 13);
            this._courseLevelDescriptionLabel.TabIndex = 15;
            this._courseLevelDescriptionLabel.Text = "Level:";
            // 
            // _shortDescriptionTextBox
            // 
            this._shortDescriptionTextBox.Location = new System.Drawing.Point(154, 24);
            this._shortDescriptionTextBox.Multiline = true;
            this._shortDescriptionTextBox.Name = "_shortDescriptionTextBox";
            this._shortDescriptionTextBox.Size = new System.Drawing.Size(293, 60);
            this._shortDescriptionTextBox.TabIndex = 14;
            // 
            // _shortDescriptionLabel
            // 
            this._shortDescriptionLabel.AutoSize = true;
            this._shortDescriptionLabel.Location = new System.Drawing.Point(151, 8);
            this._shortDescriptionLabel.Name = "_shortDescriptionLabel";
            this._shortDescriptionLabel.Size = new System.Drawing.Size(91, 13);
            this._shortDescriptionLabel.TabIndex = 13;
            this._shortDescriptionLabel.Text = "Short Description:";
            // 
            // _courseDescriptionTextBox
            // 
            this._courseDescriptionTextBox.Location = new System.Drawing.Point(154, 108);
            this._courseDescriptionTextBox.Multiline = true;
            this._courseDescriptionTextBox.Name = "_courseDescriptionTextBox";
            this._courseDescriptionTextBox.Size = new System.Drawing.Size(293, 161);
            this._courseDescriptionTextBox.TabIndex = 12;
            // 
            // _courseDescriptionLabel
            // 
            this._courseDescriptionLabel.AutoSize = true;
            this._courseDescriptionLabel.Location = new System.Drawing.Point(151, 92);
            this._courseDescriptionLabel.Name = "_courseDescriptionLabel";
            this._courseDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this._courseDescriptionLabel.TabIndex = 11;
            this._courseDescriptionLabel.Text = "Description:";
            // 
            // _authorDescriptionLabel
            // 
            this._authorDescriptionLabel.AutoSize = true;
            this._authorDescriptionLabel.Location = new System.Drawing.Point(6, 92);
            this._authorDescriptionLabel.Name = "_authorDescriptionLabel";
            this._authorDescriptionLabel.Size = new System.Drawing.Size(55, 13);
            this._authorDescriptionLabel.TabIndex = 10;
            this._authorDescriptionLabel.Text = ":Author(s):";
            // 
            // _authorsListBox
            // 
            this._authorsListBox.FormattingEnabled = true;
            this._authorsListBox.Location = new System.Drawing.Point(6, 108);
            this._authorsListBox.Name = "_authorsListBox";
            this._authorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this._authorsListBox.Size = new System.Drawing.Size(142, 160);
            this._authorsListBox.Sorted = true;
            this._authorsListBox.TabIndex = 9;
            // 
            // _tableOfContentsTabPage
            // 
            this._tableOfContentsTabPage.Controls.Add(this.treeView1);
            this._tableOfContentsTabPage.Location = new System.Drawing.Point(4, 22);
            this._tableOfContentsTabPage.Name = "_tableOfContentsTabPage";
            this._tableOfContentsTabPage.Size = new System.Drawing.Size(453, 285);
            this._tableOfContentsTabPage.TabIndex = 2;
            this._tableOfContentsTabPage.Text = "Table of Contents";
            this._tableOfContentsTabPage.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(446, 278);
            this.treeView1.TabIndex = 0;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 365);
            this.Controls.Add(this._addCourseTabControl);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCourseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ":CourseTitle:";
            this.Load += new System.EventHandler(this.AddCourseFormOnLoad);
            this._addCourseTabControl.ResumeLayout(false);
            this._courseInformationTabPage.ResumeLayout(false);
            this._courseInformationTabPage.PerformLayout();
            this._tableOfContentsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.TabControl _addCourseTabControl;
        private System.Windows.Forms.TabPage _downloadSettingsTabPage;
        private System.Windows.Forms.TabPage _courseInformationTabPage;
        private System.Windows.Forms.TextBox _shortDescriptionTextBox;
        private System.Windows.Forms.Label _shortDescriptionLabel;
        private System.Windows.Forms.TextBox _courseDescriptionTextBox;
        private System.Windows.Forms.Label _courseDescriptionLabel;
        private System.Windows.Forms.Label _authorDescriptionLabel;
        private System.Windows.Forms.ListBox _authorsListBox;
        private System.Windows.Forms.TabPage _tableOfContentsTabPage;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label _courseReleaseDateValueLabel;
        private System.Windows.Forms.Label _courseReleaseDateDescriptionLabel;
        private System.Windows.Forms.Label _courseDurationValueLabel;
        private System.Windows.Forms.Label _courseDurationDescriptionLabel;
        private System.Windows.Forms.Label _courseRatingDescriptionLabel;
        private System.Windows.Forms.Label _courseRatingValueLabel;
        private System.Windows.Forms.Label _courseLevelValueLabel;
        private System.Windows.Forms.Label _courseLevelDescriptionLabel;
    }
}