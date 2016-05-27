﻿namespace recTimer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdRecFolder = new System.Windows.Forms.Button();
            this.cmdEinstellungen = new System.Windows.Forms.Button();
            this.cmdSoftwareStarten = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTimerSS = new System.Windows.Forms.Label();
            this.lbTimerMM = new System.Windows.Forms.Label();
            this.lbRecInfo = new System.Windows.Forms.Label();
            this.lbTimerHH = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picbDisks = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRecTimeLeft = new System.Windows.Forms.Label();
            this.lbSpace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDatenträger1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picbRAMload = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.picbCPUload = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbRam = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCpu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.timerCPU = new System.Windows.Forms.Timer(this.components);
            this.pcCPU = new System.Diagnostics.PerformanceCounter();
            this.pcRAM = new System.Diagnostics.PerformanceCounter();
            this.timerKeyboardHook = new System.Windows.Forms.Timer(this.components);
            this.lbVersion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbGlobalSS = new System.Windows.Forms.ListBox();
            this.btPrPro = new System.Windows.Forms.Button();
            this.btSaveMarks = new System.Windows.Forms.Button();
            this.btResetMarks = new System.Windows.Forms.Button();
            this.listMarker = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbUpdateWarn = new System.Windows.Forms.LinkLabel();
            this.pcHDD = new System.Diagnostics.PerformanceCounter();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.timerSS = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbDisks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbRAMload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCPUload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcHDD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdRecFolder);
            this.panel1.Controls.Add(this.cmdEinstellungen);
            this.panel1.Controls.Add(this.cmdSoftwareStarten);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 40);
            this.panel1.TabIndex = 0;
            // 
            // cmdRecFolder
            // 
            this.cmdRecFolder.Location = new System.Drawing.Point(107, 6);
            this.cmdRecFolder.Name = "cmdRecFolder";
            this.cmdRecFolder.Size = new System.Drawing.Size(94, 25);
            this.cmdRecFolder.TabIndex = 2;
            this.cmdRecFolder.Text = "Aufnahmeordner";
            this.cmdRecFolder.UseVisualStyleBackColor = true;
            this.cmdRecFolder.Click += new System.EventHandler(this.cmdRecFolder_Click);
            // 
            // cmdEinstellungen
            // 
            this.cmdEinstellungen.Location = new System.Drawing.Point(207, 6);
            this.cmdEinstellungen.Name = "cmdEinstellungen";
            this.cmdEinstellungen.Size = new System.Drawing.Size(93, 25);
            this.cmdEinstellungen.TabIndex = 1;
            this.cmdEinstellungen.Text = "Einstellungen";
            this.cmdEinstellungen.UseVisualStyleBackColor = true;
            this.cmdEinstellungen.Click += new System.EventHandler(this.cmdEinstellungen_Click);
            // 
            // cmdSoftwareStarten
            // 
            this.cmdSoftwareStarten.Location = new System.Drawing.Point(7, 6);
            this.cmdSoftwareStarten.Name = "cmdSoftwareStarten";
            this.cmdSoftwareStarten.Size = new System.Drawing.Size(94, 25);
            this.cmdSoftwareStarten.TabIndex = 0;
            this.cmdSoftwareStarten.Text = "Software starten";
            this.cmdSoftwareStarten.UseVisualStyleBackColor = true;
            this.cmdSoftwareStarten.Click += new System.EventHandler(this.cmdSoftwareStarten_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btReset);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbTimerSS);
            this.panel2.Controls.Add(this.lbTimerMM);
            this.panel2.Controls.Add(this.lbRecInfo);
            this.panel2.Controls.Add(this.lbTimerHH);
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 115);
            this.panel2.TabIndex = 2;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(101, 86);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(109, 23);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "Reset Timer";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // lbTimerSS
            // 
            this.lbTimerSS.AutoSize = true;
            this.lbTimerSS.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimerSS.Location = new System.Drawing.Point(199, 25);
            this.lbTimerSS.Name = "lbTimerSS";
            this.lbTimerSS.Size = new System.Drawing.Size(91, 58);
            this.lbTimerSS.TabIndex = 3;
            this.lbTimerSS.Text = "00";
            // 
            // lbTimerMM
            // 
            this.lbTimerMM.AutoSize = true;
            this.lbTimerMM.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimerMM.Location = new System.Drawing.Point(109, 25);
            this.lbTimerMM.Name = "lbTimerMM";
            this.lbTimerMM.Size = new System.Drawing.Size(91, 58);
            this.lbTimerMM.TabIndex = 2;
            this.lbTimerMM.Text = "00";
            // 
            // lbRecInfo
            // 
            this.lbRecInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecInfo.ForeColor = System.Drawing.Color.Red;
            this.lbRecInfo.Location = new System.Drawing.Point(3, 2);
            this.lbRecInfo.Name = "lbRecInfo";
            this.lbRecInfo.Size = new System.Drawing.Size(304, 23);
            this.lbRecInfo.TabIndex = 1;
            this.lbRecInfo.Text = "Aufnahme gestoppt";
            this.lbRecInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimerHH
            // 
            this.lbTimerHH.AutoSize = true;
            this.lbTimerHH.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimerHH.Location = new System.Drawing.Point(12, 25);
            this.lbTimerHH.Name = "lbTimerHH";
            this.lbTimerHH.Size = new System.Drawing.Size(91, 58);
            this.lbTimerHH.TabIndex = 0;
            this.lbTimerHH.Text = "00";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picbDisks);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbRecTimeLeft);
            this.panel3.Controls.Add(this.lbSpace);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbDatenträger1);
            this.panel3.Location = new System.Drawing.Point(3, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 67);
            this.panel3.TabIndex = 3;
            // 
            // picbDisks
            // 
            this.picbDisks.Image = ((System.Drawing.Image)(resources.GetObject("picbDisks.Image")));
            this.picbDisks.Location = new System.Drawing.Point(58, 24);
            this.picbDisks.Name = "picbDisks";
            this.picbDisks.Size = new System.Drawing.Size(14, 22);
            this.picbDisks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbDisks.TabIndex = 18;
            this.picbDisks.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(59, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lbRecTimeLeft
            // 
            this.lbRecTimeLeft.AutoSize = true;
            this.lbRecTimeLeft.Location = new System.Drawing.Point(181, 50);
            this.lbRecTimeLeft.Name = "lbRecTimeLeft";
            this.lbRecTimeLeft.Size = new System.Drawing.Size(0, 13);
            this.lbRecTimeLeft.TabIndex = 15;
            // 
            // lbSpace
            // 
            this.lbSpace.AutoSize = true;
            this.lbSpace.Location = new System.Drawing.Point(91, 50);
            this.lbSpace.Name = "lbSpace";
            this.lbSpace.Size = new System.Drawing.Size(13, 13);
            this.lbSpace.TabIndex = 8;
            this.lbSpace.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Frei: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(137, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // lbDatenträger1
            // 
            this.lbDatenträger1.AutoSize = true;
            this.lbDatenträger1.Location = new System.Drawing.Point(55, 8);
            this.lbDatenträger1.Name = "lbDatenträger1";
            this.lbDatenträger1.Size = new System.Drawing.Size(138, 13);
            this.lbDatenträger1.TabIndex = 4;
            this.lbDatenträger1.Text = "Kein Datenträger gefunden!";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.picbRAMload);
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Controls.Add(this.picbCPUload);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.lbRam);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.lbCpu);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 237);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 78);
            this.panel5.TabIndex = 9;
            // 
            // picbRAMload
            // 
            this.picbRAMload.Image = ((System.Drawing.Image)(resources.GetObject("picbRAMload.Image")));
            this.picbRAMload.Location = new System.Drawing.Point(106, 39);
            this.picbRAMload.Name = "picbRAMload";
            this.picbRAMload.Size = new System.Drawing.Size(10, 22);
            this.picbRAMload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbRAMload.TabIndex = 22;
            this.picbRAMload.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(107, 39);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(151, 22);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // picbCPUload
            // 
            this.picbCPUload.Image = ((System.Drawing.Image)(resources.GetObject("picbCPUload.Image")));
            this.picbCPUload.Location = new System.Drawing.Point(106, 11);
            this.picbCPUload.Name = "picbCPUload";
            this.picbCPUload.Size = new System.Drawing.Size(10, 22);
            this.picbCPUload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbCPUload.TabIndex = 20;
            this.picbCPUload.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(107, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(151, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // lbRam
            // 
            this.lbRam.AutoSize = true;
            this.lbRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRam.Location = new System.Drawing.Point(264, 41);
            this.lbRam.Name = "lbRam";
            this.lbRam.Size = new System.Drawing.Size(36, 20);
            this.lbRam.TabIndex = 10;
            this.lbRam.Text = "0 %";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "RAM:";
            // 
            // lbCpu
            // 
            this.lbCpu.AutoSize = true;
            this.lbCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCpu.Location = new System.Drawing.Point(264, 11);
            this.lbCpu.Name = "lbCpu";
            this.lbCpu.Size = new System.Drawing.Size(36, 20);
            this.lbCpu.TabIndex = 7;
            this.lbCpu.Text = "0 %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPU:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "© 2016 zekro  | ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel2.Location = new System.Drawing.Point(278, 482);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(25, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Info";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // timerCPU
            // 
            this.timerCPU.Interval = 1000;
            this.timerCPU.Tick += new System.EventHandler(this.timerCPU_Tick);
            // 
            // pcCPU
            // 
            this.pcCPU.CategoryName = "Prozessor";
            this.pcCPU.CounterName = "Prozessorzeit (%)";
            this.pcCPU.InstanceName = "_Total";
            // 
            // pcRAM
            // 
            this.pcRAM.CategoryName = "Arbeitsspeicher";
            this.pcRAM.CounterName = "Zugesicherte verwendete Bytes (%)";
            // 
            // timerKeyboardHook
            // 
            this.timerKeyboardHook.Interval = 250;
            this.timerKeyboardHook.Tick += new System.EventHandler(this.timerKeyboardHook_Tick);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbVersion.Location = new System.Drawing.Point(95, 482);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(83, 13);
            this.lbVersion.TabIndex = 12;
            this.lbVersion.Text = "© 2016 zekro  | ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbGlobalSS);
            this.groupBox1.Controls.Add(this.btPrPro);
            this.groupBox1.Controls.Add(this.btSaveMarks);
            this.groupBox1.Controls.Add(this.btResetMarks);
            this.groupBox1.Controls.Add(this.listMarker);
            this.groupBox1.Location = new System.Drawing.Point(3, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 155);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marker";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Durchsuchen...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbGlobalSS
            // 
            this.lbGlobalSS.FormattingEnabled = true;
            this.lbGlobalSS.Location = new System.Drawing.Point(229, 19);
            this.lbGlobalSS.Name = "lbGlobalSS";
            this.lbGlobalSS.Size = new System.Drawing.Size(71, 69);
            this.lbGlobalSS.TabIndex = 4;
            this.lbGlobalSS.SelectedIndexChanged += new System.EventHandler(this.lbGlobalSS_SelectedIndexChanged);
            // 
            // btPrPro
            // 
            this.btPrPro.Location = new System.Drawing.Point(9, 123);
            this.btPrPro.Name = "btPrPro";
            this.btPrPro.Size = new System.Drawing.Size(184, 23);
            this.btPrPro.TabIndex = 3;
            this.btPrPro.Text = "Marken für PrPro-Projekt speichern";
            this.btPrPro.UseVisualStyleBackColor = true;
            this.btPrPro.Click += new System.EventHandler(this.btPrPro_Click);
            // 
            // btSaveMarks
            // 
            this.btSaveMarks.Location = new System.Drawing.Point(153, 94);
            this.btSaveMarks.Name = "btSaveMarks";
            this.btSaveMarks.Size = new System.Drawing.Size(147, 23);
            this.btSaveMarks.TabIndex = 2;
            this.btSaveMarks.Text = "Marken speichern...";
            this.btSaveMarks.UseVisualStyleBackColor = true;
            this.btSaveMarks.Click += new System.EventHandler(this.btSaveMarks_Click);
            // 
            // btResetMarks
            // 
            this.btResetMarks.Location = new System.Drawing.Point(9, 94);
            this.btResetMarks.Name = "btResetMarks";
            this.btResetMarks.Size = new System.Drawing.Size(138, 23);
            this.btResetMarks.TabIndex = 1;
            this.btResetMarks.Text = "Marken reseten";
            this.btResetMarks.UseVisualStyleBackColor = true;
            this.btResetMarks.Click += new System.EventHandler(this.btResetMarks_Click);
            // 
            // listMarker
            // 
            this.listMarker.FormattingEnabled = true;
            this.listMarker.Location = new System.Drawing.Point(9, 19);
            this.listMarker.Name = "listMarker";
            this.listMarker.Size = new System.Drawing.Size(214, 69);
            this.listMarker.TabIndex = 0;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // lbUpdateWarn
            // 
            this.lbUpdateWarn.AutoSize = true;
            this.lbUpdateWarn.LinkColor = System.Drawing.Color.Red;
            this.lbUpdateWarn.Location = new System.Drawing.Point(213, 482);
            this.lbUpdateWarn.Name = "lbUpdateWarn";
            this.lbUpdateWarn.Size = new System.Drawing.Size(0, 13);
            this.lbUpdateWarn.TabIndex = 14;
            this.lbUpdateWarn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbUpdateWarn_LinkClicked);
            // 
            // pcHDD
            // 
            this.pcHDD.CategoryName = "Datenträgeraktivität des Dateisystems";
            this.pcHDD.CounterName = "Vom Dateisystem geschriebene Bytes";
            this.pcHDD.InstanceName = "_Total";
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Interval = 30000;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // timerSS
            // 
            this.timerSS.Interval = 1000;
            this.timerSS.Tick += new System.EventHandler(this.timerSS_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 505);
            this.Controls.Add(this.lbUpdateWarn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "zekro\'s Recording Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbDisks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbRAMload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCPUload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcHDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdEinstellungen;
        private System.Windows.Forms.Button cmdSoftwareStarten;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTimerHH;
        private System.Windows.Forms.Label lbRecInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDatenträger1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTimerSS;
        private System.Windows.Forms.Label lbTimerMM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbCpu;
        private System.Windows.Forms.Timer timerCPU;
        private System.Diagnostics.PerformanceCounter pcCPU;
        private System.Diagnostics.PerformanceCounter pcRAM;
        private System.Windows.Forms.Label lbRam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSpace;
        private System.Windows.Forms.Timer timerKeyboardHook;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listMarker;
        private System.Windows.Forms.Button btSaveMarks;
        private System.Windows.Forms.Button btResetMarks;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.LinkLabel lbUpdateWarn;
        private System.Windows.Forms.Label lbRecTimeLeft;
        private System.Diagnostics.PerformanceCounter pcHDD;
        private System.Windows.Forms.Button cmdRecFolder;
        private System.Windows.Forms.Timer timerAutoSave;
        private System.Windows.Forms.Button btPrPro;
        private System.Windows.Forms.ListBox lbGlobalSS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerSS;
        private System.Windows.Forms.PictureBox picbDisks;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picbRAMload;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox picbCPUload;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

