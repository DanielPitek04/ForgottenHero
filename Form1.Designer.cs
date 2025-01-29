namespace ForgottenHeroGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameEnd = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.speedInfo = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.obstacle5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.obstacle3 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.fhero = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.coinsInfo = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fhero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.DarkOrchid;
            this.scoreText.Location = new System.Drawing.Point(339, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(211, 55);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameEnd
            // 
            this.gameEnd.AutoSize = true;
            this.gameEnd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameEnd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gameEnd.Location = new System.Drawing.Point(267, 97);
            this.gameEnd.Name = "gameEnd";
            this.gameEnd.Size = new System.Drawing.Size(0, 55);
            this.gameEnd.TabIndex = 5;
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.ForeColor = System.Drawing.Color.DarkViolet;
            this.gameOver.Location = new System.Drawing.Point(319, 211);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(0, 29);
            this.gameOver.TabIndex = 6;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // speedInfo
            // 
            this.speedInfo.AutoSize = true;
            this.speedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedInfo.Location = new System.Drawing.Point(12, 9);
            this.speedInfo.Name = "speedInfo";
            this.speedInfo.Size = new System.Drawing.Size(0, 20);
            this.speedInfo.TabIndex = 8;
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("Notram", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.Location = new System.Drawing.Point(13, 14);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(0, 23);
            this.speed.TabIndex = 10;
            // 
            // obstacle5
            // 
            this.obstacle5.BackColor = System.Drawing.Color.Black;
            this.obstacle5.Image = global::ForgottenHeroGame.Properties.Resources.bad__1_;
            this.obstacle5.Location = new System.Drawing.Point(656, 221);
            this.obstacle5.Name = "obstacle5";
            this.obstacle5.Size = new System.Drawing.Size(40, 40);
            this.obstacle5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle5.TabIndex = 12;
            this.obstacle5.TabStop = false;
            this.obstacle5.Tag = "obstacle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BackgroundImage = global::ForgottenHeroGame.Properties.Resources.ground2;
            this.pictureBox1.Location = new System.Drawing.Point(-24, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // obstacle3
            // 
            this.obstacle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.obstacle3.Image = global::ForgottenHeroGame.Properties.Resources.spike_D;
            this.obstacle3.Location = new System.Drawing.Point(221, 376);
            this.obstacle3.Name = "obstacle3";
            this.obstacle3.Size = new System.Drawing.Size(23, 46);
            this.obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle3.TabIndex = 7;
            this.obstacle3.TabStop = false;
            this.obstacle3.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.obstacle2.Image = global::ForgottenHeroGame.Properties.Resources.enemy1;
            this.obstacle2.Location = new System.Drawing.Point(797, 380);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(30, 32);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 3;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // obstacle1
            // 
            this.obstacle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.obstacle1.Image = global::ForgottenHeroGame.Properties.Resources.ground2;
            this.obstacle1.Location = new System.Drawing.Point(315, 360);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(110, 15);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obstacle1.TabIndex = 2;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // fhero
            // 
            this.fhero.BackColor = System.Drawing.Color.Black;
            this.fhero.Image = global::ForgottenHeroGame.Properties.Resources._61b29c10ec405471210804;
            this.fhero.Location = new System.Drawing.Point(16, 369);
            this.fhero.Name = "fhero";
            this.fhero.Size = new System.Drawing.Size(43, 43);
            this.fhero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fhero.TabIndex = 1;
            this.fhero.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.BackgroundImage = global::ForgottenHeroGame.Properties.Resources.secondbackground__1_;
            this.pictureBox2.Image = global::ForgottenHeroGame.Properties.Resources.backgroundt;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(884, 510);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // coinsInfo
            // 
            this.coinsInfo.AutoSize = true;
            this.coinsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coinsInfo.Location = new System.Drawing.Point(731, 14);
            this.coinsInfo.Name = "coinsInfo";
            this.coinsInfo.Size = new System.Drawing.Size(0, 25);
            this.coinsInfo.TabIndex = 13;
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.Gold;
            this.money.Location = new System.Drawing.Point(575, 376);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(20, 20);
            this.money.TabIndex = 14;
            this.money.TabStop = false;
            this.money.Tag = "coin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 497);
            this.Controls.Add(this.money);
            this.Controls.Add(this.coinsInfo);
            this.Controls.Add(this.obstacle5);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obstacle3);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.fhero);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.speedInfo);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.gameEnd);
            this.Name = "Form1";
            this.Text = "Forgotten Hero";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.obstacle5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fhero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox fhero;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label gameEnd;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox obstacle3;
        private System.Windows.Forms.Label speedInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.PictureBox obstacle5;
        private System.Windows.Forms.Label coinsInfo;
        private System.Windows.Forms.PictureBox money;
    }
}

