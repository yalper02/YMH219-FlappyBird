namespace YMH219_FlappyBird
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picTopPipe = new System.Windows.Forms.PictureBox();
            this.picBottomPipe = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblRestartInfo = new System.Windows.Forms.Label();
            this.picGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Yellow;
            this.picPlayer.Location = new System.Drawing.Point(52, 136);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(56, 50);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picTopPipe
            // 
            this.picTopPipe.BackColor = System.Drawing.Color.Green;
            this.picTopPipe.Location = new System.Drawing.Point(349, -2);
            this.picTopPipe.Name = "picTopPipe";
            this.picTopPipe.Size = new System.Drawing.Size(100, 116);
            this.picTopPipe.TabIndex = 1;
            this.picTopPipe.TabStop = false;
            // 
            // picBottomPipe
            // 
            this.picBottomPipe.BackColor = System.Drawing.Color.Green;
            this.picBottomPipe.Location = new System.Drawing.Point(349, 244);
            this.picBottomPipe.Name = "picBottomPipe";
            this.picBottomPipe.Size = new System.Drawing.Size(100, 126);
            this.picBottomPipe.TabIndex = 2;
            this.picBottomPipe.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(705, 11);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(48, 16);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Skor: 0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Location = new System.Drawing.Point(364, 161);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(62, 16);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "Oyun Bitti";
            this.lblGameOver.Visible = false;
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // lblRestartInfo
            // 
            this.lblRestartInfo.AutoSize = true;
            this.lblRestartInfo.Location = new System.Drawing.Point(321, 195);
            this.lblRestartInfo.Name = "lblRestartInfo";
            this.lblRestartInfo.Size = new System.Drawing.Size(159, 16);
            this.lblRestartInfo.TabIndex = 5;
            this.lblRestartInfo.Text = "Yeniden baslatmak icin R";
            this.lblRestartInfo.Visible = false;
            // 
            // picGround
            // 
            this.picGround.BackColor = System.Drawing.Color.SaddleBrown;
            this.picGround.Location = new System.Drawing.Point(-1, 365);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(803, 83);
            this.picGround.TabIndex = 6;
            this.picGround.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.lblRestartInfo);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picBottomPipe);
            this.Controls.Add(this.picTopPipe);
            this.Controls.Add(this.picPlayer);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picTopPipe;
        private System.Windows.Forms.PictureBox picBottomPipe;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblRestartInfo;
        private System.Windows.Forms.PictureBox picGround;
    }
}

