using System;
using System.Windows.Forms;

namespace ReaGame
{
    public partial class ReaGameForm : Form
    {
        Random random;
        PictureBox squareTarget;
        PictureBox circleTarget;
        PictureBox triangleTarget;
        int score;
        int health;

        public ReaGameForm()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Target.Image == squareTarget.Image)
            {
                if (e.KeyCode == Keys.Q)
                {
                    Target.Image = Properties.Resources.SquareSucceed;
                    UpScore();
                }
                else
                {
                    Target.Image = Properties.Resources.SquareFailed;
                    ReceiveDamage();
                }
            }

            if (Target.Image == circleTarget.Image)
            {
                if (e.KeyCode == Keys.O)
                {
                    Target.Image = Properties.Resources.CircleSucceed;
                    UpScore();
                }
                else
                {
                    Target.Image = Properties.Resources.CircleFailed;
                    ReceiveDamage();
                }
            }

            if (Target.Image == triangleTarget.Image)
            {
                if (e.KeyCode == Keys.P)
                {
                    Target.Image = Properties.Resources.TriangleSucceed;
                    UpScore();
                }
                else
                {
                    Target.Image = Properties.Resources.TriangleFailed;
                    ReceiveDamage();
                }
            }
        }

        private void ChangeTargetTimer_Tick(object sender, EventArgs e)
        {
            switch (random.Next(0, 3))
            {
                case 0:
                    Target.Image = circleTarget.Image;
                    break;
                case 1:
                    Target.Image = squareTarget.Image;
                    break;
                case 2:
                    Target.Image = triangleTarget.Image;
                    break;
            }

            if (ChangeTargetTimer.Interval != 500) {
                ChangeTargetTimer.Interval -= 5;
            }
        }

        private void ReceiveDamage()
        {
            health -= 20;
            healthValue.Text = health.ToString();

            if (health == 0)
            {
                GameOver();
            }
        }

        private void UpScore()
        {
            score += 100;
            scoreValue.Text = score.ToString();
        }

        private void GameOver()
        {
            ChangeTargetTimer.Stop();
            
            gameOverLabel.Left = ClientSize.Width / 2 - gameOverLabel.Width / 2;
            gameOverLabel.Top = ClientSize.Height - 550;
            gameOverLabel.Visible = true;

            totalScoreLabel.Left = ClientSize.Width / 2 - totalScoreLabel.Width / 2;
            totalScoreLabel.Top = ClientSize.Height - 490;
            totalScoreLabel.Visible = true;

            totalScoreValue.Text = score.ToString();
            totalScoreValue.Left = ClientSize.Width / 2 - totalScoreValue.Width / 2;
            totalScoreValue.Top = ClientSize.Height - 440;
            totalScoreValue.Visible = true;

            newGameButton.Left = ClientSize.Width / 2 - newGameButton.Width / 2;
            newGameButton.Top = ClientSize.Height - 150;
            newGameButton.Visible = true;

            exitButton.Left = ClientSize.Width / 2 - exitButton.Width / 2;
            exitButton.Top = ClientSize.Height - 80;
            exitButton.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            gameOverLabel.Visible = false;
            totalScoreLabel.Visible = false;
            totalScoreValue.Visible = false;
            newGameButton.Visible = false;
            exitButton.Visible = false;

            score = 0;
            scoreValue.Text = score.ToString();
            health = 100;
            healthValue.Text = health.ToString();
            Target.Image = null;

            ChangeTargetTimer.Interval = 1000;
            ChangeTargetTimer.Start();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            startGameButton.Visible = false;
            exitButton.Visible = false;
            welcomeLabel.Visible = false;

            scoreLabel.Visible = true;
            scoreValue.Visible = true;
            healthLabel.Visible = true;
            healthValue.Visible = true;
            Target.Visible = true;

            ChangeTargetTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            squareTarget = new PictureBox { Image = Properties.Resources.SquareTarget };
            circleTarget = new PictureBox { Image = Properties.Resources.CircleTarget };
            triangleTarget = new PictureBox { Image = Properties.Resources.TriangleTarget };
            score = 0;
            health = 100;

            startGameButton.Left = ClientSize.Width / 2 - startGameButton.Width / 2;
            startGameButton.Top = ClientSize.Height / 2 - startGameButton.Height / 2;

            welcomeLabel.Left = ClientSize.Width / 2 - welcomeLabel.Width / 2;
            welcomeLabel.Top = ClientSize.Height - 550;

            exitButton.Left = ClientSize.Width / 2 - exitButton.Width / 2;
            exitButton.Top = ClientSize.Height - 80;

            Target.Left = ClientSize.Width / 2 - Target.Width / 2;
            Target.Top = ClientSize.Height / 2 - Target.Height / 2;
        }
    }
}
