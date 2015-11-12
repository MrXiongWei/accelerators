﻿/* *********************************************************************************************
 *  This file is part of the Oracle Service Cloud Accelerator Reference Integration set published
 *  by Oracle Service Cloud under the MIT license (MIT) included in the original distribution.
 *  Copyright (c) 2014, 2015, Oracle and/or its affiliates. All rights reserved.
 ***********************************************************************************************
 *  Accelerator Package: OSVC Contact Center + Siebel Case Management Accelerator
 *  link: http://www.oracle.com/technetwork/indexes/samplecode/accelerator-osvc-2525361.html
 *  OSvC release: 15.8 (August 2015)
 *  Siebel release: 8.1.1.15
 *  reference: 150520-000047
 *  date: Thu Nov 12 00:55:36 PST 2015

 *  revision: rnw-15-11-fixes-release-1
 *  SHA1: $Id: 90e7c7b38a01a1e65409d8a267b1e64e51884cc2 $
 * *********************************************************************************************
 *  File: LogHistoryNSettingForm.Designer.cs
 * *********************************************************************************************/
using System.Windows.Forms;

namespace Accelerator.Siebel.SharedServices
{
    partial class LogHistoryNSettingForm
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
            this.logHistoryListView = new System.Windows.Forms.ListView();
            this.logHistoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logLevelSettingLabel = new System.Windows.Forms.Label();
            this.logLevelSettingMenu = new System.Windows.Forms.ComboBox();
            this.validateConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logHistoryListView
            // 
            this.logHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.logHistoryColumnHeader});
            this.logHistoryListView.GridLines = true;
            this.logHistoryListView.Location = new System.Drawing.Point(12, 12);
            this.logHistoryListView.Name = "logHistoryListView";
            this.logHistoryListView.Size = new System.Drawing.Size(672, 201);
            this.logHistoryListView.TabIndex = 0;
            this.logHistoryListView.UseCompatibleStateImageBehavior = false;
            this.logHistoryListView.View = System.Windows.Forms.View.Details;
            this.logHistoryListView.SelectedIndexChanged += new System.EventHandler(this.logHistoryListView_SelectedIndexChanged);
            // 
            // logHistoryColumnHeader
            // 
            this.logHistoryColumnHeader.Text = "10 Most Recent Log History Rows";
            this.logHistoryColumnHeader.Width = 668;
            // 
            // logLevelSettingLabel
            // 
            this.logLevelSettingLabel.AutoSize = true;
            this.logLevelSettingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLevelSettingLabel.Location = new System.Drawing.Point(12, 233);
            this.logLevelSettingLabel.Name = "logLevelSettingLabel";
            this.logLevelSettingLabel.Size = new System.Drawing.Size(149, 13);
            this.logLevelSettingLabel.TabIndex = 1;
            this.logLevelSettingLabel.Text = "Database Logging Level:";
            // 
            // logLevelSettingMenu
            // 
            this.logLevelSettingMenu.FormattingEnabled = true;
            this.logLevelSettingMenu.Items.AddRange(new object[] {
            "Error",
            "Notice",
            "Debug"});
            this.logLevelSettingMenu.Location = new System.Drawing.Point(167, 236);
            this.logLevelSettingMenu.Name = "logLevelSettingMenu";
            this.logLevelSettingMenu.Size = new System.Drawing.Size(121, 21);
            this.logLevelSettingMenu.TabIndex = 2;
            this.logLevelSettingMenu.SelectedIndexChanged += new System.EventHandler(this.logHistoryMenu_SelectedIndexChanged);
            this.logLevelSettingMenu.SelectedIndex = (int)ConfigurationSetting.logLevel; 
            // 
            // validateConfig
            // 
            this.validateConfig.Location = new System.Drawing.Point(15, 264);
            this.validateConfig.Name = "validateConfig";
            this.validateConfig.Size = new System.Drawing.Size(146, 23);
            this.validateConfig.TabIndex = 3;
            this.validateConfig.Text = "Validate Config Verb";
            this.validateConfig.UseVisualStyleBackColor = true;
            this.validateConfig.Click += new System.EventHandler(this.validateConfig_Click);
            // 
            // LogHistoryNSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 299);
            this.Controls.Add(this.validateConfig);
            this.Controls.Add(this.logLevelSettingMenu);
            this.Controls.Add(this.logLevelSettingLabel);
            this.Controls.Add(this.logHistoryListView);
            this.Name = "LogHistoryNSettingForm";
            this.Text = "Log History and Level Setting Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView logHistoryListView;
        private System.Windows.Forms.ColumnHeader logHistoryColumnHeader;
        private System.Windows.Forms.Label logLevelSettingLabel;
        private System.Windows.Forms.ComboBox logLevelSettingMenu;
        private Button validateConfig;
    }
}