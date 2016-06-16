namespace DnD
{
    partial class DMpre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMpre));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNPCs = new System.Windows.Forms.ListBox();
            this.lbHazards = new System.Windows.Forms.ListBox();
            this.lbHostIp = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnPlaceHazards = new System.Windows.Forms.Button();
            this.btnPlayerSpawn = new System.Windows.Forms.Button();
            this.btnPlaceNPCs = new System.Windows.Forms.Button();
            this.btnRemoveNPCs = new System.Windows.Forms.Button();
            this.btnSelectMap = new System.Windows.Forms.Button();
            this.btnAddNPC = new System.Windows.Forms.Button();
            this.pbGameGrid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currently Selected NPCs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(688, 802);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(49, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available Hazards";
            // 
            // lbNPCs
            // 
            this.lbNPCs.FormattingEnabled = true;
            this.lbNPCs.ItemHeight = 16;
            this.lbNPCs.Location = new System.Drawing.Point(53, 36);
            this.lbNPCs.Margin = new System.Windows.Forms.Padding(4);
            this.lbNPCs.Name = "lbNPCs";
            this.lbNPCs.Size = new System.Drawing.Size(225, 276);
            this.lbNPCs.TabIndex = 5;
            // 
            // lbHazards
            // 
            this.lbHazards.FormattingEnabled = true;
            this.lbHazards.ItemHeight = 16;
            this.lbHazards.Location = new System.Drawing.Point(53, 377);
            this.lbHazards.Margin = new System.Windows.Forms.Padding(4);
            this.lbHazards.Name = "lbHazards";
            this.lbHazards.Size = new System.Drawing.Size(225, 276);
            this.lbHazards.TabIndex = 6;
            // 
            // lbHostIp
            // 
            this.lbHostIp.Location = new System.Drawing.Point(757, 798);
            this.lbHostIp.Margin = new System.Windows.Forms.Padding(4);
            this.lbHostIp.Name = "lbHostIp";
            this.lbHostIp.ReadOnly = true;
            this.lbHostIp.Size = new System.Drawing.Size(132, 22);
            this.lbHostIp.TabIndex = 8;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackgroundImage = global::DnD.Properties.Resources.btn_2;
            this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Location = new System.Drawing.Point(1031, 802);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(131, 28);
            this.btnStartGame.TabIndex = 9;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnPlaceHazards
            // 
            this.btnPlaceHazards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaceHazards.BackgroundImage")));
            this.btnPlaceHazards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlaceHazards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceHazards.Location = new System.Drawing.Point(512, 684);
            this.btnPlaceHazards.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaceHazards.Name = "btnPlaceHazards";
            this.btnPlaceHazards.Size = new System.Drawing.Size(152, 28);
            this.btnPlaceHazards.TabIndex = 10;
            this.btnPlaceHazards.Text = "Place Hazards";
            this.btnPlaceHazards.UseVisualStyleBackColor = true;
            this.btnPlaceHazards.Click += new System.EventHandler(this.btnPlaceHazards_Click);
            // 
            // btnPlayerSpawn
            // 
            this.btnPlayerSpawn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayerSpawn.BackgroundImage")));
            this.btnPlayerSpawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayerSpawn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerSpawn.Location = new System.Drawing.Point(691, 684);
            this.btnPlayerSpawn.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayerSpawn.Name = "btnPlayerSpawn";
            this.btnPlayerSpawn.Size = new System.Drawing.Size(169, 28);
            this.btnPlayerSpawn.TabIndex = 11;
            this.btnPlayerSpawn.Text = "Place Player Spawn";
            this.btnPlayerSpawn.UseVisualStyleBackColor = true;
            this.btnPlayerSpawn.Click += new System.EventHandler(this.btnPlayerSpawn_Click);
            // 
            // btnPlaceNPCs
            // 
            this.btnPlaceNPCs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaceNPCs.BackgroundImage")));
            this.btnPlaceNPCs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlaceNPCs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceNPCs.Location = new System.Drawing.Point(322, 684);
            this.btnPlaceNPCs.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaceNPCs.Name = "btnPlaceNPCs";
            this.btnPlaceNPCs.Size = new System.Drawing.Size(156, 28);
            this.btnPlaceNPCs.TabIndex = 12;
            this.btnPlaceNPCs.Text = "Place NPCs";
            this.btnPlaceNPCs.UseVisualStyleBackColor = true;
            this.btnPlaceNPCs.Click += new System.EventHandler(this.btnPlaceNPCs_Click);
            // 
            // btnRemoveNPCs
            // 
            this.btnRemoveNPCs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveNPCs.BackgroundImage")));
            this.btnRemoveNPCs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveNPCs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveNPCs.Location = new System.Drawing.Point(418, 749);
            this.btnRemoveNPCs.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveNPCs.Name = "btnRemoveNPCs";
            this.btnRemoveNPCs.Size = new System.Drawing.Size(156, 28);
            this.btnRemoveNPCs.TabIndex = 13;
            this.btnRemoveNPCs.Text = "Remove";
            this.btnRemoveNPCs.UseVisualStyleBackColor = true;
            this.btnRemoveNPCs.Click += new System.EventHandler(this.btnRemoveNPCs_Click);
            // 
            // btnSelectMap
            // 
            this.btnSelectMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectMap.BackgroundImage")));
            this.btnSelectMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMap.Location = new System.Drawing.Point(958, 714);
            this.btnSelectMap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectMap.Name = "btnSelectMap";
            this.btnSelectMap.Size = new System.Drawing.Size(131, 28);
            this.btnSelectMap.TabIndex = 16;
            this.btnSelectMap.Text = "Select Map";
            this.btnSelectMap.UseVisualStyleBackColor = true;
            this.btnSelectMap.Click += new System.EventHandler(this.btnSelectMap_Click);
            // 
            // btnAddNPC
            // 
            this.btnAddNPC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNPC.BackgroundImage")));
            this.btnAddNPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNPC.Location = new System.Drawing.Point(53, 325);
            this.btnAddNPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNPC.Name = "btnAddNPC";
            this.btnAddNPC.Size = new System.Drawing.Size(156, 28);
            this.btnAddNPC.TabIndex = 17;
            this.btnAddNPC.Text = "Add NPC";
            this.btnAddNPC.UseVisualStyleBackColor = true;
            this.btnAddNPC.Click += new System.EventHandler(this.btnAddNPC_Click);
            // 
            // pbGameGrid
            // 
            this.pbGameGrid.Location = new System.Drawing.Point(301, 36);
            this.pbGameGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pbGameGrid.Name = "pbGameGrid";
            this.pbGameGrid.Size = new System.Drawing.Size(900, 495);
            this.pbGameGrid.TabIndex = 4;
            this.pbGameGrid.TabStop = false;
            this.pbGameGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameGrid_Paint);
            // 
            // DMpre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnD.Properties.Resources.wood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1560, 864);
            this.Controls.Add(this.btnAddNPC);
            this.Controls.Add(this.btnSelectMap);
            this.Controls.Add(this.btnRemoveNPCs);
            this.Controls.Add(this.btnPlaceNPCs);
            this.Controls.Add(this.btnPlayerSpawn);
            this.Controls.Add(this.btnPlaceHazards);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lbHostIp);
            this.Controls.Add(this.lbHazards);
            this.Controls.Add(this.lbNPCs);
            this.Controls.Add(this.pbGameGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DMpre";
            this.Text = "Host";
            this.Activated += new System.EventHandler(this.DMpre_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbGameGrid;
        private System.Windows.Forms.ListBox lbNPCs;
        private System.Windows.Forms.ListBox lbHazards;
        private System.Windows.Forms.TextBox lbHostIp;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnPlaceHazards;
        private System.Windows.Forms.Button btnPlayerSpawn;
        private System.Windows.Forms.Button btnPlaceNPCs;
        private System.Windows.Forms.Button btnRemoveNPCs;
        private System.Windows.Forms.Button btnSelectMap;
        private System.Windows.Forms.Button btnAddNPC;
    }
}