namespace Inlämningsuppgift2
{
    partial class ShotgunForm
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
            labelPlayer1 = new Label();
            labelPlayer2 = new Label();
            labelPlayer1Bullets = new Label();
            labelPlayer2Bullets = new Label();
            labelAmmo1 = new Label();
            labelAmmo2 = new Label();
            buttonShoot = new Button();
            buttonLoad = new Button();
            buttonBlock = new Button();
            SuspendLayout();
            // 
            // labelPlayer1
            // 
            labelPlayer1.AutoSize = true;
            labelPlayer1.BackColor = Color.FromArgb(192, 0, 0);
            labelPlayer1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer1.Location = new Point(47, 719);
            labelPlayer1.Name = "labelPlayer1";
            labelPlayer1.Size = new Size(110, 29);
            labelPlayer1.TabIndex = 0;
            labelPlayer1.Text = "Player 1";
            // 
            // labelPlayer2
            // 
            labelPlayer2.AutoSize = true;
            labelPlayer2.BackColor = Color.Green;
            labelPlayer2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer2.Location = new Point(576, 719);
            labelPlayer2.Name = "labelPlayer2";
            labelPlayer2.Size = new Size(110, 29);
            labelPlayer2.TabIndex = 1;
            labelPlayer2.Text = "Player 2";
            // 
            // labelPlayer1Bullets
            // 
            labelPlayer1Bullets.AutoSize = true;
            labelPlayer1Bullets.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer1Bullets.Location = new Point(47, 757);
            labelPlayer1Bullets.Name = "labelPlayer1Bullets";
            labelPlayer1Bullets.Size = new Size(103, 29);
            labelPlayer1Bullets.TabIndex = 2;
            labelPlayer1Bullets.Text = "Bullets:";
            // 
            // labelPlayer2Bullets
            // 
            labelPlayer2Bullets.AutoSize = true;
            labelPlayer2Bullets.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer2Bullets.Location = new Point(576, 757);
            labelPlayer2Bullets.Name = "labelPlayer2Bullets";
            labelPlayer2Bullets.Size = new Size(103, 29);
            labelPlayer2Bullets.TabIndex = 3;
            labelPlayer2Bullets.Text = "Bullets:";
            // 
            // labelAmmo1
            // 
            labelAmmo1.AutoSize = true;
            labelAmmo1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAmmo1.Location = new Point(156, 757);
            labelAmmo1.Name = "labelAmmo1";
            labelAmmo1.Size = new Size(28, 29);
            labelAmmo1.TabIndex = 4;
            labelAmmo1.Text = "0";
            // 
            // labelAmmo2
            // 
            labelAmmo2.AutoSize = true;
            labelAmmo2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAmmo2.Location = new Point(685, 757);
            labelAmmo2.Name = "labelAmmo2";
            labelAmmo2.Size = new Size(28, 29);
            labelAmmo2.TabIndex = 5;
            labelAmmo2.Text = "0";
            // 
            // buttonShoot
            // 
            buttonShoot.BackColor = Color.FromArgb(255, 255, 192);
            buttonShoot.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShoot.Location = new Point(1018, 100);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(174, 55);
            buttonShoot.TabIndex = 6;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = false;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.FromArgb(255, 255, 192);
            buttonLoad.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLoad.Location = new Point(1018, 210);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(174, 55);
            buttonLoad.TabIndex = 7;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.BackColor = Color.FromArgb(255, 255, 192);
            buttonBlock.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBlock.Location = new Point(1018, 322);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(174, 55);
            buttonBlock.TabIndex = 8;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = false;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // ShotgunForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bild;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1411, 821);
            Controls.Add(buttonBlock);
            Controls.Add(buttonLoad);
            Controls.Add(buttonShoot);
            Controls.Add(labelAmmo2);
            Controls.Add(labelAmmo1);
            Controls.Add(labelPlayer2Bullets);
            Controls.Add(labelPlayer1Bullets);
            Controls.Add(labelPlayer2);
            Controls.Add(labelPlayer1);
            Name = "ShotgunForm";
            Text = "ShotgunForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayer1;
        private Label labelPlayer2;
        private Label labelPlayer1Bullets;
        private Label labelPlayer2Bullets;
        private Label labelAmmo1;
        private Label labelAmmo2;
        private Button buttonShoot;
        private Button buttonLoad;
        private Button buttonBlock;
    }
}