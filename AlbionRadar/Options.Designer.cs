﻿namespace AlbionRadar
{
    partial class Options
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbShowMobs = new MaterialSkin.Controls.MaterialCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShowPlayers = new MaterialSkin.Controls.MaterialCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShowRadar = new MaterialSkin.Controls.MaterialCheckBox();
            this.nRadarPosX = new System.Windows.Forms.NumericUpDown();
            this.nRadarPosY = new System.Windows.Forms.NumericUpDown();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.removeAlliance = new FontAwesome.Sharp.IconButton();
            this.addAlliance = new FontAwesome.Sharp.IconButton();
            this.lbTrustAlliances = new System.Windows.Forms.ListBox();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.lbAlliancesInRange = new System.Windows.Forms.ListBox();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.exportAllysButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.importAllysButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.removeGuild = new FontAwesome.Sharp.IconButton();
            this.addGuild = new FontAwesome.Sharp.IconButton();
            this.lbTrustGuilds = new System.Windows.Forms.ListBox();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.lbGuildsInRange = new System.Windows.Forms.ListBox();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.AllyListTimer = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRadarPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRadarPosY)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(19, 119);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(380, 337);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(372, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbShowMobs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbShowPlayers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbShowRadar);
            this.panel1.Controls.Add(this.nRadarPosX);
            this.panel1.Controls.Add(this.nRadarPosY);
            this.panel1.Controls.Add(this.materialDivider2);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 167);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Exibir monstros";
            // 
            // cbShowMobs
            // 
            this.cbShowMobs.AutoSize = true;
            this.cbShowMobs.Checked = true;
            this.cbShowMobs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowMobs.Depth = 0;
            this.cbShowMobs.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbShowMobs.Location = new System.Drawing.Point(5, 120);
            this.cbShowMobs.Margin = new System.Windows.Forms.Padding(0);
            this.cbShowMobs.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbShowMobs.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbShowMobs.Name = "cbShowMobs";
            this.cbShowMobs.Ripple = true;
            this.cbShowMobs.Size = new System.Drawing.Size(30, 30);
            this.cbShowMobs.TabIndex = 10;
            this.cbShowMobs.Text = " ";
            this.cbShowMobs.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exibir jogadores";
            // 
            // cbShowPlayers
            // 
            this.cbShowPlayers.AutoSize = true;
            this.cbShowPlayers.Checked = true;
            this.cbShowPlayers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowPlayers.Depth = 0;
            this.cbShowPlayers.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbShowPlayers.Location = new System.Drawing.Point(5, 90);
            this.cbShowPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.cbShowPlayers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbShowPlayers.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbShowPlayers.Name = "cbShowPlayers";
            this.cbShowPlayers.Ripple = true;
            this.cbShowPlayers.Size = new System.Drawing.Size(30, 30);
            this.cbShowPlayers.TabIndex = 8;
            this.cbShowPlayers.Text = " ";
            this.cbShowPlayers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exibir radar";
            // 
            // cbShowRadar
            // 
            this.cbShowRadar.AutoSize = true;
            this.cbShowRadar.Checked = true;
            this.cbShowRadar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowRadar.Depth = 0;
            this.cbShowRadar.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbShowRadar.Location = new System.Drawing.Point(5, 60);
            this.cbShowRadar.Margin = new System.Windows.Forms.Padding(0);
            this.cbShowRadar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbShowRadar.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbShowRadar.Name = "cbShowRadar";
            this.cbShowRadar.Ripple = true;
            this.cbShowRadar.Size = new System.Drawing.Size(30, 30);
            this.cbShowRadar.TabIndex = 2;
            this.cbShowRadar.Text = " ";
            this.cbShowRadar.UseVisualStyleBackColor = true;
            this.cbShowRadar.CheckedChanged += new System.EventHandler(this.showRadar_CheckedChanged);
            // 
            // nRadarPosX
            // 
            this.nRadarPosX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.nRadarPosX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRadarPosX.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRadarPosX.ForeColor = System.Drawing.Color.White;
            this.nRadarPosX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nRadarPosX.Location = new System.Drawing.Point(15, 26);
            this.nRadarPosX.Margin = new System.Windows.Forms.Padding(5);
            this.nRadarPosX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nRadarPosX.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nRadarPosX.Name = "nRadarPosX";
            this.nRadarPosX.Size = new System.Drawing.Size(60, 20);
            this.nRadarPosX.TabIndex = 4;
            this.nRadarPosX.ValueChanged += new System.EventHandler(this.MoveRadarValueChanged);
            // 
            // nRadarPosY
            // 
            this.nRadarPosY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.nRadarPosY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRadarPosY.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nRadarPosY.ForeColor = System.Drawing.Color.White;
            this.nRadarPosY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nRadarPosY.Location = new System.Drawing.Point(95, 26);
            this.nRadarPosY.Margin = new System.Windows.Forms.Padding(5);
            this.nRadarPosY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nRadarPosY.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nRadarPosY.Name = "nRadarPosY";
            this.nRadarPosY.Size = new System.Drawing.Size(60, 20);
            this.nRadarPosY.TabIndex = 6;
            this.nRadarPosY.ValueChanged += new System.EventHandler(this.MoveRadarValueChanged);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(90, 20);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Padding = new System.Windows.Forms.Padding(5);
            this.materialDivider2.Size = new System.Drawing.Size(70, 30);
            this.materialDivider2.TabIndex = 7;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(10, 20);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Padding = new System.Windows.Forms.Padding(5);
            this.materialDivider1.Size = new System.Drawing.Size(70, 30);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(168, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 163);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 163);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 2);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 2);
            this.panel2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(372, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coleta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.panel11);
            this.tabPage3.Controls.Add(this.exportAllysButton);
            this.tabPage3.Controls.Add(this.importAllysButton);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(372, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Guildas e Alianças";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alianças";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel11.Controls.Add(this.removeAlliance);
            this.panel11.Controls.Add(this.addAlliance);
            this.panel11.Controls.Add(this.lbTrustAlliances);
            this.panel11.Controls.Add(this.materialDivider5);
            this.panel11.Controls.Add(this.lbAlliancesInRange);
            this.panel11.Controls.Add(this.materialDivider6);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(13, 150);
            this.panel11.Margin = new System.Windows.Forms.Padding(10);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(346, 120);
            this.panel11.TabIndex = 9;
            // 
            // removeAlliance
            // 
            this.removeAlliance.FlatAppearance.BorderSize = 0;
            this.removeAlliance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.removeAlliance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.removeAlliance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAlliance.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.removeAlliance.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.removeAlliance.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeAlliance.IconSize = 24;
            this.removeAlliance.Location = new System.Drawing.Point(158, 75);
            this.removeAlliance.Name = "removeAlliance";
            this.removeAlliance.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.removeAlliance.Rotation = 0D;
            this.removeAlliance.Size = new System.Drawing.Size(30, 30);
            this.removeAlliance.TabIndex = 12;
            this.removeAlliance.UseVisualStyleBackColor = false;
            this.removeAlliance.Click += new System.EventHandler(this.removeAlliance_Click);
            // 
            // addAlliance
            // 
            this.addAlliance.FlatAppearance.BorderSize = 0;
            this.addAlliance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.addAlliance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.addAlliance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlliance.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addAlliance.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addAlliance.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addAlliance.IconSize = 24;
            this.addAlliance.Location = new System.Drawing.Point(158, 25);
            this.addAlliance.Name = "addAlliance";
            this.addAlliance.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.addAlliance.Rotation = 0D;
            this.addAlliance.Size = new System.Drawing.Size(30, 30);
            this.addAlliance.TabIndex = 11;
            this.addAlliance.UseVisualStyleBackColor = false;
            this.addAlliance.Click += new System.EventHandler(this.addAlliance_Click);
            // 
            // lbTrustAlliances
            // 
            this.lbTrustAlliances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lbTrustAlliances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTrustAlliances.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrustAlliances.ForeColor = System.Drawing.Color.White;
            this.lbTrustAlliances.FormattingEnabled = true;
            this.lbTrustAlliances.Location = new System.Drawing.Point(201, 33);
            this.lbTrustAlliances.Name = "lbTrustAlliances";
            this.lbTrustAlliances.Size = new System.Drawing.Size(130, 65);
            this.lbTrustAlliances.TabIndex = 9;
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(196, 25);
            this.materialDivider5.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Padding = new System.Windows.Forms.Padding(5);
            this.materialDivider5.Size = new System.Drawing.Size(140, 80);
            this.materialDivider5.TabIndex = 10;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // lbAlliancesInRange
            // 
            this.lbAlliancesInRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lbAlliancesInRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAlliancesInRange.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlliancesInRange.ForeColor = System.Drawing.Color.White;
            this.lbAlliancesInRange.FormattingEnabled = true;
            this.lbAlliancesInRange.Location = new System.Drawing.Point(15, 33);
            this.lbAlliancesInRange.Name = "lbAlliancesInRange";
            this.lbAlliancesInRange.Size = new System.Drawing.Size(130, 65);
            this.lbAlliancesInRange.TabIndex = 4;
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(10, 25);
            this.materialDivider6.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Padding = new System.Windows.Forms.Padding(5);
            this.materialDivider6.Size = new System.Drawing.Size(140, 80);
            this.materialDivider6.TabIndex = 8;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(344, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(2, 116);
            this.panel12.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(2, 116);
            this.panel13.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 118);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(346, 2);
            this.panel14.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(346, 2);
            this.panel15.TabIndex = 0;
            // 
            // exportAllysButton
            // 
            this.exportAllysButton.AutoSize = true;
            this.exportAllysButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportAllysButton.Depth = 0;
            this.exportAllysButton.Icon = null;
            this.exportAllysButton.Location = new System.Drawing.Point(269, 279);
            this.exportAllysButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exportAllysButton.Name = "exportAllysButton";
            this.exportAllysButton.Primary = true;
            this.exportAllysButton.Size = new System.Drawing.Size(90, 36);
            this.exportAllysButton.TabIndex = 8;
            this.exportAllysButton.Text = "Exportar";
            this.exportAllysButton.UseVisualStyleBackColor = true;
            // 
            // importAllysButton
            // 
            this.importAllysButton.AutoSize = true;
            this.importAllysButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importAllysButton.Depth = 0;
            this.importAllysButton.Icon = null;
            this.importAllysButton.Location = new System.Drawing.Point(173, 279);
            this.importAllysButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.importAllysButton.Name = "importAllysButton";
            this.importAllysButton.Primary = true;
            this.importAllysButton.Size = new System.Drawing.Size(90, 36);
            this.importAllysButton.TabIndex = 7;
            this.importAllysButton.Text = "Importar";
            this.importAllysButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Guildas";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel6.Controls.Add(this.removeGuild);
            this.panel6.Controls.Add(this.addGuild);
            this.panel6.Controls.Add(this.lbTrustGuilds);
            this.panel6.Controls.Add(this.materialDivider4);
            this.panel6.Controls.Add(this.lbGuildsInRange);
            this.panel6.Controls.Add(this.materialDivider3);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Location = new System.Drawing.Point(13, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(346, 120);
            this.panel6.TabIndex = 3;
            // 
            // removeGuild
            // 
            this.removeGuild.FlatAppearance.BorderSize = 0;
            this.removeGuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.removeGuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.removeGuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeGuild.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.removeGuild.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.removeGuild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeGuild.IconSize = 24;
            this.removeGuild.Location = new System.Drawing.Point(158, 75);
            this.removeGuild.Name = "removeGuild";
            this.removeGuild.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.removeGuild.Rotation = 0D;
            this.removeGuild.Size = new System.Drawing.Size(30, 30);
            this.removeGuild.TabIndex = 12;
            this.removeGuild.UseVisualStyleBackColor = false;
            this.removeGuild.Click += new System.EventHandler(this.removeGuild_Click);
            // 
            // addGuild
            // 
            this.addGuild.FlatAppearance.BorderSize = 0;
            this.addGuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.addGuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.addGuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGuild.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addGuild.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addGuild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addGuild.IconSize = 24;
            this.addGuild.Location = new System.Drawing.Point(158, 25);
            this.addGuild.Name = "addGuild";
            this.addGuild.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.addGuild.Rotation = 0D;
            this.addGuild.Size = new System.Drawing.Size(30, 30);
            this.addGuild.TabIndex = 11;
            this.addGuild.UseVisualStyleBackColor = false;
            this.addGuild.Click += new System.EventHandler(this.addGuild_Click);
            // 
            // lbTrustGuilds
            // 
            this.lbTrustGuilds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lbTrustGuilds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTrustGuilds.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrustGuilds.ForeColor = System.Drawing.Color.White;
            this.lbTrustGuilds.FormattingEnabled = true;
            this.lbTrustGuilds.Location = new System.Drawing.Point(201, 33);
            this.lbTrustGuilds.Name = "lbTrustGuilds";
            this.lbTrustGuilds.Size = new System.Drawing.Size(130, 65);
            this.lbTrustGuilds.TabIndex = 9;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(196, 25);
            this.materialDivider4.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Padding = new System.Windows.Forms.Padding(5);
            this.materialDivider4.Size = new System.Drawing.Size(140, 80);
            this.materialDivider4.TabIndex = 10;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // lbGuildsInRange
            // 
            this.lbGuildsInRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.lbGuildsInRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbGuildsInRange.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuildsInRange.ForeColor = System.Drawing.Color.White;
            this.lbGuildsInRange.FormattingEnabled = true;
            this.lbGuildsInRange.Location = new System.Drawing.Point(15, 33);
            this.lbGuildsInRange.Name = "lbGuildsInRange";
            this.lbGuildsInRange.Size = new System.Drawing.Size(130, 65);
            this.lbGuildsInRange.TabIndex = 4;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(10, 25);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Padding = new System.Windows.Forms.Padding(5);
            this.materialDivider3.Size = new System.Drawing.Size(140, 80);
            this.materialDivider3.TabIndex = 8;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(344, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 116);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 116);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 118);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(346, 2);
            this.panel9.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(346, 2);
            this.panel10.TabIndex = 0;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 38);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // AllyListTimer
            // 
            this.AllyListTimer.Interval = 1000;
            this.AllyListTimer.Tick += new System.EventHandler(this.AllyListTimer_Tick);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(418, 465);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albion Radar";
            this.Load += new System.EventHandler(this.Options_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRadarPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRadarPosY)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private MaterialSkin.Controls.MaterialRaisedButton importAllysButton;
        private MaterialSkin.Controls.MaterialRaisedButton exportAllysButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        public System.Windows.Forms.ListBox lbTrustGuilds;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private FontAwesome.Sharp.IconButton addGuild;
        private FontAwesome.Sharp.IconButton removeGuild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton removeAlliance;
        private FontAwesome.Sharp.IconButton addAlliance;
        public System.Windows.Forms.ListBox lbTrustAlliances;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        public System.Windows.Forms.ListBox lbAlliancesInRange;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Timer AllyListTimer;
        public System.Windows.Forms.NumericUpDown nRadarPosX;
        public System.Windows.Forms.NumericUpDown nRadarPosY;
        public MaterialSkin.Controls.MaterialCheckBox cbShowRadar;
        public MaterialSkin.Controls.MaterialCheckBox cbShowPlayers;
        public MaterialSkin.Controls.MaterialCheckBox cbShowMobs;
        public System.Windows.Forms.ListBox lbGuildsInRange;
    }
}

