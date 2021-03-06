﻿namespace DnD
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPointsRemaining = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCharUp = new System.Windows.Forms.Button();
            this.btnCharDown = new System.Windows.Forms.Button();
            this.btnWisUp = new System.Windows.Forms.Button();
            this.btnWisDown = new System.Windows.Forms.Button();
            this.btnIntUp = new System.Windows.Forms.Button();
            this.btnIntDown = new System.Windows.Forms.Button();
            this.btnConUp = new System.Windows.Forms.Button();
            this.btnConDown = new System.Windows.Forms.Button();
            this.btnDexUp = new System.Windows.Forms.Button();
            this.btnDexDown = new System.Windows.Forms.Button();
            this.btnStrUp = new System.Windows.Forms.Button();
            this.btnStrDown = new System.Windows.Forms.Button();
            this.tbChar = new System.Windows.Forms.TextBox();
            this.tbwis = new System.Windows.Forms.TextBox();
            this.tbInt = new System.Windows.Forms.TextBox();
            this.tbCons = new System.Windows.Forms.TextBox();
            this.tbDex = new System.Windows.Forms.TextBox();
            this.tbStrength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbMain = new System.Windows.Forms.ComboBox();
            this.cmbArmor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRemoveSpell = new System.Windows.Forms.Button();
            this.btnAddSpell = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbSpellsPicked = new System.Windows.Forms.ListBox();
            this.cmbSpellList = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLevel
            // 
            this.tbLevel.Location = new System.Drawing.Point(180, 26);
            this.tbLevel.Margin = new System.Windows.Forms.Padding(5);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(169, 22);
            this.tbLevel.TabIndex = 0;
            this.tbLevel.TextChanged += new System.EventHandler(this.tbLevel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Level";
            // 
            // tbPointsRemaining
            // 
            this.tbPointsRemaining.Location = new System.Drawing.Point(180, 71);
            this.tbPointsRemaining.Margin = new System.Windows.Forms.Padding(5);
            this.tbPointsRemaining.Name = "tbPointsRemaining";
            this.tbPointsRemaining.Size = new System.Drawing.Size(80, 22);
            this.tbPointsRemaining.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnCharUp);
            this.groupBox1.Controls.Add(this.btnCharDown);
            this.groupBox1.Controls.Add(this.btnWisUp);
            this.groupBox1.Controls.Add(this.btnWisDown);
            this.groupBox1.Controls.Add(this.btnIntUp);
            this.groupBox1.Controls.Add(this.btnIntDown);
            this.groupBox1.Controls.Add(this.btnConUp);
            this.groupBox1.Controls.Add(this.btnConDown);
            this.groupBox1.Controls.Add(this.btnDexUp);
            this.groupBox1.Controls.Add(this.btnDexDown);
            this.groupBox1.Controls.Add(this.btnStrUp);
            this.groupBox1.Controls.Add(this.btnStrDown);
            this.groupBox1.Controls.Add(this.tbChar);
            this.groupBox1.Controls.Add(this.tbwis);
            this.groupBox1.Controls.Add(this.tbInt);
            this.groupBox1.Controls.Add(this.tbCons);
            this.groupBox1.Controls.Add(this.tbDex);
            this.groupBox1.Controls.Add(this.tbStrength);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPointsRemaining);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbLevel);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(391, 593);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1";
            // 
            // btnCharUp
            // 
            this.btnCharUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCharUp.BackgroundImage")));
            this.btnCharUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCharUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharUp.Location = new System.Drawing.Point(256, 530);
            this.btnCharUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCharUp.Name = "btnCharUp";
            this.btnCharUp.Size = new System.Drawing.Size(53, 32);
            this.btnCharUp.TabIndex = 27;
            this.btnCharUp.Text = "/\\";
            this.btnCharUp.UseVisualStyleBackColor = true;
            this.btnCharUp.Click += new System.EventHandler(this.btnCharUp_Click);
            // 
            // btnCharDown
            // 
            this.btnCharDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCharDown.BackgroundImage")));
            this.btnCharDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCharDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharDown.Location = new System.Drawing.Point(48, 529);
            this.btnCharDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCharDown.Name = "btnCharDown";
            this.btnCharDown.Size = new System.Drawing.Size(55, 32);
            this.btnCharDown.TabIndex = 26;
            this.btnCharDown.Text = "\\/";
            this.btnCharDown.UseVisualStyleBackColor = true;
            this.btnCharDown.Click += new System.EventHandler(this.btnCharDown_Click);
            // 
            // btnWisUp
            // 
            this.btnWisUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWisUp.BackgroundImage")));
            this.btnWisUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWisUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWisUp.Location = new System.Drawing.Point(256, 454);
            this.btnWisUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnWisUp.Name = "btnWisUp";
            this.btnWisUp.Size = new System.Drawing.Size(53, 32);
            this.btnWisUp.TabIndex = 25;
            this.btnWisUp.Text = "/\\";
            this.btnWisUp.UseVisualStyleBackColor = true;
            this.btnWisUp.Click += new System.EventHandler(this.btnWisUp_Click);
            // 
            // btnWisDown
            // 
            this.btnWisDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWisDown.BackgroundImage")));
            this.btnWisDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWisDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWisDown.Location = new System.Drawing.Point(48, 453);
            this.btnWisDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnWisDown.Name = "btnWisDown";
            this.btnWisDown.Size = new System.Drawing.Size(55, 32);
            this.btnWisDown.TabIndex = 24;
            this.btnWisDown.Text = "\\/";
            this.btnWisDown.UseVisualStyleBackColor = true;
            this.btnWisDown.Click += new System.EventHandler(this.btnWisDown_Click);
            // 
            // btnIntUp
            // 
            this.btnIntUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIntUp.BackgroundImage")));
            this.btnIntUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIntUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntUp.Location = new System.Drawing.Point(256, 385);
            this.btnIntUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnIntUp.Name = "btnIntUp";
            this.btnIntUp.Size = new System.Drawing.Size(53, 32);
            this.btnIntUp.TabIndex = 23;
            this.btnIntUp.Text = "/\\";
            this.btnIntUp.UseVisualStyleBackColor = true;
            this.btnIntUp.Click += new System.EventHandler(this.btnIntUp_Click);
            // 
            // btnIntDown
            // 
            this.btnIntDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIntDown.BackgroundImage")));
            this.btnIntDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIntDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntDown.Location = new System.Drawing.Point(48, 383);
            this.btnIntDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnIntDown.Name = "btnIntDown";
            this.btnIntDown.Size = new System.Drawing.Size(55, 32);
            this.btnIntDown.TabIndex = 22;
            this.btnIntDown.Text = "\\/";
            this.btnIntDown.UseVisualStyleBackColor = true;
            this.btnIntDown.Click += new System.EventHandler(this.btnIntDown_Click);
            // 
            // btnConUp
            // 
            this.btnConUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConUp.BackgroundImage")));
            this.btnConUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConUp.Location = new System.Drawing.Point(256, 309);
            this.btnConUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnConUp.Name = "btnConUp";
            this.btnConUp.Size = new System.Drawing.Size(53, 32);
            this.btnConUp.TabIndex = 21;
            this.btnConUp.Text = "/\\";
            this.btnConUp.UseVisualStyleBackColor = true;
            this.btnConUp.Click += new System.EventHandler(this.btnConUp_Click);
            // 
            // btnConDown
            // 
            this.btnConDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConDown.BackgroundImage")));
            this.btnConDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConDown.Location = new System.Drawing.Point(48, 308);
            this.btnConDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnConDown.Name = "btnConDown";
            this.btnConDown.Size = new System.Drawing.Size(55, 32);
            this.btnConDown.TabIndex = 20;
            this.btnConDown.Text = "\\/";
            this.btnConDown.UseVisualStyleBackColor = true;
            this.btnConDown.Click += new System.EventHandler(this.btnConDown_Click);
            // 
            // btnDexUp
            // 
            this.btnDexUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDexUp.BackgroundImage")));
            this.btnDexUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDexUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDexUp.Location = new System.Drawing.Point(256, 234);
            this.btnDexUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDexUp.Name = "btnDexUp";
            this.btnDexUp.Size = new System.Drawing.Size(53, 32);
            this.btnDexUp.TabIndex = 19;
            this.btnDexUp.Text = "/\\";
            this.btnDexUp.UseVisualStyleBackColor = true;
            this.btnDexUp.Click += new System.EventHandler(this.btnDexUp_Click);
            // 
            // btnDexDown
            // 
            this.btnDexDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDexDown.BackgroundImage")));
            this.btnDexDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDexDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDexDown.Location = new System.Drawing.Point(48, 231);
            this.btnDexDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDexDown.Name = "btnDexDown";
            this.btnDexDown.Size = new System.Drawing.Size(55, 32);
            this.btnDexDown.TabIndex = 18;
            this.btnDexDown.Text = "\\/";
            this.btnDexDown.UseVisualStyleBackColor = true;
            this.btnDexDown.Click += new System.EventHandler(this.btnDexDown_Click);
            // 
            // btnStrUp
            // 
            this.btnStrUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStrUp.BackgroundImage")));
            this.btnStrUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStrUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrUp.Location = new System.Drawing.Point(256, 158);
            this.btnStrUp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnStrUp.Name = "btnStrUp";
            this.btnStrUp.Size = new System.Drawing.Size(53, 32);
            this.btnStrUp.TabIndex = 17;
            this.btnStrUp.Text = "/\\";
            this.btnStrUp.UseVisualStyleBackColor = true;
            this.btnStrUp.Click += new System.EventHandler(this.btnStrUp_Click);
            // 
            // btnStrDown
            // 
            this.btnStrDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStrDown.BackgroundImage")));
            this.btnStrDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStrDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrDown.Location = new System.Drawing.Point(48, 156);
            this.btnStrDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnStrDown.Name = "btnStrDown";
            this.btnStrDown.Size = new System.Drawing.Size(55, 32);
            this.btnStrDown.TabIndex = 16;
            this.btnStrDown.Text = "\\/";
            this.btnStrDown.UseVisualStyleBackColor = true;
            this.btnStrDown.Click += new System.EventHandler(this.btnStrDown_Click);
            // 
            // tbChar
            // 
            this.tbChar.Location = new System.Drawing.Point(140, 530);
            this.tbChar.Margin = new System.Windows.Forms.Padding(5);
            this.tbChar.Name = "tbChar";
            this.tbChar.ReadOnly = true;
            this.tbChar.Size = new System.Drawing.Size(80, 22);
            this.tbChar.TabIndex = 15;
            // 
            // tbwis
            // 
            this.tbwis.Location = new System.Drawing.Point(140, 454);
            this.tbwis.Margin = new System.Windows.Forms.Padding(5);
            this.tbwis.Name = "tbwis";
            this.tbwis.ReadOnly = true;
            this.tbwis.Size = new System.Drawing.Size(80, 22);
            this.tbwis.TabIndex = 14;
            // 
            // tbInt
            // 
            this.tbInt.Location = new System.Drawing.Point(140, 385);
            this.tbInt.Margin = new System.Windows.Forms.Padding(5);
            this.tbInt.Name = "tbInt";
            this.tbInt.ReadOnly = true;
            this.tbInt.Size = new System.Drawing.Size(80, 22);
            this.tbInt.TabIndex = 13;
            // 
            // tbCons
            // 
            this.tbCons.Location = new System.Drawing.Point(140, 309);
            this.tbCons.Margin = new System.Windows.Forms.Padding(5);
            this.tbCons.Name = "tbCons";
            this.tbCons.ReadOnly = true;
            this.tbCons.Size = new System.Drawing.Size(80, 22);
            this.tbCons.TabIndex = 12;
            // 
            // tbDex
            // 
            this.tbDex.Location = new System.Drawing.Point(140, 231);
            this.tbDex.Margin = new System.Windows.Forms.Padding(5);
            this.tbDex.Name = "tbDex";
            this.tbDex.ReadOnly = true;
            this.tbDex.Size = new System.Drawing.Size(80, 22);
            this.tbDex.TabIndex = 11;
            // 
            // tbStrength
            // 
            this.tbStrength.Location = new System.Drawing.Point(140, 156);
            this.tbStrength.Margin = new System.Windows.Forms.Padding(5);
            this.tbStrength.Name = "tbStrength";
            this.tbStrength.ReadOnly = true;
            this.tbStrength.Size = new System.Drawing.Size(80, 22);
            this.tbStrength.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(96, 506);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Charisma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(96, 431);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Wisdom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(96, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Inteligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(96, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Constitution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(96, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(96, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Points Remaining";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.cmbClass);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbRace);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Location = new System.Drawing.Point(436, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(384, 262);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(105, 119);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(5);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(229, 24);
            this.cmbClass.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(11, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Class";
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Location = new System.Drawing.Point(105, 71);
            this.cmbRace.Margin = new System.Windows.Forms.Padding(5);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(229, 24);
            this.cmbRace.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(11, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Race";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(11, 31);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(105, 26);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(233, 22);
            this.tbName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.checkBox16);
            this.groupBox3.Controls.Add(this.checkBox15);
            this.groupBox3.Controls.Add(this.checkBox14);
            this.groupBox3.Controls.Add(this.checkBox13);
            this.groupBox3.Controls.Add(this.checkBox12);
            this.groupBox3.Controls.Add(this.checkBox11);
            this.groupBox3.Controls.Add(this.checkBox10);
            this.groupBox3.Controls.Add(this.checkBox9);
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(857, 38);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(513, 337);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3";
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.BackColor = System.Drawing.Color.Transparent;
            this.checkBox16.Location = new System.Drawing.Point(284, 273);
            this.checkBox16.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(80, 21);
            this.checkBox16.TabIndex = 15;
            this.checkBox16.Text = "Servival";
            this.checkBox16.UseVisualStyleBackColor = false;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.BackColor = System.Drawing.Color.Transparent;
            this.checkBox15.Location = new System.Drawing.Point(284, 238);
            this.checkBox15.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(74, 21);
            this.checkBox15.TabIndex = 14;
            this.checkBox15.Text = "Stealth";
            this.checkBox15.UseVisualStyleBackColor = false;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.BackColor = System.Drawing.Color.Transparent;
            this.checkBox14.Location = new System.Drawing.Point(284, 203);
            this.checkBox14.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(119, 21);
            this.checkBox14.TabIndex = 13;
            this.checkBox14.Text = "Slight of Hand";
            this.checkBox14.UseVisualStyleBackColor = false;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.BackColor = System.Drawing.Color.Transparent;
            this.checkBox13.Location = new System.Drawing.Point(284, 169);
            this.checkBox13.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(81, 21);
            this.checkBox13.TabIndex = 12;
            this.checkBox13.Text = "Religion";
            this.checkBox13.UseVisualStyleBackColor = false;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.BackColor = System.Drawing.Color.Transparent;
            this.checkBox12.Location = new System.Drawing.Point(284, 133);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(101, 21);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.Text = "Persuasion";
            this.checkBox12.UseVisualStyleBackColor = false;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.BackColor = System.Drawing.Color.Transparent;
            this.checkBox11.Location = new System.Drawing.Point(284, 98);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(111, 21);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "Performance";
            this.checkBox11.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.BackColor = System.Drawing.Color.Transparent;
            this.checkBox10.Location = new System.Drawing.Point(284, 64);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(98, 21);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Perception";
            this.checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.BackColor = System.Drawing.Color.Transparent;
            this.checkBox9.Location = new System.Drawing.Point(284, 28);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(73, 21);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Nature";
            this.checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.BackColor = System.Drawing.Color.Transparent;
            this.checkBox8.Location = new System.Drawing.Point(31, 273);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(86, 21);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Medicine";
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.BackColor = System.Drawing.Color.Transparent;
            this.checkBox7.Location = new System.Drawing.Point(31, 238);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(71, 21);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Insight";
            this.checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.Transparent;
            this.checkBox6.Location = new System.Drawing.Point(31, 203);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(74, 21);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "History";
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.Location = new System.Drawing.Point(31, 169);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(94, 21);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Deception";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Location = new System.Drawing.Point(31, 133);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(83, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Athletics";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Location = new System.Drawing.Point(31, 98);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Arcana";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(31, 64);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(132, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Animal Handling";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(31, 28);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Acrobatics";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.Controls.Add(this.cmbMain);
            this.groupBox4.Controls.Add(this.cmbArmor);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(25, 676);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(391, 122);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 4";
            // 
            // cmbMain
            // 
            this.cmbMain.FormattingEnabled = true;
            this.cmbMain.Location = new System.Drawing.Point(124, 76);
            this.cmbMain.Margin = new System.Windows.Forms.Padding(5);
            this.cmbMain.Name = "cmbMain";
            this.cmbMain.Size = new System.Drawing.Size(223, 24);
            this.cmbMain.TabIndex = 5;
            // 
            // cmbArmor
            // 
            this.cmbArmor.FormattingEnabled = true;
            this.cmbArmor.Location = new System.Drawing.Point(124, 31);
            this.cmbArmor.Margin = new System.Windows.Forms.Padding(5);
            this.cmbArmor.Name = "cmbArmor";
            this.cmbArmor.Size = new System.Drawing.Size(223, 24);
            this.cmbArmor.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(11, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Main Hand";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(11, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Armor";
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = global::DnD.Properties.Resources.paper;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.btnRemoveSpell);
            this.groupBox5.Controls.Add(this.btnAddSpell);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.lbSpellsPicked);
            this.groupBox5.Controls.Add(this.cmbSpellList);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox5.Location = new System.Drawing.Point(436, 396);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(933, 485);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step 5 (If Needed)";
            // 
            // btnRemoveSpell
            // 
            this.btnRemoveSpell.BackgroundImage = global::DnD.Properties.Resources.btn_3;
            this.btnRemoveSpell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSpell.Location = new System.Drawing.Point(697, 294);
            this.btnRemoveSpell.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveSpell.Name = "btnRemoveSpell";
            this.btnRemoveSpell.Size = new System.Drawing.Size(161, 39);
            this.btnRemoveSpell.TabIndex = 7;
            this.btnRemoveSpell.Text = "Remove Spell";
            this.btnRemoveSpell.UseVisualStyleBackColor = true;
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddSpell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSpell.BackgroundImage")));
            this.btnAddSpell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpell.Location = new System.Drawing.Point(180, 94);
            this.btnAddSpell.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddSpell.Name = "btnAddSpell";
            this.btnAddSpell.Size = new System.Drawing.Size(161, 39);
            this.btnAddSpell.TabIndex = 6;
            this.btnAddSpell.Text = "Add Spell";
            this.btnAddSpell.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(437, 37);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "Spell Levels Available";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(647, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 116);
            this.listBox1.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(11, 132);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "Chosen Spells";
            // 
            // lbSpellsPicked
            // 
            this.lbSpellsPicked.FormattingEnabled = true;
            this.lbSpellsPicked.ItemHeight = 16;
            this.lbSpellsPicked.Location = new System.Drawing.Point(16, 175);
            this.lbSpellsPicked.Margin = new System.Windows.Forms.Padding(5);
            this.lbSpellsPicked.Name = "lbSpellsPicked";
            this.lbSpellsPicked.Size = new System.Drawing.Size(627, 292);
            this.lbSpellsPicked.TabIndex = 2;
            // 
            // cmbSpellList
            // 
            this.cmbSpellList.FormattingEnabled = true;
            this.cmbSpellList.Location = new System.Drawing.Point(97, 37);
            this.cmbSpellList.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSpellList.Name = "cmbSpellList";
            this.cmbSpellList.Size = new System.Drawing.Size(283, 24);
            this.cmbSpellList.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(11, 41);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Spells";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = global::DnD.Properties.Resources.btn_2;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(1191, 924);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 39);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm Character";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::DnD.Properties.Resources.btn_3;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(972, 924);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 39);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel Character";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnD.Properties.Resources.wood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1481, 1045);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CharacterForm";
            this.Text = "Create Character";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPointsRemaining;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbChar;
        private System.Windows.Forms.TextBox tbwis;
        private System.Windows.Forms.TextBox tbInt;
        private System.Windows.Forms.TextBox tbCons;
        private System.Windows.Forms.TextBox tbDex;
        private System.Windows.Forms.TextBox tbStrength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCharUp;
        private System.Windows.Forms.Button btnCharDown;
        private System.Windows.Forms.Button btnWisUp;
        private System.Windows.Forms.Button btnWisDown;
        private System.Windows.Forms.Button btnIntUp;
        private System.Windows.Forms.Button btnIntDown;
        private System.Windows.Forms.Button btnConUp;
        private System.Windows.Forms.Button btnConDown;
        private System.Windows.Forms.Button btnDexUp;
        private System.Windows.Forms.Button btnDexDown;
        private System.Windows.Forms.Button btnStrUp;
        private System.Windows.Forms.Button btnStrDown;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbMain;
        private System.Windows.Forms.ComboBox cmbArmor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRemoveSpell;
        private System.Windows.Forms.Button btnAddSpell;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lbSpellsPicked;
        private System.Windows.Forms.ComboBox cmbSpellList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}