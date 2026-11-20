using System;
using System.Drawing;
using System.Windows.Forms;

namespace YMH219_FlappyBird
{
    public partial class MainForm : Form
    {
        private Timer gameTimer;
        private int playerGravity = 10;
        private int playerVelocity = 0;
        private int pipeSpeed = 8;
        private int score = 0;
        private bool isGameOver = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeGameSettings();
        }

        private void InitializeGameSettings()
        {
            this.Width = 500;
            this.Height = 650;
            this.DoubleBuffered = true; // Titreşimi önlemek için

            lblGameOver.Visible = false;
            lblRestartInfo.Visible = false;
            lblScore.Visible = true;
            lblScore.Location = new Point(20, 20); // Sol üst köşede net görünür yer
            lblScore.BringToFront(); // Diğer kontrollerin altında kalmasını önler

            gameTimer = new Timer();
            gameTimer.Interval = 20; // ~50 FPS
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (isGameOver) return;

            // Kuşun yer çekimi hareketi
            playerVelocity += 2;
            picPlayer.Top += playerVelocity;

            // Boruların hareketi (Örnek mantık)
            picTopPipe.Left -= pipeSpeed;
            picBottomPipe.Left -= pipeSpeed;

            // Boru ekran dışına çıktıysa başa sar ve skoru artır
            if (picTopPipe.Left < -100)
            {
                picTopPipe.Left = 600;
                score++;
                lblScore.Text = $"Skor: {score}";
            }

            if (picBottomPipe.Left < -100)
            {
                picBottomPipe.Left = 700;
            }

            // Çarpışma Kontrolü (Collision Detection)
            if (picPlayer.Bounds.IntersectsWith(picTopPipe.Bounds) ||
                picPlayer.Bounds.IntersectsWith(picBottomPipe.Bounds) ||
                picPlayer.Bounds.IntersectsWith(picGround.Bounds) ||
                picPlayer.Top < 0 || picPlayer.Bottom > this.ClientRectangle.Height - 100)
            {
                GameOver();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                playerVelocity = -15; // Yukarı zıplama kuvveti
            }

            if (e.KeyCode == Keys.R && isGameOver)
            {
                RestartGame();
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            isGameOver = true;
            lblGameOver.Visible = true;
            lblRestartInfo.Visible = true;
        }

        private void RestartGame()
        {
            isGameOver = false;
            score = 0;
            lblScore.Text = "Skor: 0";
            picPlayer.Top = 200;
            picTopPipe.Left = 500;
            picBottomPipe.Left = 500;
            lblGameOver.Visible = false;
            lblRestartInfo.Visible = false;
            playerVelocity = 0;
            gameTimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }
    }
}