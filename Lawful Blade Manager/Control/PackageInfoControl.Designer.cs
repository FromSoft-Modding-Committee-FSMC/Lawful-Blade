﻿namespace LawfulBladeManager.Control
{
    partial class PackageInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbName = new Label();
            pbIcon = new PictureBox();
            lbDescription = new Label();
            tbDescription = new TextBox();
            lbAuthors = new Label();
            lbUUID = new Label();
            lbVersion = new Label();
            lbTags = new Label();
            Install = new Button();
            lbAuthorsVal = new Label();
            lbVersionVal = new Label();
            lbTagsVal = new Label();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.ForeColor = SystemColors.ButtonFace;
            lbName.Location = new Point(105, 3);
            lbName.Name = "lbName";
            lbName.Size = new Size(77, 30);
            lbName.TabIndex = 0;
            lbName.Text = "{name}";
            // 
            // pbIcon
            // 
            pbIcon.BorderStyle = BorderStyle.FixedSingle;
            pbIcon.Location = new Point(3, 3);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(96, 96);
            pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIcon.TabIndex = 1;
            pbIcon.TabStop = false;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDescription.ForeColor = SystemColors.ButtonFace;
            lbDescription.Location = new Point(3, 102);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(71, 15);
            lbDescription.TabIndex = 2;
            lbDescription.Text = "Description";
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbDescription.BackColor = Color.FromArgb(32, 32, 32);
            tbDescription.BorderStyle = BorderStyle.FixedSingle;
            tbDescription.ForeColor = SystemColors.ButtonFace;
            tbDescription.Location = new Point(3, 120);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.PlaceholderText = "No Description.";
            tbDescription.ReadOnly = true;
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(312, 245);
            tbDescription.TabIndex = 3;
            // 
            // lbAuthors
            // 
            lbAuthors.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbAuthors.AutoSize = true;
            lbAuthors.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbAuthors.ForeColor = SystemColors.ButtonFace;
            lbAuthors.Location = new Point(3, 368);
            lbAuthors.Name = "lbAuthors";
            lbAuthors.Size = new Size(62, 15);
            lbAuthors.TabIndex = 4;
            lbAuthors.Text = "Author(s):";
            // 
            // lbUUID
            // 
            lbUUID.AutoSize = true;
            lbUUID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbUUID.ForeColor = SystemColors.ButtonFace;
            lbUUID.Location = new Point(109, 34);
            lbUUID.Name = "lbUUID";
            lbUUID.Size = new Size(42, 15);
            lbUUID.TabIndex = 5;
            lbUUID.Text = "{UUID}";
            // 
            // lbVersion
            // 
            lbVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbVersion.ForeColor = SystemColors.ButtonFace;
            lbVersion.Location = new Point(3, 384);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(51, 15);
            lbVersion.TabIndex = 6;
            lbVersion.Text = "Version:";
            // 
            // lbTags
            // 
            lbTags.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbTags.AutoSize = true;
            lbTags.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTags.ForeColor = SystemColors.ButtonFace;
            lbTags.Location = new Point(3, 401);
            lbTags.Name = "lbTags";
            lbTags.Size = new Size(45, 15);
            lbTags.TabIndex = 7;
            lbTags.Text = "Tag(s): ";
            // 
            // Install
            // 
            Install.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Install.BackColor = Color.FromArgb(120, 66, 135);
            Install.FlatStyle = FlatStyle.Popup;
            Install.ForeColor = SystemColors.ButtonFace;
            Install.Location = new Point(240, 452);
            Install.Name = "Install";
            Install.Size = new Size(75, 23);
            Install.TabIndex = 8;
            Install.Text = "Install";
            Install.UseVisualStyleBackColor = false;
            // 
            // lbAuthorsVal
            // 
            lbAuthorsVal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbAuthorsVal.AutoSize = true;
            lbAuthorsVal.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbAuthorsVal.ForeColor = SystemColors.ButtonFace;
            lbAuthorsVal.Location = new Point(71, 368);
            lbAuthorsVal.Name = "lbAuthorsVal";
            lbAuthorsVal.Size = new Size(51, 15);
            lbAuthorsVal.TabIndex = 9;
            lbAuthorsVal.Text = "{authors}";
            // 
            // lbVersionVal
            // 
            lbVersionVal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbVersionVal.AutoSize = true;
            lbVersionVal.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbVersionVal.ForeColor = SystemColors.ButtonFace;
            lbVersionVal.Location = new Point(71, 384);
            lbVersionVal.Name = "lbVersionVal";
            lbVersionVal.Size = new Size(48, 15);
            lbVersionVal.TabIndex = 10;
            lbVersionVal.Text = "{version}";
            // 
            // lbTagsVal
            // 
            lbTagsVal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbTagsVal.AutoSize = true;
            lbTagsVal.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbTagsVal.ForeColor = SystemColors.ButtonFace;
            lbTagsVal.Location = new Point(71, 401);
            lbTagsVal.Name = "lbTagsVal";
            lbTagsVal.Size = new Size(35, 15);
            lbTagsVal.TabIndex = 11;
            lbTagsVal.Text = "{tags}";
            // 
            // PackageInfoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbTagsVal);
            Controls.Add(lbVersionVal);
            Controls.Add(lbAuthorsVal);
            Controls.Add(Install);
            Controls.Add(lbTags);
            Controls.Add(lbVersion);
            Controls.Add(lbUUID);
            Controls.Add(lbAuthors);
            Controls.Add(tbDescription);
            Controls.Add(lbDescription);
            Controls.Add(pbIcon);
            Controls.Add(lbName);
            Name = "PackageInfoControl";
            Size = new Size(318, 478);
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private PictureBox pbIcon;
        private Label lbDescription;
        private TextBox tbDescription;
        private Label lbAuthors;
        private Label lbUUID;
        private Label lbVersion;
        private Label lbTags;
        private Button Install;
        private Label lbAuthorsVal;
        private Label lbVersionVal;
        private Label lbTagsVal;
    }
}
