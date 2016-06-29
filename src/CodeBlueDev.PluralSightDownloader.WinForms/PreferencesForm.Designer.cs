namespace CodeBlueDev.PluralSightDownloader.WinForms
{
    partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this._applyButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._buttonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._loginOptionsLabel = new CodeBlueDev.PluralSightDownloader.WinForms.Controls.FlowLayoutLabel();
            this._downloadOptionsLabel = new CodeBlueDev.PluralSightDownloader.WinForms.Controls.FlowLayoutLabel();
            this._buttonsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _applyButton
            // 
            this._applyButton.Enabled = false;
            this._applyButton.Location = new System.Drawing.Point(397, 427);
            this._applyButton.Name = "_applyButton";
            this._applyButton.Size = new System.Drawing.Size(75, 23);
            this._applyButton.TabIndex = 1;
            this._applyButton.Text = "&Apply";
            this._applyButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(316, 427);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 2;
            this._cancelButton.Text = "&Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(235, 427);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 3;
            this._okButton.Text = "&OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(139, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 409);
            this.panel1.TabIndex = 4;
            // 
            // _buttonsFlowLayoutPanel
            // 
            this._buttonsFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._buttonsFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._buttonsFlowLayoutPanel.Controls.Add(this._loginOptionsLabel);
            this._buttonsFlowLayoutPanel.Controls.Add(this._downloadOptionsLabel);
            this._buttonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._buttonsFlowLayoutPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonsFlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this._buttonsFlowLayoutPanel.Name = "_buttonsFlowLayoutPanel";
            this._buttonsFlowLayoutPanel.Size = new System.Drawing.Size(120, 409);
            this._buttonsFlowLayoutPanel.TabIndex = 5;
            // 
            // _loginOptionsLabel
            // 
            this._loginOptionsLabel.BackColor = System.Drawing.Color.Transparent;
            this._loginOptionsLabel.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this._loginOptionsLabel.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.preferences_login;
            this._loginOptionsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._loginOptionsLabel.IsSelected = false;
            this._loginOptionsLabel.Location = new System.Drawing.Point(10, 10);
            this._loginOptionsLabel.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this._loginOptionsLabel.Name = "_loginOptionsLabel";
            this._loginOptionsLabel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this._loginOptionsLabel.SelectedBackColor = System.Drawing.Color.LightSteelBlue;
            this._loginOptionsLabel.SelectedBorderColor = System.Drawing.Color.SteelBlue;
            this._loginOptionsLabel.SelectedFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this._loginOptionsLabel.Size = new System.Drawing.Size(100, 53);
            this._loginOptionsLabel.TabIndex = 0;
            this._loginOptionsLabel.Text = "Login";
            this._loginOptionsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._loginOptionsLabel.UnselectedBackColor = System.Drawing.Color.Transparent;
            this._loginOptionsLabel.UnselectedBorderColor = System.Drawing.Color.Transparent;
            this._loginOptionsLabel.UnselectedFont = new System.Drawing.Font("Tahoma", 9.75F);
            this._loginOptionsLabel.BeforeMouseClick += new System.EventHandler<System.ComponentModel.CancelEventArgs>(this.NavigationLabelsOnBeforeMouseClick);
            this._loginOptionsLabel.Click += new System.EventHandler(this.NavigationLabelsOnClick);
            // 
            // _downloadOptionsLabel
            // 
            this._downloadOptionsLabel.BackColor = System.Drawing.Color.Transparent;
            this._downloadOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._downloadOptionsLabel.Image = global::CodeBlueDev.PluralSightDownloader.WinForms.Properties.Resources.preferences_download;
            this._downloadOptionsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._downloadOptionsLabel.IsSelected = false;
            this._downloadOptionsLabel.Location = new System.Drawing.Point(10, 83);
            this._downloadOptionsLabel.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this._downloadOptionsLabel.Name = "_downloadOptionsLabel";
            this._downloadOptionsLabel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this._downloadOptionsLabel.SelectedBackColor = System.Drawing.Color.LightSteelBlue;
            this._downloadOptionsLabel.SelectedBorderColor = System.Drawing.Color.SteelBlue;
            this._downloadOptionsLabel.SelectedFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this._downloadOptionsLabel.Size = new System.Drawing.Size(100, 53);
            this._downloadOptionsLabel.TabIndex = 1;
            this._downloadOptionsLabel.Text = "Download";
            this._downloadOptionsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._downloadOptionsLabel.UnselectedBackColor = System.Drawing.Color.Transparent;
            this._downloadOptionsLabel.UnselectedBorderColor = System.Drawing.Color.Transparent;
            this._downloadOptionsLabel.UnselectedFont = new System.Drawing.Font("Tahoma", 9.75F);
            this._downloadOptionsLabel.BeforeMouseClick += new System.EventHandler<System.ComponentModel.CancelEventArgs>(this.NavigationLabelsOnBeforeMouseClick);
            this._downloadOptionsLabel.Click += new System.EventHandler(this.NavigationLabelsOnClick);
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this._buttonsFlowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._applyButton);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this._buttonsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _applyButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel _buttonsFlowLayoutPanel;
        private Controls.FlowLayoutLabel _loginOptionsLabel;
        private Controls.FlowLayoutLabel _downloadOptionsLabel;
    }
}