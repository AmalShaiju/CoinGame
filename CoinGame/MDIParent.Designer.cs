
namespace CoinGame
{
    partial class MDIParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.highScoresToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.startGameToolStripMenuItem.Text = "Start Game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.highScoresToolStripMenuItem.Text = "HighScores";
            this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click_1);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(18, 96);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(83, 22);
            this.btnSaveUser.TabIndex = 9;
            this.btnSaveUser.Text = "Start Game";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // pnlUserName
            // 
            this.pnlUserName.Controls.Add(this.txtUserName);
            this.pnlUserName.Controls.Add(this.label1);
            this.pnlUserName.Controls.Add(this.btnSaveUser);
            this.pnlUserName.Location = new System.Drawing.Point(97, 180);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(342, 143);
            this.pnlUserName.TabIndex = 10;
            this.pnlUserName.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(18, 58);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(228, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Your Name: (This will be displayed in the leaderboard)";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 537);
            this.Controls.Add(this.pnlUserName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParent";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
    }
}