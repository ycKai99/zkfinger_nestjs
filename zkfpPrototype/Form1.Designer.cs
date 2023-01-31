﻿using System.Windows.Forms;

namespace zkfpPrototype
{
    partial class Form1
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
            this.btnInit = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnUploadFp = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnConnectDb = new System.Windows.Forms.Button();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.cmbIdx = new System.Windows.Forms.ComboBox();
            this.tabPageFp = new System.Windows.Forms.TabPage();
            this.picFpImg = new System.Windows.Forms.PictureBox();
            this.tabPageDb = new System.Windows.Forms.TabPage();
            this.fpData = new System.Windows.Forms.DataGridView();
            this.fpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fpTemplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_registered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageEmp = new System.Windows.Forms.TabPage();
            this.empData = new System.Windows.Forms.DataGridView();
            this.empId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fpControl = new System.Windows.Forms.TabControl();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.mainControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.tbUserInputId = new System.Windows.Forms.TextBox();
            this.lblUserInput = new System.Windows.Forms.Label();
            this.labelNumOfFp = new System.Windows.Forms.Label();
            this.secondPage = new System.Windows.Forms.TabPage();
            this.cmbDeleteEmp = new System.Windows.Forms.ComboBox();
            this.lblDeleteEmp = new System.Windows.Forms.Label();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.cmbDeleteItem = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDeleteItem = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.dbControl = new System.Windows.Forms.TabControl();
            this.secondMessageBox = new System.Windows.Forms.RichTextBox();
            this.thirdPage = new System.Windows.Forms.TabPage();
            this.btnGetEmployeeData = new System.Windows.Forms.Button();
            this.btnUpdateEmpData = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.devicePage = new System.Windows.Forms.TabPage();
            this.btnDisconnectDevice = new System.Windows.Forms.Button();
            this.btnUploadData = new System.Windows.Forms.Button();
            this.btnDownloadData = new System.Windows.Forms.Button();
            this.btnConnectDevice = new System.Windows.Forms.Button();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.deviceMessageBox = new System.Windows.Forms.RichTextBox();
            this.deviceControl = new System.Windows.Forms.TabControl();
            this.deviceDataPage = new System.Windows.Forms.TabPage();
            this.deviceData = new System.Windows.Forms.DataGridView();
            this.deviceFpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceFpTmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventEmitterPage = new System.Windows.Forms.TabPage();
            this.btnInsertDee = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnConnectDbEmitter = new System.Windows.Forms.Button();
            this.dbEventEmitterControl = new System.Windows.Forms.TabControl();
            this.dbEventEmitter = new System.Windows.Forms.TabPage();
            this.dbEventEmitterData = new System.Windows.Forms.DataGridView();
            this.eventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventSpid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventConn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventProcid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.inputTmp = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPageFp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFpImg)).BeginInit();
            this.tabPageDb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpData)).BeginInit();
            this.tabPageEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empData)).BeginInit();
            this.fpControl.SuspendLayout();
            this.mainControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.secondPage.SuspendLayout();
            this.dbControl.SuspendLayout();
            this.thirdPage.SuspendLayout();
            this.devicePage.SuspendLayout();
            this.deviceControl.SuspendLayout();
            this.deviceDataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceData)).BeginInit();
            this.eventEmitterPage.SuspendLayout();
            this.dbEventEmitterControl.SuspendLayout();
            this.dbEventEmitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEventEmitterData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(22, 40);
            this.btnInit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(100, 40);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "Initialize";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(22, 109);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(221, 109);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.Enabled = false;
            this.btnMatch.Location = new System.Drawing.Point(251, 439);
            this.btnMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(220, 50);
            this.btnMatch.TabIndex = 20;
            this.btnMatch.Text = "Verify";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.BtnMatch_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Enabled = false;
            this.btnVerify.Location = new System.Drawing.Point(329, 443);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(100, 37);
            this.btnVerify.TabIndex = 19;
            this.btnVerify.Text = "Verify(1:N)";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // btnUploadFp
            // 
            this.btnUploadFp.Location = new System.Drawing.Point(0, 0);
            this.btnUploadFp.Name = "btnUploadFp";
            this.btnUploadFp.Size = new System.Drawing.Size(75, 23);
            this.btnUploadFp.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.Location = new System.Drawing.Point(10, 439);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(220, 50);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnConnectDb
            // 
            this.btnConnectDb.Location = new System.Drawing.Point(25, 35);
            this.btnConnectDb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnectDb.Name = "btnConnectDb";
            this.btnConnectDb.Size = new System.Drawing.Size(100, 50);
            this.btnConnectDb.TabIndex = 18;
            this.btnConnectDb.Text = "Connect";
            this.btnConnectDb.UseVisualStyleBackColor = true;
            this.btnConnectDb.Click += new System.EventHandler(this.BtnConnectDb_Click);
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(221, 43);
            this.btnTerminate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(100, 40);
            this.btnTerminate.TabIndex = 0;
            this.btnTerminate.Text = "Terminate";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.BtnTerminate_Click);
            // 
            // cmbIdx
            // 
            this.cmbIdx.FormattingEnabled = true;
            this.cmbIdx.Location = new System.Drawing.Point(142, 115);
            this.cmbIdx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIdx.Name = "cmbIdx";
            this.cmbIdx.Size = new System.Drawing.Size(52, 28);
            this.cmbIdx.TabIndex = 10;
            // 
            // tabPageFp
            // 
            this.tabPageFp.Controls.Add(this.btnMatch);
            this.tabPageFp.Controls.Add(this.btnRegister);
            this.tabPageFp.Controls.Add(this.picFpImg);
            this.tabPageFp.Location = new System.Drawing.Point(4, 29);
            this.tabPageFp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageFp.Name = "tabPageFp";
            this.tabPageFp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageFp.Size = new System.Drawing.Size(479, 499);
            this.tabPageFp.TabIndex = 0;
            this.tabPageFp.Text = "Fingerprint image";
            this.tabPageFp.UseVisualStyleBackColor = true;
            // 
            // picFpImg
            // 
            this.picFpImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picFpImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picFpImg.Location = new System.Drawing.Point(10, 3);
            this.picFpImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFpImg.Name = "picFpImg";
            this.picFpImg.Size = new System.Drawing.Size(461, 430);
            this.picFpImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFpImg.TabIndex = 1;
            this.picFpImg.TabStop = false;
            // 
            // tabPageDb
            // 
            this.tabPageDb.Controls.Add(this.fpData);
            this.tabPageDb.Location = new System.Drawing.Point(4, 29);
            this.tabPageDb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDb.Name = "tabPageDb";
            this.tabPageDb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDb.Size = new System.Drawing.Size(479, 499);
            this.tabPageDb.TabIndex = 0;
            this.tabPageDb.Text = "Fingerprint Data";
            this.tabPageDb.UseVisualStyleBackColor = true;
            // 
            // fpData
            // 
            this.fpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fpData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fpId,
            this.fpTemplate,
            this.time_registered,
            this.empId1});
            this.fpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpData.Location = new System.Drawing.Point(4, 5);
            this.fpData.Name = "fpData";
            this.fpData.RowHeadersWidth = 51;
            this.fpData.Size = new System.Drawing.Size(471, 489);
            this.fpData.TabIndex = 883;
            // 
            // fpId
            // 
            this.fpId.HeaderText = "fpId";
            this.fpId.MinimumWidth = 6;
            this.fpId.Name = "fpId";
            this.fpId.Width = 50;
            // 
            // fpTemplate
            // 
            this.fpTemplate.HeaderText = "fpTemplate";
            this.fpTemplate.MinimumWidth = 6;
            this.fpTemplate.Name = "fpTemplate";
            this.fpTemplate.Width = 250;
            // 
            // time_registered
            // 
            this.time_registered.HeaderText = "timeRegister";
            this.time_registered.MinimumWidth = 6;
            this.time_registered.Name = "time_registered";
            this.time_registered.Width = 125;
            // 
            // empId1
            // 
            this.empId1.HeaderText = "Emp_Id";
            this.empId1.MinimumWidth = 6;
            this.empId1.Name = "empId1";
            this.empId1.Width = 150;
            // 
            // tabPageEmp
            // 
            this.tabPageEmp.Controls.Add(this.empData);
            this.tabPageEmp.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageEmp.Name = "tabPageEmp";
            this.tabPageEmp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageEmp.Size = new System.Drawing.Size(479, 499);
            this.tabPageEmp.TabIndex = 0;
            this.tabPageEmp.Text = "Employee Data";
            this.tabPageEmp.UseVisualStyleBackColor = true;
            // 
            // empData
            // 
            this.empData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empId,
            this.empName});
            this.empData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empData.Location = new System.Drawing.Point(4, 5);
            this.empData.Name = "empData";
            this.empData.RowHeadersWidth = 51;
            this.empData.Size = new System.Drawing.Size(471, 489);
            this.empData.TabIndex = 883;
            // 
            // empId
            // 
            this.empId.HeaderText = "Emp_Id";
            this.empId.MinimumWidth = 6;
            this.empId.Name = "empId";
            this.empId.Width = 150;
            // 
            // empName
            // 
            this.empName.HeaderText = "Emp_Name";
            this.empName.MinimumWidth = 6;
            this.empName.Name = "empName";
            this.empName.Width = 150;
            // 
            // fpControl
            // 
            this.fpControl.Controls.Add(this.tabPageFp);
            this.fpControl.Location = new System.Drawing.Point(613, 7);
            this.fpControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fpControl.Name = "fpControl";
            this.fpControl.SelectedIndex = 0;
            this.fpControl.Size = new System.Drawing.Size(487, 532);
            this.fpControl.TabIndex = 16;
            this.fpControl.Tag = "F";
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.Location = new System.Drawing.Point(-3, 226);
            this.messageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(612, 327);
            this.messageBox.TabIndex = 17;
            this.messageBox.Text = "Please plugin your reader and initialize your reader first.";
            this.messageBox.TextChanged += new System.EventHandler(this.MessageBox_TextChanged);
            // 
            // mainControl
            // 
            this.mainControl.Controls.Add(this.mainPage);
            this.mainControl.Controls.Add(this.secondPage);
            this.mainControl.Controls.Add(this.thirdPage);
            this.mainControl.Controls.Add(this.devicePage);
            this.mainControl.Controls.Add(this.eventEmitterPage);
            this.mainControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainControl.Location = new System.Drawing.Point(-3, 2);
            this.mainControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainControl.Name = "mainControl";
            this.mainControl.SelectedIndex = 0;
            this.mainControl.Size = new System.Drawing.Size(1103, 593);
            this.mainControl.TabIndex = 16;
            this.mainControl.Tag = "M";
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.tbUserInputId);
            this.mainPage.Controls.Add(this.lblUserInput);
            this.mainPage.Controls.Add(this.btnInit);
            this.mainPage.Controls.Add(this.btnTerminate);
            this.mainPage.Controls.Add(this.btnOpen);
            this.mainPage.Controls.Add(this.btnClose);
            this.mainPage.Controls.Add(this.fpControl);
            this.mainPage.Controls.Add(this.cmbIdx);
            this.mainPage.Controls.Add(this.messageBox);
            this.mainPage.Controls.Add(this.labelNumOfFp);
            this.mainPage.Location = new System.Drawing.Point(4, 29);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(1095, 560);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Fingerprint";
            // 
            // tbUserInputId
            // 
            this.tbUserInputId.Location = new System.Drawing.Point(507, 115);
            this.tbUserInputId.Name = "tbUserInputId";
            this.tbUserInputId.Size = new System.Drawing.Size(51, 27);
            this.tbUserInputId.TabIndex = 19;
            // 
            // lblUserInput
            // 
            this.lblUserInput.AutoSize = true;
            this.lblUserInput.Location = new System.Drawing.Point(347, 118);
            this.lblUserInput.Name = "lblUserInput";
            this.lblUserInput.Size = new System.Drawing.Size(197, 20);
            this.lblUserInput.TabIndex = 18;
            this.lblUserInput.Text = "Register fingerprint for ID = ";
            // 
            // labelNumOfFp
            // 
            this.labelNumOfFp.AutoSize = true;
            this.labelNumOfFp.Location = new System.Drawing.Point(347, 43);
            this.labelNumOfFp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumOfFp.Name = "labelNumOfFp";
            this.labelNumOfFp.Size = new System.Drawing.Size(241, 20);
            this.labelNumOfFp.TabIndex = 9;
            this.labelNumOfFp.Text = "Number of fingerprint registered: 0";
            // 
            // secondPage
            // 
            this.secondPage.Controls.Add(this.cmbDeleteEmp);
            this.secondPage.Controls.Add(this.lblDeleteEmp);
            this.secondPage.Controls.Add(this.btnDeleteEmp);
            this.secondPage.Controls.Add(this.cmbDeleteItem);
            this.secondPage.Controls.Add(this.btnDelete);
            this.secondPage.Controls.Add(this.lblDeleteItem);
            this.secondPage.Controls.Add(this.btnDisconnect);
            this.secondPage.Controls.Add(this.dbControl);
            this.secondPage.Controls.Add(this.btnConnectDb);
            this.secondPage.Controls.Add(this.secondMessageBox);
            this.secondPage.Location = new System.Drawing.Point(4, 29);
            this.secondPage.Name = "secondPage";
            this.secondPage.Size = new System.Drawing.Size(1095, 560);
            this.secondPage.TabIndex = 0;
            this.secondPage.Text = "Local Database";
            // 
            // cmbDeleteEmp
            // 
            this.cmbDeleteEmp.FormattingEnabled = true;
            this.cmbDeleteEmp.Location = new System.Drawing.Point(288, 128);
            this.cmbDeleteEmp.Name = "cmbDeleteEmp";
            this.cmbDeleteEmp.Size = new System.Drawing.Size(76, 28);
            this.cmbDeleteEmp.TabIndex = 32;
            // 
            // lblDeleteEmp
            // 
            this.lblDeleteEmp.AutoSize = true;
            this.lblDeleteEmp.Location = new System.Drawing.Point(188, 131);
            this.lblDeleteEmp.Name = "lblDeleteEmp";
            this.lblDeleteEmp.Size = new System.Drawing.Size(94, 20);
            this.lblDeleteEmp.TabIndex = 31;
            this.lblDeleteEmp.Text = "Employee ID";
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(389, 127);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteEmp.TabIndex = 30;
            this.btnDeleteEmp.Text = "Delete Employee";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.BtnDeleteEmp_Click);
            // 
            // cmbDeleteItem
            // 
            this.cmbDeleteItem.FormattingEnabled = true;
            this.cmbDeleteItem.Location = new System.Drawing.Point(288, 38);
            this.cmbDeleteItem.Name = "cmbDeleteItem";
            this.cmbDeleteItem.Size = new System.Drawing.Size(76, 28);
            this.cmbDeleteItem.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 30);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete Fingerprint Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.AutoSize = true;
            this.lblDeleteItem.Location = new System.Drawing.Point(188, 41);
            this.lblDeleteItem.Name = "lblDeleteItem";
            this.lblDeleteItem.Size = new System.Drawing.Size(94, 20);
            this.lblDeleteItem.TabIndex = 20;
            this.lblDeleteItem.Text = "Employee ID";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(25, 121);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 50);
            this.btnDisconnect.TabIndex = 19;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // dbControl
            // 
            this.dbControl.Controls.Add(this.tabPageDb);
            this.dbControl.Controls.Add(this.tabPageEmp);
            this.dbControl.Location = new System.Drawing.Point(613, 7);
            this.dbControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbControl.Name = "dbControl";
            this.dbControl.SelectedIndex = 0;
            this.dbControl.Size = new System.Drawing.Size(487, 532);
            this.dbControl.TabIndex = 16;
            this.dbControl.Tag = "D";
            // 
            // secondMessageBox
            // 
            this.secondMessageBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondMessageBox.Location = new System.Drawing.Point(-3, 226);
            this.secondMessageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondMessageBox.Name = "secondMessageBox";
            this.secondMessageBox.Size = new System.Drawing.Size(612, 327);
            this.secondMessageBox.TabIndex = 17;
            this.secondMessageBox.Text = "Please connect to your database.";
            this.secondMessageBox.TextChanged += new System.EventHandler(this.SecondMessageBox_TextChanged);
            // 
            // thirdPage
            // 
            this.thirdPage.Controls.Add(this.btnGetEmployeeData);
            this.thirdPage.Controls.Add(this.btnUpdateEmpData);
            this.thirdPage.Controls.Add(this.richTextBox1);
            this.thirdPage.Controls.Add(this.save);
            this.thirdPage.Controls.Add(this.cancel);
            this.thirdPage.Controls.Add(this.lbName);
            this.thirdPage.Controls.Add(this.lbId);
            this.thirdPage.Controls.Add(this.tbName);
            this.thirdPage.Controls.Add(this.tbId);
            this.thirdPage.Location = new System.Drawing.Point(4, 29);
            this.thirdPage.Name = "thirdPage";
            this.thirdPage.Size = new System.Drawing.Size(1095, 560);
            this.thirdPage.TabIndex = 0;
            this.thirdPage.Text = "Employee";
            // 
            // btnGetEmployeeData
            // 
            this.btnGetEmployeeData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetEmployeeData.Location = new System.Drawing.Point(578, 107);
            this.btnGetEmployeeData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetEmployeeData.Name = "btnGetEmployeeData";
            this.btnGetEmployeeData.Size = new System.Drawing.Size(150, 50);
            this.btnGetEmployeeData.TabIndex = 8;
            this.btnGetEmployeeData.Text = "Get Employee Data";
            this.btnGetEmployeeData.UseVisualStyleBackColor = true;
            this.btnGetEmployeeData.Click += new System.EventHandler(this.BtnGetEmployeeData_Click);
            // 
            // btnUpdateEmpData
            // 
            this.btnUpdateEmpData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmpData.Location = new System.Drawing.Point(578, 21);
            this.btnUpdateEmpData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateEmpData.Name = "btnUpdateEmpData";
            this.btnUpdateEmpData.Size = new System.Drawing.Size(150, 50);
            this.btnUpdateEmpData.TabIndex = 7;
            this.btnUpdateEmpData.Text = "Update";
            this.btnUpdateEmpData.UseVisualStyleBackColor = true;
            this.btnUpdateEmpData.Click += new System.EventHandler(this.BtnUpdateEmpData_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 253);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1089, 311);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Please register";
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(380, 21);
            this.save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(150, 50);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(380, 106);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(150, 50);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(62, 112);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(141, 23);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Employee name: ";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(88, 50);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(113, 23);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "Employee Id: ";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(201, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(119, 30);
            this.tbName.TabIndex = 4;
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(201, 47);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(119, 30);
            this.tbId.TabIndex = 5;
            // 
            // devicePage
            // 
            this.devicePage.Controls.Add(this.btnDisconnectDevice);
            this.devicePage.Controls.Add(this.btnUploadData);
            this.devicePage.Controls.Add(this.btnDownloadData);
            this.devicePage.Controls.Add(this.btnConnectDevice);
            this.devicePage.Controls.Add(this.lblIp);
            this.devicePage.Controls.Add(this.lblPort);
            this.devicePage.Controls.Add(this.tbIp);
            this.devicePage.Controls.Add(this.tbPort);
            this.devicePage.Controls.Add(this.deviceMessageBox);
            this.devicePage.Controls.Add(this.deviceControl);
            this.devicePage.Location = new System.Drawing.Point(4, 29);
            this.devicePage.Name = "devicePage";
            this.devicePage.Size = new System.Drawing.Size(1095, 560);
            this.devicePage.TabIndex = 0;
            this.devicePage.Text = "Device WL10";
            // 
            // btnDisconnectDevice
            // 
            this.btnDisconnectDevice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDisconnectDevice.Enabled = false;
            this.btnDisconnectDevice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectDevice.Location = new System.Drawing.Point(720, 3);
            this.btnDisconnectDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisconnectDevice.Name = "btnDisconnectDevice";
            this.btnDisconnectDevice.Size = new System.Drawing.Size(150, 30);
            this.btnDisconnectDevice.TabIndex = 24;
            this.btnDisconnectDevice.Text = "Disconnect";
            this.btnDisconnectDevice.UseVisualStyleBackColor = true;
            this.btnDisconnectDevice.Click += new System.EventHandler(this.BtnDisconnectDevice_Click);
            // 
            // btnUploadData
            // 
            this.btnUploadData.Enabled = false;
            this.btnUploadData.Location = new System.Drawing.Point(200, 75);
            this.btnUploadData.Name = "btnUploadData";
            this.btnUploadData.Size = new System.Drawing.Size(130, 50);
            this.btnUploadData.TabIndex = 23;
            this.btnUploadData.Text = "Upload";
            this.btnUploadData.UseVisualStyleBackColor = true;
            this.btnUploadData.Click += new System.EventHandler(this.BtnUploadData_Click);
            // 
            // btnDownloadData
            // 
            this.btnDownloadData.Enabled = false;
            this.btnDownloadData.Location = new System.Drawing.Point(21, 75);
            this.btnDownloadData.Name = "btnDownloadData";
            this.btnDownloadData.Size = new System.Drawing.Size(130, 50);
            this.btnDownloadData.TabIndex = 21;
            this.btnDownloadData.Text = "Download";
            this.btnDownloadData.UseVisualStyleBackColor = true;
            this.btnDownloadData.Click += new System.EventHandler(this.BtnDownloadData_Click);
            // 
            // btnConnectDevice
            // 
            this.btnConnectDevice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDevice.Location = new System.Drawing.Point(528, 3);
            this.btnConnectDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnectDevice.Name = "btnConnectDevice";
            this.btnConnectDevice.Size = new System.Drawing.Size(150, 30);
            this.btnConnectDevice.TabIndex = 1;
            this.btnConnectDevice.Text = "Connect";
            this.btnConnectDevice.UseVisualStyleBackColor = true;
            this.btnConnectDevice.Click += new System.EventHandler(this.BtnConnectDevice_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(17, 10);
            this.lblIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(79, 20);
            this.lblIp.TabIndex = 9;
            this.lblIp.Text = "Ip Address";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(258, 11);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(93, 20);
            this.lblPort.TabIndex = 9;
            this.lblPort.Text = "Port Number";
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(101, 7);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(144, 27);
            this.tbIp.TabIndex = 20;
            this.tbIp.Text = "192.168.100.37";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(357, 7);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(144, 27);
            this.tbPort.TabIndex = 20;
            this.tbPort.Text = "4370";
            // 
            // deviceMessageBox
            // 
            this.deviceMessageBox.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceMessageBox.Location = new System.Drawing.Point(-3, 226);
            this.deviceMessageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deviceMessageBox.Name = "deviceMessageBox";
            this.deviceMessageBox.Size = new System.Drawing.Size(612, 327);
            this.deviceMessageBox.TabIndex = 17;
            this.deviceMessageBox.Text = "Please connect to your device.";
            this.deviceMessageBox.TextChanged += new System.EventHandler(this.DeviceMessageBox_TextChanged);
            // 
            // deviceControl
            // 
            this.deviceControl.Controls.Add(this.deviceDataPage);
            this.deviceControl.Location = new System.Drawing.Point(616, 41);
            this.deviceControl.Name = "deviceControl";
            this.deviceControl.SelectedIndex = 0;
            this.deviceControl.Size = new System.Drawing.Size(476, 519);
            this.deviceControl.TabIndex = 22;
            // 
            // deviceDataPage
            // 
            this.deviceDataPage.Controls.Add(this.deviceData);
            this.deviceDataPage.Location = new System.Drawing.Point(4, 29);
            this.deviceDataPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deviceDataPage.Name = "deviceDataPage";
            this.deviceDataPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deviceDataPage.Size = new System.Drawing.Size(468, 486);
            this.deviceDataPage.TabIndex = 0;
            this.deviceDataPage.Text = "Device Data";
            this.deviceDataPage.UseVisualStyleBackColor = true;
            // 
            // deviceData
            // 
            this.deviceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceFpId,
            this.deviceFpTmp,
            this.devicEmpId,
            this.DeviceUserName});
            this.deviceData.Location = new System.Drawing.Point(7, 0);
            this.deviceData.Name = "deviceData";
            this.deviceData.RowHeadersWidth = 51;
            this.deviceData.RowTemplate.Height = 24;
            this.deviceData.Size = new System.Drawing.Size(461, 483);
            this.deviceData.TabIndex = 22;
            // 
            // deviceFpId
            // 
            this.deviceFpId.HeaderText = "Fp_Id";
            this.deviceFpId.MinimumWidth = 6;
            this.deviceFpId.Name = "deviceFpId";
            this.deviceFpId.Width = 50;
            // 
            // deviceFpTmp
            // 
            this.deviceFpTmp.HeaderText = "Fp_Template";
            this.deviceFpTmp.MinimumWidth = 6;
            this.deviceFpTmp.Name = "deviceFpTmp";
            this.deviceFpTmp.Width = 250;
            // 
            // devicEmpId
            // 
            this.devicEmpId.HeaderText = "Emp_Id";
            this.devicEmpId.MinimumWidth = 6;
            this.devicEmpId.Name = "devicEmpId";
            this.devicEmpId.Width = 125;
            // 
            // DeviceUserName
            // 
            this.DeviceUserName.HeaderText = "Name";
            this.DeviceUserName.MinimumWidth = 6;
            this.DeviceUserName.Name = "DeviceUserName";
            this.DeviceUserName.Width = 125;
            // 
            // eventEmitterPage
            // 
            this.eventEmitterPage.Controls.Add(this.btnInsertDee);
            this.eventEmitterPage.Controls.Add(this.richTextBox2);
            this.eventEmitterPage.Controls.Add(this.btnConnectDbEmitter);
            this.eventEmitterPage.Controls.Add(this.dbEventEmitterControl);
            this.eventEmitterPage.Location = new System.Drawing.Point(4, 29);
            this.eventEmitterPage.Name = "eventEmitterPage";
            this.eventEmitterPage.Padding = new System.Windows.Forms.Padding(3);
            this.eventEmitterPage.Size = new System.Drawing.Size(1095, 560);
            this.eventEmitterPage.TabIndex = 1;
            this.eventEmitterPage.Text = "DEE";
            this.eventEmitterPage.UseVisualStyleBackColor = true;
            // 
            // btnInsertDee
            // 
            this.btnInsertDee.Location = new System.Drawing.Point(43, 112);
            this.btnInsertDee.Name = "btnInsertDee";
            this.btnInsertDee.Size = new System.Drawing.Size(150, 40);
            this.btnInsertDee.TabIndex = 23;
            this.btnInsertDee.Text = "Insert";
            this.btnInsertDee.UseVisualStyleBackColor = true;
            this.btnInsertDee.Click += new System.EventHandler(this.BtnInsertDee_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(264, 6);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(821, 227);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Test Connection Database Event Emitter";
            this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
            // 
            // btnConnectDbEmitter
            // 
            this.btnConnectDbEmitter.Location = new System.Drawing.Point(43, 28);
            this.btnConnectDbEmitter.Name = "btnConnectDbEmitter";
            this.btnConnectDbEmitter.Size = new System.Drawing.Size(150, 40);
            this.btnConnectDbEmitter.TabIndex = 1;
            this.btnConnectDbEmitter.Text = "Connect";
            this.btnConnectDbEmitter.UseVisualStyleBackColor = true;
            this.btnConnectDbEmitter.Click += new System.EventHandler(this.BtnConnectDbEmitter_Click);
            // 
            // dbEventEmitterControl
            // 
            this.dbEventEmitterControl.Controls.Add(this.dbEventEmitter);
            this.dbEventEmitterControl.Location = new System.Drawing.Point(6, 226);
            this.dbEventEmitterControl.Name = "dbEventEmitterControl";
            this.dbEventEmitterControl.SelectedIndex = 0;
            this.dbEventEmitterControl.Size = new System.Drawing.Size(1083, 328);
            this.dbEventEmitterControl.TabIndex = 22;
            // 
            // dbEventEmitter
            // 
            this.dbEventEmitter.Controls.Add(this.dbEventEmitterData);
            this.dbEventEmitter.Location = new System.Drawing.Point(4, 29);
            this.dbEventEmitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbEventEmitter.Name = "dbEventEmitter";
            this.dbEventEmitter.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbEventEmitter.Size = new System.Drawing.Size(1075, 295);
            this.dbEventEmitter.TabIndex = 0;
            this.dbEventEmitter.Text = "Database Event Emitter";
            this.dbEventEmitter.UseVisualStyleBackColor = true;
            // 
            // dbEventEmitterData
            // 
            this.dbEventEmitterData.BackgroundColor = System.Drawing.Color.Azure;
            this.dbEventEmitterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbEventEmitterData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventId,
            this.eventDesc,
            this.eventDate,
            this.eventAction,
            this.eventSpid,
            this.eventConn,
            this.eventProcid,
            this.eventSource});
            this.dbEventEmitterData.Location = new System.Drawing.Point(7, 8);
            this.dbEventEmitterData.Name = "dbEventEmitterData";
            this.dbEventEmitterData.RowHeadersWidth = 151;
            this.dbEventEmitterData.RowTemplate.Height = 24;
            this.dbEventEmitterData.Size = new System.Drawing.Size(1061, 279);
            this.dbEventEmitterData.TabIndex = 22;
            // 
            // eventId
            // 
            this.eventId.HeaderText = "Event_Id";
            this.eventId.MinimumWidth = 6;
            this.eventId.Name = "eventId";
            this.eventId.Width = 50;
            // 
            // eventDesc
            // 
            this.eventDesc.HeaderText = "Event_Description";
            this.eventDesc.MinimumWidth = 6;
            this.eventDesc.Name = "eventDesc";
            this.eventDesc.Width = 400;
            // 
            // eventDate
            // 
            this.eventDate.HeaderText = "Event_Date";
            this.eventDate.MinimumWidth = 6;
            this.eventDate.Name = "eventDate";
            this.eventDate.Width = 50;
            // 
            // eventAction
            // 
            this.eventAction.HeaderText = "Event_Action";
            this.eventAction.MinimumWidth = 6;
            this.eventAction.Name = "eventAction";
            this.eventAction.Width = 50;
            // 
            // eventSpid
            // 
            this.eventSpid.HeaderText = "Event_Spid";
            this.eventSpid.MinimumWidth = 6;
            this.eventSpid.Name = "eventSpid";
            this.eventSpid.Width = 50;
            // 
            // eventConn
            // 
            this.eventConn.HeaderText = "Event_Connection";
            this.eventConn.MinimumWidth = 6;
            this.eventConn.Name = "eventConn";
            this.eventConn.Width = 50;
            // 
            // eventProcid
            // 
            this.eventProcid.HeaderText = "Event_Procid";
            this.eventProcid.MinimumWidth = 6;
            this.eventProcid.Name = "eventProcid";
            this.eventProcid.Width = 50;
            // 
            // eventSource
            // 
            this.eventSource.HeaderText = "Event_Source";
            this.eventSource.MinimumWidth = 6;
            this.eventSource.Name = "eventSource";
            this.eventSource.Width = 80;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(410, 115);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(144, 22);
            this.inputName.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(347, 118);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // inputTmp
            // 
            this.inputTmp.Location = new System.Drawing.Point(81, 179);
            this.inputTmp.Name = "inputTmp";
            this.inputTmp.Size = new System.Drawing.Size(100, 22);
            this.inputTmp.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1113, 597);
            this.Controls.Add(this.mainControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(615, 496);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# zkfinger prototype";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageFp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFpImg)).EndInit();
            this.tabPageDb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpData)).EndInit();
            this.tabPageEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empData)).EndInit();
            this.fpControl.ResumeLayout(false);
            this.mainControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.secondPage.ResumeLayout(false);
            this.secondPage.PerformLayout();
            this.dbControl.ResumeLayout(false);
            this.thirdPage.ResumeLayout(false);
            this.thirdPage.PerformLayout();
            this.devicePage.ResumeLayout(false);
            this.devicePage.PerformLayout();
            this.deviceControl.ResumeLayout(false);
            this.deviceDataPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceData)).EndInit();
            this.eventEmitterPage.ResumeLayout(false);
            this.dbEventEmitterControl.ResumeLayout(false);
            this.dbEventEmitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbEventEmitterData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnInit;
        private Button btnTerminate;
        private Button btnOpen;
        private Button btnClose;
        private Button btnVerify;
        private Button btnMatch;
        private Button btnRegister;
        private Button btnConnectDb;
        private Button btnUploadFp;
        private TabControl fpControl;
        private TabControl mainControl;
        private TabControl dbControl;
        private TabPage tabPageFp;
        private TabPage tabPageDb;
        private TabPage mainPage;
        private TabPage secondPage;
        private TabPage tabPageEmp;
        private PictureBox picFpImg;
        private ComboBox cmbIdx;
        public RichTextBox messageBox;
        public RichTextBox secondMessageBox;
        private DataGridView fpData;
        private DataGridViewTextBoxColumn fpTemplate;
        private DataGridViewTextBoxColumn fpId;
        private DataGridViewTextBoxColumn timeRegister;
        private DataGridViewTextBoxColumn empId1;
        private DataGridView empData;
        private DataGridViewTextBoxColumn empId;
        private DataGridViewTextBoxColumn empName;
        private TextBox inputTmp;
        private TextBox inputName;
        private Button btnDisconnect;
        private Label lblName;
        private Label labelNumOfFp;
        private Label lblDeleteItem;
        private Button btnDelete;
        private DataGridViewTextBoxColumn time_registered;
        private TabPage thirdPage;
        private Button save;
        private Button cancel;
        private Label lbName;
        private Label lbId;
        private TextBox tbName;
        private TextBox tbId;
        private TextBox tbUserInputId;
        private Label lblUserInput;
        private TabPage devicePage;
        private Button btnConnectDevice;
        private Label lblIp;
        private Label lblPort;
        private TextBox tbIp;
        private TextBox tbPort;
        private Button btnDownloadData;
        private DataGridView deviceData;
        private DataGridViewTextBoxColumn deviceEmpId;
        private DataGridViewTextBoxColumn deviceFpId;
        private DataGridViewTextBoxColumn deviceFpTmp;
        private TabControl deviceControl;
        private RichTextBox deviceMessageBox;
        private TabPage deviceDataPage;
        private DataGridViewTextBoxColumn devicEmpId;
        private Button btnUploadData;
        private Button btnDisconnectDevice;
        private RichTextBox richTextBox1;
        private Timer timer1;
        private DataGridViewTextBoxColumn DeviceUserName;
        private ComboBox cmbDeleteItem;
        private Button btnDeleteEmp;
        private ComboBox cmbDeleteEmp;
        private Label lblDeleteEmp;
        private Button btnUpdateEmpData;
        private Button btnGetEmployeeData;
        private TabPage eventEmitterPage;
        private RichTextBox richTextBox2;
        private Button btnConnectDbEmitter;
        private TabPage dbEventEmitter;
        private TabControl dbEventEmitterControl;
        private DataGridView dbEventEmitterData;
        private DataGridViewTextBoxColumn eventId;
        private DataGridViewTextBoxColumn eventDesc;
        private DataGridViewTextBoxColumn eventDate;
        private DataGridViewTextBoxColumn eventAction;
        private DataGridViewTextBoxColumn eventSpid;
        private DataGridViewTextBoxColumn eventConn;
        private DataGridViewTextBoxColumn eventProcid;
        private DataGridViewTextBoxColumn eventSource;
        private Button btnInsertDee;
    }
}

