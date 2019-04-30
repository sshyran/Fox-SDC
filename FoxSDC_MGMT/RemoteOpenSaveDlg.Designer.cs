﻿namespace FoxSDC_MGMT
{
    partial class frmRemoteOpenSaveDlg
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
            this.components = new System.ComponentModel.Container();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.lstDirs = new FoxSDC_MGMT.NT3PathListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDrives = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(449, 12);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 3;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(449, 41);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filename:";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(15, 25);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(194, 20);
            this.txtFilename.TabIndex = 5;
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.IntegralHeight = false;
            this.lstFiles.Location = new System.Drawing.Point(15, 51);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.ScrollAlwaysVisible = true;
            this.lstFiles.Size = new System.Drawing.Size(194, 195);
            this.lstFiles.TabIndex = 6;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            this.lstFiles.DoubleClick += new System.EventHandler(this.lstFiles_DoubleClick);
            // 
            // lstDirs
            // 
            this.lstDirs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstDirs.FormattingEnabled = true;
            this.lstDirs.IntegralHeight = false;
            this.lstDirs.Location = new System.Drawing.Point(235, 51);
            this.lstDirs.Name = "lstDirs";
            this.lstDirs.ScrollAlwaysVisible = true;
            this.lstDirs.Size = new System.Drawing.Size(194, 195);
            this.lstDirs.TabIndex = 7;
            this.lstDirs.DoubleClick += new System.EventHandler(this.lstDirs_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Directories:";
            // 
            // lblDir
            // 
            this.lblDir.AutoEllipsis = true;
            this.lblDir.Location = new System.Drawing.Point(232, 28);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(197, 13);
            this.lblDir.TabIndex = 9;
            this.lblDir.Text = "C:\\Windows";
            this.toolTip1.SetToolTip(this.lblDir, "C:\\Windows");
            this.lblDir.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type:";
            // 
            // lstType
            // 
            this.lstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstType.FormattingEnabled = true;
            this.lstType.Location = new System.Drawing.Point(15, 275);
            this.lstType.Name = "lstType";
            this.lstType.Size = new System.Drawing.Size(194, 21);
            this.lstType.TabIndex = 11;
            this.lstType.SelectedIndexChanged += new System.EventHandler(this.lstType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Drive:";
            // 
            // lstDrives
            // 
            this.lstDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDrives.FormattingEnabled = true;
            this.lstDrives.Location = new System.Drawing.Point(235, 275);
            this.lstDrives.Name = "lstDrives";
            this.lstDrives.Size = new System.Drawing.Size(194, 21);
            this.lstDrives.TabIndex = 13;
            this.lstDrives.SelectedIndexChanged += new System.EventHandler(this.lstDrives_SelectedIndexChanged);
            // 
            // frmRemoteOpenSaveDlg
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(539, 306);
            this.Controls.Add(this.lstDrives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDirs);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRemoteOpenSaveDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open";
            this.Load += new System.EventHandler(this.frmRemoteOpenSaveDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.ListBox lstFiles;
        private NT3PathListBox lstDirs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lstType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lstDrives;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}