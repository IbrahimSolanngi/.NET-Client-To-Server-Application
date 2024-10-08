﻿namespace PNDC_ClientToServerProject
{
    partial class Form_SendServerFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SendServerFiles));
            this.notificationTempLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.fileNotificationLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notificationPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeSaveLocButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notificationLabel = new System.Windows.Forms.Label();
            this.onlinePCList = new System.Windows.Forms.ListView();
            this.notificationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationTempLabel
            // 
            this.notificationTempLabel.AutoSize = true;
            this.notificationTempLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTempLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notificationTempLabel.Location = new System.Drawing.Point(4, 25);
            this.notificationTempLabel.Name = "notificationTempLabel";
            this.notificationTempLabel.Size = new System.Drawing.Size(175, 18);
            this.notificationTempLabel.TabIndex = 2;
            this.notificationTempLabel.Text = "Please wait. File Sending to";
            this.notificationTempLabel.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Insert receiver\'s IP";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(123, 372);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 20);
            this.ipBox.TabIndex = 24;
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Location = new System.Drawing.Point(311, 65);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(141, 13);
            this.savePathLabel.TabIndex = 23;
            this.savePathLabel.Text = "C:\\Users\\Public\\Downloads";
            // 
            // fileNotificationLabel
            // 
            this.fileNotificationLabel.AutoSize = true;
            this.fileNotificationLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.fileNotificationLabel.Location = new System.Drawing.Point(18, 317);
            this.fileNotificationLabel.Name = "fileNotificationLabel";
            this.fileNotificationLabel.Size = new System.Drawing.Size(10, 13);
            this.fileNotificationLabel.TabIndex = 22;
            this.fileNotificationLabel.Text = ".";
            // 
            // notificationPanel
            // 
            this.notificationPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.notificationPanel.Controls.Add(this.notificationTempLabel);
            this.notificationPanel.Location = new System.Drawing.Point(24, 173);
            this.notificationPanel.Name = "notificationPanel";
            this.notificationPanel.Size = new System.Drawing.Size(524, 90);
            this.notificationPanel.TabIndex = 26;
            this.notificationPanel.UseWaitCursor = true;
            this.notificationPanel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Location = new System.Drawing.Point(454, 359);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 34);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(131, 66);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(10, 13);
            this.infoLabel.TabIndex = 20;
            this.infoLabel.Text = ".";
            // 
            // sendFileButton
            // 
            this.sendFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendFileButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sendFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendFileButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendFileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sendFileButton.Location = new System.Drawing.Point(226, 359);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(222, 34);
            this.sendFileButton.TabIndex = 19;
            this.sendFileButton.Text = "Send File to Selected Computer";
            this.sendFileButton.UseVisualStyleBackColor = false;
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browseButton.Location = new System.Drawing.Point(13, 359);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(109, 34);
            this.browseButton.TabIndex = 18;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.ForeColor = System.Drawing.Color.Teal;
            this.fileNameLabel.Location = new System.Drawing.Point(18, 334);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(10, 13);
            this.fileNameLabel.TabIndex = 16;
            this.fileNameLabel.Text = ".";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(419, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 36);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeSaveLocButton
            // 
            this.changeSaveLocButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.changeSaveLocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSaveLocButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSaveLocButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeSaveLocButton.Location = new System.Drawing.Point(281, -1);
            this.changeSaveLocButton.Name = "changeSaveLocButton";
            this.changeSaveLocButton.Size = new System.Drawing.Size(139, 36);
            this.changeSaveLocButton.TabIndex = 10;
            this.changeSaveLocButton.Text = "Change Save Location";
            this.changeSaveLocButton.UseVisualStyleBackColor = false;
            this.changeSaveLocButton.Click += new System.EventHandler(this.changeSaveLocButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopButton.Location = new System.Drawing.Point(143, -1);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(139, 36);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop Application";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.changeSaveLocButton);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Location = new System.Drawing.Point(5, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 36);
            this.panel1.TabIndex = 15;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startButton.Location = new System.Drawing.Point(5, -1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 36);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Find/Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Computer Name";
            this.columnHeader2.Width = 263;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 271;
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Location = new System.Drawing.Point(21, 65);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(10, 13);
            this.notificationLabel.TabIndex = 17;
            this.notificationLabel.Text = ".";
            // 
            // onlinePCList
            // 
            this.onlinePCList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.onlinePCList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onlinePCList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.onlinePCList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePCList.FullRowSelect = true;
            this.onlinePCList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.onlinePCList.HideSelection = false;
            this.onlinePCList.HoverSelection = true;
            this.onlinePCList.Location = new System.Drawing.Point(17, 81);
            this.onlinePCList.MultiSelect = false;
            this.onlinePCList.Name = "onlinePCList";
            this.onlinePCList.Size = new System.Drawing.Size(539, 229);
            this.onlinePCList.TabIndex = 14;
            this.onlinePCList.UseCompatibleStateImageBehavior = false;
            this.onlinePCList.View = System.Windows.Forms.View.Details;
            // 
            // Form_SendServerFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.savePathLabel);
            this.Controls.Add(this.fileNotificationLabel);
            this.Controls.Add(this.notificationPanel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.sendFileButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.onlinePCList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_SendServerFiles";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form_SendServerFiles_Load);
            this.notificationPanel.ResumeLayout(false);
            this.notificationPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notificationTempLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.Label fileNotificationLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel notificationPanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button sendFileButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeSaveLocButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.ListView onlinePCList;

    }
}