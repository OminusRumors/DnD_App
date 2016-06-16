namespace DnD
{
    partial class MainForm
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
            this.lbChar = new System.Windows.Forms.ListBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnCreateChar = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbChar
            // 
            this.lbChar.FormattingEnabled = true;
            this.lbChar.ItemHeight = 16;
            this.lbChar.Location = new System.Drawing.Point(63, 68);
            this.lbChar.Margin = new System.Windows.Forms.Padding(4);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(283, 244);
            this.lbChar.TabIndex = 0;
            this.lbChar.SelectedIndexChanged += new System.EventHandler(this.lbChar_SelectedIndexChanged);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(63, 334);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(283, 22);
            this.tbIP.TabIndex = 2;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackgroundImage = global::DnD.Properties.Resources.btn_2;
            this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Location = new System.Drawing.Point(605, 223);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(123, 37);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Create Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnCreateChar
            // 
            this.btnCreateChar.BackgroundImage = global::DnD.Properties.Resources.btn_1;
            this.btnCreateChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateChar.Location = new System.Drawing.Point(373, 165);
            this.btnCreateChar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateChar.Name = "btnCreateChar";
            this.btnCreateChar.Size = new System.Drawing.Size(123, 59);
            this.btnCreateChar.TabIndex = 3;
            this.btnCreateChar.Text = "Create Character";
            this.btnCreateChar.UseVisualStyleBackColor = true;
            this.btnCreateChar.Click += new System.EventHandler(this.btnCreateChar_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackgroundImage = global::DnD.Properties.Resources.btn_2;
            this.btnJoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.Location = new System.Drawing.Point(140, 377);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(123, 37);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "Join Game";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnD.Properties.Resources.wood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 500);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnCreateChar);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.lbChar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "DnD";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbChar;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btnCreateChar;
        private System.Windows.Forms.Button btnStartGame;
    }
}

