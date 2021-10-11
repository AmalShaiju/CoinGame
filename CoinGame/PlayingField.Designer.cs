namespace CoinGame
{
    partial class PlayingField
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
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblGameTimer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPowerUpTimer = new System.Windows.Forms.Label();
            this.lblPowerUpMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.Red;
            this.pnlPlayer.ForeColor = System.Drawing.Color.Red;
            this.pnlPlayer.Location = new System.Drawing.Point(200, 200);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(15, 15);
            this.pnlPlayer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remaning Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Points Collected:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(379, 23);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(13, 13);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "0";
            // 
            // lblGameTimer
            // 
            this.lblGameTimer.AutoSize = true;
            this.lblGameTimer.Location = new System.Drawing.Point(379, 50);
            this.lblGameTimer.Name = "lblGameTimer";
            this.lblGameTimer.Size = new System.Drawing.Size(0, 13);
            this.lblGameTimer.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Next Power Up In:";
            // 
            // lblPowerUpTimer
            // 
            this.lblPowerUpTimer.AutoSize = true;
            this.lblPowerUpTimer.Location = new System.Drawing.Point(379, 77);
            this.lblPowerUpTimer.Name = "lblPowerUpTimer";
            this.lblPowerUpTimer.Size = new System.Drawing.Size(0, 13);
            this.lblPowerUpTimer.TabIndex = 7;
            // 
            // lblPowerUpMsg
            // 
            this.lblPowerUpMsg.AutoSize = true;
            this.lblPowerUpMsg.Location = new System.Drawing.Point(12, 23);
            this.lblPowerUpMsg.Name = "lblPowerUpMsg";
            this.lblPowerUpMsg.Size = new System.Drawing.Size(0, 13);
            this.lblPowerUpMsg.TabIndex = 40;
            // 
            // PlayingField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lblPowerUpMsg);
            this.Controls.Add(this.lblPowerUpTimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGameTimer);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPlayer);
            this.Name = "PlayingField";
            this.Text = "Coin Collector";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblGameTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPowerUpTimer;
        private System.Windows.Forms.Label lblPowerUpMsg;
    }
}

