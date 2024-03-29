﻿namespace WindowsFormsApp1
{
    partial class PatientDetail
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
            this.next = new System.Windows.Forms.Button();
            this.chartNol = new System.Windows.Forms.Label();
            this.patientIdl = new System.Windows.Forms.Label();
            this.heightl = new System.Windows.Forms.Label();
            this.weightl = new System.Windows.Forms.Label();
            this.namel = new System.Windows.Forms.Label();
            this.bloodl = new System.Windows.Forms.Label();
            this.historyl = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.birthdayl = new System.Windows.Forms.Label();
            this.revert = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.chartNo = new System.Windows.Forms.Label();
            this.patientId = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.FlowLayoutPanel();
            this.data = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.name2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.blood2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.date2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.historyComment = new System.Windows.Forms.Button();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.newComment = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button.SuspendLayout();
            this.data.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.next.Location = new System.Drawing.Point(420, 30);
            this.next.Margin = new System.Windows.Forms.Padding(10, 30, 0, 30);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(110, 50);
            this.next.TabIndex = 0;
            this.next.Text = "下一步";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // chartNol
            // 
            this.chartNol.AutoSize = true;
            this.chartNol.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartNol.Location = new System.Drawing.Point(6, 5);
            this.chartNol.Margin = new System.Windows.Forms.Padding(6, 5, 3, 5);
            this.chartNol.Name = "chartNol";
            this.chartNol.Size = new System.Drawing.Size(123, 35);
            this.chartNol.TabIndex = 1;
            this.chartNol.Text = "病歷號：";
            // 
            // patientIdl
            // 
            this.patientIdl.AutoSize = true;
            this.patientIdl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdl.Location = new System.Drawing.Point(6, 5);
            this.patientIdl.Margin = new System.Windows.Forms.Padding(6, 5, 3, 5);
            this.patientIdl.Name = "patientIdl";
            this.patientIdl.Size = new System.Drawing.Size(231, 35);
            this.patientIdl.TabIndex = 2;
            this.patientIdl.Text = "病患身份證字號：";
            // 
            // heightl
            // 
            this.heightl.AutoSize = true;
            this.heightl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.heightl.Location = new System.Drawing.Point(3, 3);
            this.heightl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.heightl.Name = "heightl";
            this.heightl.Size = new System.Drawing.Size(117, 26);
            this.heightl.TabIndex = 3;
            this.heightl.Text = "病患身高：";
            // 
            // weightl
            // 
            this.weightl.AutoSize = true;
            this.weightl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.weightl.Location = new System.Drawing.Point(3, 3);
            this.weightl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.weightl.Name = "weightl";
            this.weightl.Size = new System.Drawing.Size(117, 26);
            this.weightl.TabIndex = 4;
            this.weightl.Text = "病患體重：";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.namel.Location = new System.Drawing.Point(3, 3);
            this.namel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(117, 26);
            this.namel.TabIndex = 5;
            this.namel.Text = "病患姓名：";
            // 
            // bloodl
            // 
            this.bloodl.AutoSize = true;
            this.bloodl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bloodl.Location = new System.Drawing.Point(3, 3);
            this.bloodl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.bloodl.Name = "bloodl";
            this.bloodl.Size = new System.Drawing.Size(117, 26);
            this.bloodl.TabIndex = 6;
            this.bloodl.Text = "病患血型：";
            // 
            // historyl
            // 
            this.historyl.AutoSize = true;
            this.historyl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.historyl.Location = new System.Drawing.Point(3, 0);
            this.historyl.Name = "historyl";
            this.historyl.Size = new System.Drawing.Size(159, 26);
            this.historyl.TabIndex = 7;
            this.historyl.Text = "病患醫療記錄：";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(0, 30);
            this.back.Margin = new System.Windows.Forms.Padding(0, 30, 20, 30);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 50);
            this.back.TabIndex = 8;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // birthdayl
            // 
            this.birthdayl.AutoSize = true;
            this.birthdayl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.birthdayl.Location = new System.Drawing.Point(6, 3);
            this.birthdayl.Margin = new System.Windows.Forms.Padding(6, 3, 3, 0);
            this.birthdayl.Name = "birthdayl";
            this.birthdayl.Size = new System.Drawing.Size(159, 26);
            this.birthdayl.TabIndex = 16;
            this.birthdayl.Text = "病患出生日期：";
            // 
            // revert
            // 
            this.revert.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.revert.Location = new System.Drawing.Point(140, 30);
            this.revert.Margin = new System.Windows.Forms.Padding(10, 30, 20, 30);
            this.revert.Name = "revert";
            this.revert.Size = new System.Drawing.Size(110, 50);
            this.revert.TabIndex = 18;
            this.revert.Text = "复原";
            this.revert.UseVisualStyleBackColor = true;
            this.revert.Click += new System.EventHandler(this.revert_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.save.Location = new System.Drawing.Point(280, 30);
            this.save.Margin = new System.Windows.Forms.Padding(10, 30, 20, 30);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 50);
            this.save.TabIndex = 19;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.weight.Location = new System.Drawing.Point(126, 3);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 34);
            this.weight.TabIndex = 25;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_KeyPress);
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.height.Location = new System.Drawing.Point(126, 3);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 34);
            this.height.TabIndex = 26;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            // 
            // chartNo
            // 
            this.chartNo.AutoSize = true;
            this.chartNo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartNo.Location = new System.Drawing.Point(135, 5);
            this.chartNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.chartNo.Name = "chartNo";
            this.chartNo.Size = new System.Drawing.Size(92, 35);
            this.chartNo.TabIndex = 29;
            this.chartNo.Text = "label1";
            // 
            // patientId
            // 
            this.patientId.AutoSize = true;
            this.patientId.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientId.Location = new System.Drawing.Point(243, 5);
            this.patientId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(92, 35);
            this.patientId.TabIndex = 30;
            this.patientId.Text = "label2";
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button.AutoSize = true;
            this.button.Controls.Add(this.back);
            this.button.Controls.Add(this.revert);
            this.button.Controls.Add(this.save);
            this.button.Controls.Add(this.next);
            this.button.Location = new System.Drawing.Point(4, 508);
            this.button.Margin = new System.Windows.Forms.Padding(0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(530, 110);
            this.button.TabIndex = 31;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.data.Controls.Add(this.flowLayoutPanel2);
            this.data.Controls.Add(this.flowLayoutPanel4);
            this.data.Controls.Add(this.flowLayoutPanel5);
            this.data.Controls.Add(this.flowLayoutPanel10);
            this.data.Controls.Add(this.flowLayoutPanel12);
            this.data.Controls.Add(this.flowLayoutPanel11);
            this.data.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.data.Location = new System.Drawing.Point(3, 3);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(533, 502);
            this.data.TabIndex = 33;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.chartNol);
            this.flowLayoutPanel2.Controls.Add(this.chartNo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(230, 45);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.patientIdl);
            this.flowLayoutPanel4.Controls.Add(this.patientId);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 54);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(338, 45);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 107);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(235, 184);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.namel);
            this.flowLayoutPanel6.Controls.Add(this.name2);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(229, 40);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // name2
            // 
            this.name2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2.Location = new System.Drawing.Point(126, 3);
            this.name2.Margin = new System.Windows.Forms.Padding(3);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(100, 34);
            this.name2.TabIndex = 23;
            this.name2.Text = "label1";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.Controls.Add(this.bloodl);
            this.flowLayoutPanel7.Controls.Add(this.blood2);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 49);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(229, 40);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // blood2
            // 
            this.blood2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blood2.Location = new System.Drawing.Point(126, 3);
            this.blood2.Margin = new System.Windows.Forms.Padding(3);
            this.blood2.Name = "blood2";
            this.blood2.Size = new System.Drawing.Size(100, 34);
            this.blood2.TabIndex = 24;
            this.blood2.Text = "label2";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.Controls.Add(this.heightl);
            this.flowLayoutPanel8.Controls.Add(this.height);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 95);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(229, 40);
            this.flowLayoutPanel8.TabIndex = 2;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel9.Controls.Add(this.weightl);
            this.flowLayoutPanel9.Controls.Add(this.weight);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 141);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(229, 40);
            this.flowLayoutPanel9.TabIndex = 3;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.AutoSize = true;
            this.flowLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel10.Controls.Add(this.birthdayl);
            this.flowLayoutPanel10.Controls.Add(this.date2);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 294);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(258, 43);
            this.flowLayoutPanel10.TabIndex = 3;
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Location = new System.Drawing.Point(171, 3);
            this.date2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(84, 30);
            this.date2.TabIndex = 29;
            this.date2.Text = "label3";
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel12.AutoSize = true;
            this.flowLayoutPanel12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel12.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanel12.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(3, 343);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(527, 38);
            this.flowLayoutPanel12.TabIndex = 5;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.AutoScroll = true;
            this.flowLayoutPanel13.AutoSize = true;
            this.flowLayoutPanel13.Controls.Add(this.historyl);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(165, 26);
            this.flowLayoutPanel13.TabIndex = 0;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel14.Controls.Add(this.historyComment);
            this.flowLayoutPanel14.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel14.Location = new System.Drawing.Point(174, 3);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(350, 32);
            this.flowLayoutPanel14.TabIndex = 1;
            // 
            // historyComment
            // 
            this.historyComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyComment.AutoSize = true;
            this.historyComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.historyComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyComment.Location = new System.Drawing.Point(209, 3);
            this.historyComment.Name = "historyComment";
            this.historyComment.Size = new System.Drawing.Size(138, 26);
            this.historyComment.TabIndex = 28;
            this.historyComment.Text = "查看歷史醫療記錄";
            this.historyComment.UseVisualStyleBackColor = true;
            this.historyComment.Click += new System.EventHandler(this.HistoryComment_Click);
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.AutoSize = true;
            this.flowLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel11.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel11.Controls.Add(this.newComment);
            this.flowLayoutPanel11.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(3, 387);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(527, 112);
            this.flowLayoutPanel11.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(521, 0);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // newComment
            // 
            this.newComment.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.newComment.Location = new System.Drawing.Point(3, 9);
            this.newComment.Multiline = true;
            this.newComment.Name = "newComment";
            this.newComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newComment.Size = new System.Drawing.Size(521, 100);
            this.newComment.TabIndex = 27;
            this.newComment.TextChanged += new System.EventHandler(this.history_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.data);
            this.flowLayoutPanel1.Controls.Add(this.button);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 50);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(539, 618);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // PatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(654, 716);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PatientDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientDetail";
            this.button.ResumeLayout(false);
            this.data.ResumeLayout(false);
            this.data.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chartNol;
        private System.Windows.Forms.Label patientIdl;
        private System.Windows.Forms.Label heightl;
        private System.Windows.Forms.Label weightl;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label bloodl;
        private System.Windows.Forms.Label historyl;
        private System.Windows.Forms.Label birthdayl;

        private System.Windows.Forms.Label chartNo;
        private System.Windows.Forms.Label patientId;

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button revert;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.FlowLayoutPanel button;
        private System.Windows.Forms.FlowLayoutPanel data;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label blood2;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.Button historyComment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox newComment;
    }
}
