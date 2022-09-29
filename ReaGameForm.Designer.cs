
namespace ReaGame
{
    partial class ReaGameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ChangeTargetTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreValue = new System.Windows.Forms.Label();
            this.Target = new System.Windows.Forms.PictureBox();
            this.healthValue = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.totalScoreValue = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeTargetTimer
            // 
            this.ChangeTargetTimer.Interval = 1000;
            this.ChangeTargetTimer.Tick += new System.EventHandler(this.ChangeTargetTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(990, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(129, 42);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score:";
            this.scoreLabel.Visible = false;
            // 
            // scoreValue
            // 
            this.scoreValue.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreValue.Location = new System.Drawing.Point(1125, 9);
            this.scoreValue.Name = "scoreValue";
            this.scoreValue.Size = new System.Drawing.Size(107, 42);
            this.scoreValue.TabIndex = 2;
            this.scoreValue.Text = "0";
            this.scoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreValue.Visible = false;
            // 
            // Target
            // 
            this.Target.BackColor = System.Drawing.Color.White;
            this.Target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Target.Location = new System.Drawing.Point(505, 211);
            this.Target.Margin = new System.Windows.Forms.Padding(0);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(200, 200);
            this.Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Target.TabIndex = 0;
            this.Target.TabStop = false;
            this.Target.Visible = false;
            // 
            // healthValue
            // 
            this.healthValue.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthValue.Location = new System.Drawing.Point(1125, 51);
            this.healthValue.Name = "healthValue";
            this.healthValue.Size = new System.Drawing.Size(107, 42);
            this.healthValue.TabIndex = 4;
            this.healthValue.Text = "100";
            this.healthValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.healthValue.Visible = false;
            // 
            // healthLabel
            // 
            this.healthLabel.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(990, 51);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(145, 42);
            this.healthLabel.TabIndex = 3;
            this.healthLabel.Text = "Health:";
            this.healthLabel.Visible = false;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(433, 22);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(368, 79);
            this.gameOverLabel.TabIndex = 5;
            this.gameOverLabel.Text = "Game Over!";
            this.gameOverLabel.Visible = false;
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.AutoSize = true;
            this.totalScoreLabel.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreLabel.Location = new System.Drawing.Point(485, 101);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(264, 52);
            this.totalScoreLabel.TabIndex = 6;
            this.totalScoreLabel.Text = "Your Score: ";
            this.totalScoreLabel.Visible = false;
            // 
            // totalScoreValue
            // 
            this.totalScoreValue.AutoSize = true;
            this.totalScoreValue.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreValue.Location = new System.Drawing.Point(578, 153);
            this.totalScoreValue.Name = "totalScoreValue";
            this.totalScoreValue.Size = new System.Drawing.Size(51, 52);
            this.totalScoreValue.TabIndex = 7;
            this.totalScoreValue.Text = "0";
            this.totalScoreValue.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(540, 565);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 56);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(521, 467);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(172, 56);
            this.newGameButton.TabIndex = 9;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Visible = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.Location = new System.Drawing.Point(861, 493);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(172, 56);
            this.startGameButton.TabIndex = 10;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(582, 411);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(677, 79);
            this.welcomeLabel.TabIndex = 11;
            this.welcomeLabel.Text = "Welcome to ReaGame!";
            // 
            // ReaGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalScoreValue);
            this.Controls.Add(this.totalScoreLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.healthValue);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.scoreValue);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.Target);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ReaGameForm";
            this.Text = "ReaGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Target)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Target;
        private System.Windows.Forms.Timer ChangeTargetTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreValue;
        private System.Windows.Forms.Label healthValue;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label totalScoreLabel;
        private System.Windows.Forms.Label totalScoreValue;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label welcomeLabel;
    }
}

