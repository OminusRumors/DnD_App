namespace DnD
{
    partial class DMaft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMaft));
            this.lbSelectedInfo = new System.Windows.Forms.ListBox();
            this.lbTurnOrder = new System.Windows.Forms.ListBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSpells = new System.Windows.Forms.ComboBox();
            this.cbSkills = new System.Windows.Forms.ComboBox();
            this.tbChangeHealth = new System.Windows.Forms.TextBox();
            this.tbActionPoints = new System.Windows.Forms.TextBox();
            this.tbDice = new System.Windows.Forms.TextBox();
            this.btnChangeHealth = new System.Windows.Forms.Button();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lHealth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lActionPoints = new System.Windows.Forms.Label();
            this.btnCastSpell = new System.Windows.Forms.Button();
            this.btnCastSkill = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMoveCost = new System.Windows.Forms.TextBox();
            this.tbAttackCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSpellCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSkillCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbGameGrid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSelectedInfo
            // 
            this.lbSelectedInfo.FormattingEnabled = true;
            this.lbSelectedInfo.ItemHeight = 16;
            this.lbSelectedInfo.Location = new System.Drawing.Point(52, 30);
            this.lbSelectedInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSelectedInfo.Name = "lbSelectedInfo";
            this.lbSelectedInfo.Size = new System.Drawing.Size(231, 52);
            this.lbSelectedInfo.TabIndex = 0;
            // 
            // lbTurnOrder
            // 
            this.lbTurnOrder.FormattingEnabled = true;
            this.lbTurnOrder.ItemHeight = 16;
            this.lbTurnOrder.Location = new System.Drawing.Point(52, 122);
            this.lbTurnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbTurnOrder.Name = "lbTurnOrder";
            this.lbTurnOrder.Size = new System.Drawing.Size(231, 228);
            this.lbTurnOrder.TabIndex = 1;
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(52, 383);
            this.lbLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(231, 228);
            this.lbLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(52, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(48, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turn order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(52, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Log";
            // 
            // cbSpells
            // 
            this.cbSpells.FormattingEnabled = true;
            this.cbSpells.Location = new System.Drawing.Point(320, 769);
            this.cbSpells.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSpells.Name = "cbSpells";
            this.cbSpells.Size = new System.Drawing.Size(136, 24);
            this.cbSpells.TabIndex = 7;
            // 
            // cbSkills
            // 
            this.cbSkills.FormattingEnabled = true;
            this.cbSkills.Location = new System.Drawing.Point(320, 818);
            this.cbSkills.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSkills.Name = "cbSkills";
            this.cbSkills.Size = new System.Drawing.Size(136, 24);
            this.cbSkills.TabIndex = 9;
            // 
            // tbChangeHealth
            // 
            this.tbChangeHealth.Location = new System.Drawing.Point(137, 675);
            this.tbChangeHealth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbChangeHealth.Name = "tbChangeHealth";
            this.tbChangeHealth.Size = new System.Drawing.Size(67, 22);
            this.tbChangeHealth.TabIndex = 10;
            // 
            // tbActionPoints
            // 
            this.tbActionPoints.Location = new System.Drawing.Point(320, 678);
            this.tbActionPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbActionPoints.Name = "tbActionPoints";
            this.tbActionPoints.ReadOnly = true;
            this.tbActionPoints.Size = new System.Drawing.Size(51, 22);
            this.tbActionPoints.TabIndex = 11;
            // 
            // tbDice
            // 
            this.tbDice.Location = new System.Drawing.Point(137, 733);
            this.tbDice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDice.Name = "tbDice";
            this.tbDice.Size = new System.Drawing.Size(67, 22);
            this.tbDice.TabIndex = 12;
            // 
            // btnChangeHealth
            // 
            this.btnChangeHealth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeHealth.BackgroundImage")));
            this.btnChangeHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeHealth.Location = new System.Drawing.Point(214, 674);
            this.btnChangeHealth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeHealth.Name = "btnChangeHealth";
            this.btnChangeHealth.Size = new System.Drawing.Size(69, 28);
            this.btnChangeHealth.TabIndex = 13;
            this.btnChangeHealth.Text = "Change";
            this.btnChangeHealth.UseVisualStyleBackColor = true;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.BackgroundImage = global::DnD.Properties.Resources.btn_2;
            this.btnEndTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEndTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEndTurn.Location = new System.Drawing.Point(804, 719);
            this.btnEndTurn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(142, 75);
            this.btnEndTurn.TabIndex = 14;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            // 
            // btnRoll
            // 
            this.btnRoll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoll.BackgroundImage")));
            this.btnRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll.Location = new System.Drawing.Point(214, 733);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(65, 28);
            this.btnRoll.TabIndex = 15;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            // 
            // lHealth
            // 
            this.lHealth.AutoSize = true;
            this.lHealth.BackColor = System.Drawing.Color.Transparent;
            this.lHealth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lHealth.Location = new System.Drawing.Point(137, 652);
            this.lHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHealth.Name = "lHealth";
            this.lHealth.Size = new System.Drawing.Size(143, 17);
            this.lHealth.TabIndex = 16;
            this.lHealth.Text = "Change player health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(137, 708);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dice type";
            // 
            // lActionPoints
            // 
            this.lActionPoints.AutoSize = true;
            this.lActionPoints.BackColor = System.Drawing.Color.Transparent;
            this.lActionPoints.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lActionPoints.Location = new System.Drawing.Point(303, 657);
            this.lActionPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lActionPoints.Name = "lActionPoints";
            this.lActionPoints.Size = new System.Drawing.Size(155, 17);
            this.lActionPoints.TabIndex = 18;
            this.lActionPoints.Text = "Action points remaining";
            // 
            // btnCastSpell
            // 
            this.btnCastSpell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCastSpell.BackgroundImage")));
            this.btnCastSpell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCastSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCastSpell.Location = new System.Drawing.Point(478, 766);
            this.btnCastSpell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCastSpell.Name = "btnCastSpell";
            this.btnCastSpell.Size = new System.Drawing.Size(81, 28);
            this.btnCastSpell.TabIndex = 20;
            this.btnCastSpell.Text = "Cast spell";
            this.btnCastSpell.UseVisualStyleBackColor = true;
            // 
            // btnCastSkill
            // 
            this.btnCastSkill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCastSkill.BackgroundImage")));
            this.btnCastSkill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCastSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCastSkill.Location = new System.Drawing.Point(478, 816);
            this.btnCastSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCastSkill.Name = "btnCastSkill";
            this.btnCastSkill.Size = new System.Drawing.Size(81, 28);
            this.btnCastSkill.TabIndex = 21;
            this.btnCastSkill.Text = "Cast Skill";
            this.btnCastSkill.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMove.BackgroundImage")));
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Location = new System.Drawing.Point(478, 657);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(81, 28);
            this.btnMove.TabIndex = 22;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttack.BackgroundImage")));
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Location = new System.Drawing.Point(478, 706);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(81, 28);
            this.btnAttack.TabIndex = 23;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(583, 662);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cost:";
            // 
            // tbMoveCost
            // 
            this.tbMoveCost.Location = new System.Drawing.Point(632, 660);
            this.tbMoveCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMoveCost.Name = "tbMoveCost";
            this.tbMoveCost.ReadOnly = true;
            this.tbMoveCost.Size = new System.Drawing.Size(57, 22);
            this.tbMoveCost.TabIndex = 25;
            // 
            // tbAttackCost
            // 
            this.tbAttackCost.Location = new System.Drawing.Point(632, 709);
            this.tbAttackCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAttackCost.Name = "tbAttackCost";
            this.tbAttackCost.ReadOnly = true;
            this.tbAttackCost.Size = new System.Drawing.Size(57, 22);
            this.tbAttackCost.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(583, 711);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cost:";
            // 
            // tbSpellCost
            // 
            this.tbSpellCost.Location = new System.Drawing.Point(632, 765);
            this.tbSpellCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSpellCost.Name = "tbSpellCost";
            this.tbSpellCost.ReadOnly = true;
            this.tbSpellCost.Size = new System.Drawing.Size(57, 22);
            this.tbSpellCost.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(583, 768);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cost:";
            // 
            // tbSkillCost
            // 
            this.tbSkillCost.Location = new System.Drawing.Point(632, 816);
            this.tbSkillCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSkillCost.Name = "tbSkillCost";
            this.tbSkillCost.ReadOnly = true;
            this.tbSkillCost.Size = new System.Drawing.Size(57, 22);
            this.tbSkillCost.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(583, 818);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cost:";
            // 
            // pbGameGrid
            // 
            this.pbGameGrid.Location = new System.Drawing.Point(296, 30);
            this.pbGameGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbGameGrid.Name = "pbGameGrid";
            this.pbGameGrid.Size = new System.Drawing.Size(1080, 602);
            this.pbGameGrid.TabIndex = 3;
            this.pbGameGrid.TabStop = false;
            // 
            // DMaft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnD.Properties.Resources.wood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1523, 935);
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
            this.Controls.Add(this.lActionPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lHealth);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.btnChangeHealth);
            this.Controls.Add(this.tbDice);
            this.Controls.Add(this.tbActionPoints);
            this.Controls.Add(this.tbChangeHealth);
            this.Controls.Add(this.cbSkills);
            this.Controls.Add(this.cbSpells);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGameGrid);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.lbTurnOrder);
            this.Controls.Add(this.lbSelectedInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DMaft";
            this.Text = "Dungeon Master In-game";
            ((System.ComponentModel.ISupportInitialize)(this.pbGameGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSelectedInfo;
        private System.Windows.Forms.ListBox lbTurnOrder;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.PictureBox pbGameGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSpells;
        private System.Windows.Forms.ComboBox cbSkills;
        private System.Windows.Forms.TextBox tbChangeHealth;
        private System.Windows.Forms.TextBox tbActionPoints;
        private System.Windows.Forms.TextBox tbDice;
        private System.Windows.Forms.Button btnChangeHealth;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lHealth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lActionPoints;
        private System.Windows.Forms.Button btnCastSpell;
        private System.Windows.Forms.Button btnCastSkill;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMoveCost;
        private System.Windows.Forms.TextBox tbAttackCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSpellCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSkillCost;
        private System.Windows.Forms.Label label8;
    }
}