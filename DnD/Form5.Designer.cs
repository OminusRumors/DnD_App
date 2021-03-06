﻿namespace DnD
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.tbSkillCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSpellCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAttackCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMoveCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCastSkill = new System.Windows.Forms.Button();
            this.btnCastSpell = new System.Windows.Forms.Button();
            this.btnSavingThrow = new System.Windows.Forms.Button();
            this.lActionPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.tbDice = new System.Windows.Forms.TextBox();
            this.tbActionPoints = new System.Windows.Forms.TextBox();
            this.cbSkills = new System.Windows.Forms.ComboBox();
            this.cbSavingThrow = new System.Windows.Forms.ComboBox();
            this.cbSpells = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.lbPlayerInfo = new System.Windows.Forms.ListBox();
            this.pbGameGrid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSkillCost
            // 
            this.tbSkillCost.Location = new System.Drawing.Point(718, 546);
            this.tbSkillCost.Name = "tbSkillCost";
            this.tbSkillCost.ReadOnly = true;
            this.tbSkillCost.Size = new System.Drawing.Size(44, 20);
            this.tbSkillCost.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Cost:";
            // 
            // tbSpellCost
            // 
            this.tbSpellCost.Location = new System.Drawing.Point(718, 505);
            this.tbSpellCost.Name = "tbSpellCost";
            this.tbSpellCost.ReadOnly = true;
            this.tbSpellCost.Size = new System.Drawing.Size(44, 20);
            this.tbSpellCost.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Cost:";
            // 
            // tbAttackCost
            // 
            this.tbAttackCost.Location = new System.Drawing.Point(718, 459);
            this.tbAttackCost.Name = "tbAttackCost";
            this.tbAttackCost.ReadOnly = true;
            this.tbAttackCost.Size = new System.Drawing.Size(44, 20);
            this.tbAttackCost.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Cost:";
            // 
            // tbMoveCost
            // 
            this.tbMoveCost.Location = new System.Drawing.Point(718, 419);
            this.tbMoveCost.Name = "tbMoveCost";
            this.tbMoveCost.ReadOnly = true;
            this.tbMoveCost.Size = new System.Drawing.Size(44, 20);
            this.tbMoveCost.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Cost:";
            // 
            // btnAttack
            // 
            this.btnAttack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttack.BackgroundImage")));
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Location = new System.Drawing.Point(594, 456);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(61, 23);
            this.btnAttack.TabIndex = 55;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMove.BackgroundImage")));
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Location = new System.Drawing.Point(594, 416);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(61, 23);
            this.btnMove.TabIndex = 54;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // btnCastSkill
            // 
            this.btnCastSkill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCastSkill.BackgroundImage")));
            this.btnCastSkill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCastSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCastSkill.Location = new System.Drawing.Point(594, 545);
            this.btnCastSkill.Name = "btnCastSkill";
            this.btnCastSkill.Size = new System.Drawing.Size(61, 23);
            this.btnCastSkill.TabIndex = 53;
            this.btnCastSkill.Text = "Cast Skill";
            this.btnCastSkill.UseVisualStyleBackColor = true;
            // 
            // btnCastSpell
            // 
            this.btnCastSpell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCastSpell.BackgroundImage")));
            this.btnCastSpell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCastSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCastSpell.Location = new System.Drawing.Point(594, 505);
            this.btnCastSpell.Name = "btnCastSpell";
            this.btnCastSpell.Size = new System.Drawing.Size(61, 23);
            this.btnCastSpell.TabIndex = 52;
            this.btnCastSpell.Text = "Cast spell";
            this.btnCastSpell.UseVisualStyleBackColor = true;
            // 
            // btnSavingThrow
            // 
            this.btnSavingThrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSavingThrow.BackgroundImage")));
            this.btnSavingThrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSavingThrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavingThrow.Location = new System.Drawing.Point(594, 380);
            this.btnSavingThrow.Name = "btnSavingThrow";
            this.btnSavingThrow.Size = new System.Drawing.Size(61, 23);
            this.btnSavingThrow.TabIndex = 51;
            this.btnSavingThrow.Text = "Roll";
            this.btnSavingThrow.UseVisualStyleBackColor = true;
            // 
            // lActionPoints
            // 
            this.lActionPoints.AutoSize = true;
            this.lActionPoints.Location = new System.Drawing.Point(463, 416);
            this.lActionPoints.Name = "lActionPoints";
            this.lActionPoints.Size = new System.Drawing.Size(116, 13);
            this.lActionPoints.TabIndex = 50;
            this.lActionPoints.Text = "Action points remaining";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Dice type";
            // 
            // btnRoll
            // 
            this.btnRoll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoll.BackgroundImage")));
            this.btnRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll.Location = new System.Drawing.Point(327, 403);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(49, 23);
            this.btnRoll.TabIndex = 47;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.BackgroundImage = global::DnD.Properties.Resources.btn_2;
            this.btnEndTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEndTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndTurn.Location = new System.Drawing.Point(809, 564);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(61, 23);
            this.btnEndTurn.TabIndex = 46;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            // 
            // tbDice
            // 
            this.tbDice.Location = new System.Drawing.Point(269, 403);
            this.tbDice.Name = "tbDice";
            this.tbDice.Size = new System.Drawing.Size(51, 20);
            this.tbDice.TabIndex = 44;
            // 
            // tbActionPoints
            // 
            this.tbActionPoints.Location = new System.Drawing.Point(476, 433);
            this.tbActionPoints.Name = "tbActionPoints";
            this.tbActionPoints.ReadOnly = true;
            this.tbActionPoints.Size = new System.Drawing.Size(39, 20);
            this.tbActionPoints.TabIndex = 43;
            // 
            // cbSkills
            // 
            this.cbSkills.FormattingEnabled = true;
            this.cbSkills.Location = new System.Drawing.Point(476, 547);
            this.cbSkills.Name = "cbSkills";
            this.cbSkills.Size = new System.Drawing.Size(103, 21);
            this.cbSkills.TabIndex = 41;
            // 
            // cbSavingThrow
            // 
            this.cbSavingThrow.FormattingEnabled = true;
            this.cbSavingThrow.Location = new System.Drawing.Point(476, 382);
            this.cbSavingThrow.Name = "cbSavingThrow";
            this.cbSavingThrow.Size = new System.Drawing.Size(103, 21);
            this.cbSavingThrow.TabIndex = 40;
            // 
            // cbSpells
            // 
            this.cbSpells.FormattingEnabled = true;
            this.cbSpells.Location = new System.Drawing.Point(476, 507);
            this.cbSpells.Name = "cbSpells";
            this.cbSpells.Size = new System.Drawing.Size(103, 21);
            this.cbSpells.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Log";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Player Information";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(42, 401);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(174, 186);
            this.lbLog.TabIndex = 34;
            // 
            // lbPlayerInfo
            // 
            this.lbPlayerInfo.FormattingEnabled = true;
            this.lbPlayerInfo.Location = new System.Drawing.Point(42, 47);
            this.lbPlayerInfo.Name = "lbPlayerInfo";
            this.lbPlayerInfo.Size = new System.Drawing.Size(184, 290);
            this.lbPlayerInfo.TabIndex = 32;
            // 
            // pbGameGrid
            // 
            this.pbGameGrid.Location = new System.Drawing.Point(279, 47);
            this.pbGameGrid.Name = "pbGameGrid";
            this.pbGameGrid.Size = new System.Drawing.Size(645, 290);
            this.pbGameGrid.TabIndex = 35;
            this.pbGameGrid.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnD.Properties.Resources.wood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 603);
            this.Controls.Add(this.tbSkillCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSpellCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAttackCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMoveCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCastSkill);
            this.Controls.Add(this.btnCastSpell);
            this.Controls.Add(this.btnSavingThrow);
            this.Controls.Add(this.lActionPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.tbDice);
            this.Controls.Add(this.tbActionPoints);
            this.Controls.Add(this.cbSkills);
            this.Controls.Add(this.cbSavingThrow);
            this.Controls.Add(this.cbSpells);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGameGrid);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.lbPlayerInfo);
            this.Name = "Form5";
            this.Text = "Player In-game";
            ((System.ComponentModel.ISupportInitialize)(this.pbGameGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSkillCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSpellCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAttackCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMoveCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCastSkill;
        private System.Windows.Forms.Button btnCastSpell;
        private System.Windows.Forms.Button btnSavingThrow;
        private System.Windows.Forms.Label lActionPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.TextBox tbDice;
        private System.Windows.Forms.TextBox tbActionPoints;
        private System.Windows.Forms.ComboBox cbSkills;
        private System.Windows.Forms.ComboBox cbSavingThrow;
        private System.Windows.Forms.ComboBox cbSpells;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGameGrid;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.ListBox lbPlayerInfo;
    }
}