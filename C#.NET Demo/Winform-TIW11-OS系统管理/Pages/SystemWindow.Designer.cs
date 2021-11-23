﻿
namespace ThisIsWin11
{
    partial class SystemWindow
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
            this.btnSystemMenu = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnSystemCheck = new System.Windows.Forms.Button();
            this.menuSystem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSystemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemImportProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemExportProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemExportLog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystemPopOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSystemVersioning = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tvwAssessments = new System.Windows.Forms.TreeView();
            this.btnSystemFix = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblPreview = new System.Windows.Forms.Label();
            this.rtbPS = new System.Windows.Forms.RichTextBox();
            this.lnkSubHeader = new System.Windows.Forms.LinkLabel();
            this.lnkSystemPreset = new System.Windows.Forms.LinkLabel();
            this.menuSystem.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSystemMenu
            // 
            this.btnSystemMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystemMenu.BackColor = System.Drawing.Color.White;
            this.btnSystemMenu.FlatAppearance.BorderSize = 0;
            this.btnSystemMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSystemMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemMenu.Location = new System.Drawing.Point(667, 0);
            this.btnSystemMenu.Name = "btnSystemMenu";
            this.btnSystemMenu.Size = new System.Drawing.Size(48, 51);
            this.btnSystemMenu.TabIndex = 162;
            this.btnSystemMenu.UseVisualStyleBackColor = false;
            this.btnSystemMenu.Click += new System.EventHandler(this.btnSystemMenu_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeader.Location = new System.Drawing.Point(24, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(669, 32);
            this.lblHeader.TabIndex = 161;
            this.lblHeader.Text = "Check Windows 11";
            // 
            // btnSystemCheck
            // 
            this.btnSystemCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSystemCheck.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSystemCheck.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnSystemCheck.FlatAppearance.BorderSize = 0;
            this.btnSystemCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemCheck.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemCheck.ForeColor = System.Drawing.Color.Black;
            this.btnSystemCheck.Location = new System.Drawing.Point(24, 715);
            this.btnSystemCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnSystemCheck.Name = "btnSystemCheck";
            this.btnSystemCheck.Size = new System.Drawing.Size(213, 30);
            this.btnSystemCheck.TabIndex = 159;
            this.btnSystemCheck.Text = "Check";
            this.btnSystemCheck.UseVisualStyleBackColor = false;
            this.btnSystemCheck.Click += new System.EventHandler(this.btnSystemCheck_Click);
            // 
            // menuSystem
            // 
            this.menuSystem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuSystem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystemUndo,
            this.menuSystemImportProfile,
            this.menuSystemExportProfile,
            this.menuSystemExportLog,
            this.menuSystemSelect,
            this.menuSystemPopOut,
            this.toolStripSeparator1,
            this.menuSystemVersioning});
            this.menuSystem.Name = "menuMain";
            this.menuSystem.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuSystem.Size = new System.Drawing.Size(389, 220);
            // 
            // menuSystemUndo
            // 
            this.menuSystemUndo.Name = "menuSystemUndo";
            this.menuSystemUndo.Size = new System.Drawing.Size(388, 30);
            this.menuSystemUndo.Text = "Restore default Windows 11 settings";
            this.menuSystemUndo.Click += new System.EventHandler(this.menuSystemUndo_Click);
            // 
            // menuSystemImportProfile
            // 
            this.menuSystemImportProfile.Name = "menuSystemImportProfile";
            this.menuSystemImportProfile.Size = new System.Drawing.Size(388, 30);
            this.menuSystemImportProfile.Text = "Import profile";
            this.menuSystemImportProfile.Click += new System.EventHandler(this.menuSystemImportProfile_Click);
            // 
            // menuSystemExportProfile
            // 
            this.menuSystemExportProfile.Name = "menuSystemExportProfile";
            this.menuSystemExportProfile.Size = new System.Drawing.Size(388, 30);
            this.menuSystemExportProfile.Text = "Export profile";
            this.menuSystemExportProfile.Click += new System.EventHandler(this.menuSystemExportProfile_Click);
            // 
            // menuSystemExportLog
            // 
            this.menuSystemExportLog.Name = "menuSystemExportLog";
            this.menuSystemExportLog.Size = new System.Drawing.Size(388, 30);
            this.menuSystemExportLog.Text = "Export log";
            this.menuSystemExportLog.Click += new System.EventHandler(this.menuSystemExportLog_Click);
            // 
            // menuSystemSelect
            // 
            this.menuSystemSelect.Name = "menuSystemSelect";
            this.menuSystemSelect.Size = new System.Drawing.Size(388, 30);
            this.menuSystemSelect.Text = "Select all";
            this.menuSystemSelect.Click += new System.EventHandler(this.menuSystemSelect_Click);
            // 
            // menuSystemPopOut
            // 
            this.menuSystemPopOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSystemPopOut.Name = "menuSystemPopOut";
            this.menuSystemPopOut.Size = new System.Drawing.Size(388, 30);
            this.menuSystemPopOut.Text = "Pop-out-App";
            this.menuSystemPopOut.Click += new System.EventHandler(this.menuSystemPopOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(385, 6);
            // 
            // menuSystemVersioning
            // 
            this.menuSystemVersioning.Name = "menuSystemVersioning";
            this.menuSystemVersioning.Size = new System.Drawing.Size(388, 30);
            this.menuSystemVersioning.Text = "Info";
            this.menuSystemVersioning.Click += new System.EventHandler(this.menuSystemInfo_Click);
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(30, 78);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(663, 5);
            this.progress.TabIndex = 166;
            this.progress.Visible = false;
            // 
            // tvwAssessments
            // 
            this.tvwAssessments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwAssessments.BackColor = System.Drawing.Color.White;
            this.tvwAssessments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwAssessments.CheckBoxes = true;
            this.tvwAssessments.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwAssessments.Location = new System.Drawing.Point(24, 99);
            this.tvwAssessments.Name = "tvwAssessments";
            this.tvwAssessments.ShowLines = false;
            this.tvwAssessments.ShowNodeToolTips = true;
            this.tvwAssessments.Size = new System.Drawing.Size(691, 576);
            this.tvwAssessments.TabIndex = 168;
            this.tvwAssessments.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwAssessments_AfterCheck);
            this.tvwAssessments.Click += new System.EventHandler(this.tvwAssessments_Click);
            // 
            // btnSystemFix
            // 
            this.btnSystemFix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSystemFix.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSystemFix.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.btnSystemFix.FlatAppearance.BorderSize = 0;
            this.btnSystemFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemFix.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemFix.ForeColor = System.Drawing.Color.Black;
            this.btnSystemFix.Location = new System.Drawing.Point(250, 715);
            this.btnSystemFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnSystemFix.Name = "btnSystemFix";
            this.btnSystemFix.Size = new System.Drawing.Size(213, 30);
            this.btnSystemFix.TabIndex = 167;
            this.btnSystemFix.Text = "Fix issues";
            this.btnSystemFix.UseVisualStyleBackColor = false;
            this.btnSystemFix.Click += new System.EventHandler(this.btnSystemFix_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.lblPreview);
            this.pnlRight.Controls.Add(this.rtbPS);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(716, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(371, 770);
            this.pnlRight.TabIndex = 170;
            // 
            // lblPreview
            // 
            this.lblPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreview.AutoEllipsis = true;
            this.lblPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.Black;
            this.lblPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPreview.Location = new System.Drawing.Point(21, 21);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(131, 32);
            this.lblPreview.TabIndex = 135;
            this.lblPreview.Text = "Preview";
            // 
            // rtbPS
            // 
            this.rtbPS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPS.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPS.Location = new System.Drawing.Point(27, 99);
            this.rtbPS.Name = "rtbPS";
            this.rtbPS.ReadOnly = true;
            this.rtbPS.Size = new System.Drawing.Size(343, 668);
            this.rtbPS.TabIndex = 138;
            this.rtbPS.Text = "";
            this.rtbPS.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbPS_LinkClicked);
            // 
            // lnkSubHeader
            // 
            this.lnkSubHeader.ActiveLinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubHeader.AutoEllipsis = true;
            this.lnkSubHeader.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubHeader.ForeColor = System.Drawing.Color.Black;
            this.lnkSubHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkSubHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSubHeader.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.lnkSubHeader.Location = new System.Drawing.Point(28, 57);
            this.lnkSubHeader.Name = "lnkSubHeader";
            this.lnkSubHeader.Size = new System.Drawing.Size(660, 18);
            this.lnkSubHeader.TabIndex = 171;
            // 
            // lnkSystemPreset
            // 
            this.lnkSystemPreset.ActiveLinkColor = System.Drawing.Color.HotPink;
            this.lnkSystemPreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSystemPreset.AutoEllipsis = true;
            this.lnkSystemPreset.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSystemPreset.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSystemPreset.LinkColor = System.Drawing.Color.DimGray;
            this.lnkSystemPreset.Location = new System.Drawing.Point(92, 364);
            this.lnkSystemPreset.Name = "lnkSystemPreset";
            this.lnkSystemPreset.Size = new System.Drawing.Size(580, 30);
            this.lnkSystemPreset.TabIndex = 172;
            this.lnkSystemPreset.TabStop = true;
            this.lnkSystemPreset.Text = "Click here to load a preset and let Windows 11 look and feel like Windows 10";
            this.lnkSystemPreset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSystemPreset_LinkClicked);
            // 
            // SystemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 770);
            this.Controls.Add(this.lnkSystemPreset);
            this.Controls.Add(this.lnkSubHeader);
            this.Controls.Add(this.btnSystemFix);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.tvwAssessments);
            this.Controls.Add(this.btnSystemMenu);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnSystemCheck);
            this.Controls.Add(this.pnlRight);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SystemWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PumpedApp";
            this.Shown += new System.EventHandler(this.SystemWindow_Shown);
            this.menuSystem.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSystemMenu;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSystemCheck;
        private System.Windows.Forms.ContextMenuStrip menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuSystemPopOut;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TreeView tvwAssessments;
        private System.Windows.Forms.Button btnSystemFix;
        private System.Windows.Forms.ToolStripMenuItem menuSystemExportLog;
        private System.Windows.Forms.ToolStripMenuItem menuSystemSelect;
        private System.Windows.Forms.ToolStripMenuItem menuSystemVersioning;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblPreview;
        public System.Windows.Forms.RichTextBox rtbPS;
        private System.Windows.Forms.ToolStripMenuItem menuSystemUndo;
        private System.Windows.Forms.LinkLabel lnkSubHeader;
        private System.Windows.Forms.ToolStripMenuItem menuSystemExportProfile;
        private System.Windows.Forms.ToolStripMenuItem menuSystemImportProfile;
        private System.Windows.Forms.LinkLabel lnkSystemPreset;
    }
}