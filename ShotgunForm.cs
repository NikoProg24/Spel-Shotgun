using Inlämningsuppgift2.Classes;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace Inlämningsuppgift2
{
    public partial class ShotgunForm : Form
    {
        public Player player1 = new Player();
        public Computer player2 = new Computer();

        public ShotgunForm()
        {
            InitializeComponent();
            RestartGame();
        }

        private void RestartGame()
        {
            player1 = new Player();
            player2 = new Computer();

            UpdateGame();
        }
        private void UpdateGame()
        {
            labelAmmo1.Text = player1.Bullets.ToString();
            labelAmmo2.Text = player2.Bullets.ToString();

            if (player1.Bullets >= 3)
            {
                buttonShoot.Text = "Shotgun";
            }
            else
            {
                buttonShoot.Text = "Shoot";
            }
        }
        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void buttonShoot_Click(object sender, EventArgs e)
        {
            if (player1.Bullets >= 3)
            {
                player1.MakeMove(Classes.Move.shotgun);
            }
            else if (player1.Bullets < 3)
            {
                player1.MakeMove(Classes.Move.shoot);
            }
            else
            {
                MessageBox.Show("You have no bullets!");
                return;
            }
            ProcessComputerMove();
            GameResult();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            player1.MakeMove(Classes.Move.load);
            ProcessComputerMove();
            GameResult();
            UpdateGame();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            player1.MakeMove(Classes.Move.block);
            ProcessComputerMove();
            GameResult();
        }

        private void ProcessComputerMove()
        {
            Move computerMove = player2.MakeMove();
            //player2.MakeMove(computerMove);

            bool result = Game.PossiblePlays(player1, player2, ShowMessage);
            if (result)
            {
                EndGame();
            }
            else
            {
                UpdateGame();
            }
        }

        private void GameResult()
        {
            if (player1.IsWinner)
            {
                EndGame();
            }
            else if (player2.IsWinner)
            {
                EndGame();
            }
            else
            {
                UpdateGame();
            }
        }

        private void EndGame()
        {
            var dialogResult = MessageBox.Show("Do you want to play again?", 
                "Game Over", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                this.Close();
            }
        }
    }
}
