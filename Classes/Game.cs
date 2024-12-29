using System.Reflection.Metadata.Ecma335;

namespace Inlämningsuppgift2.Classes
{
    public class Game
    {
       
        public static bool PossiblePlays(Player player1, Computer player2, Action<string> loadMessage)
        {
            //Aktuellt drag från båda spelarna.
            Move player1Move = player1.CurrentMove;
            Move player2Move = player2.CurrentMove;

            if (player1Move == Move.load && player2Move == Move.load)
            {
                player1.Bullets++;
                player2.Bullets++;
                loadMessage("Both players loaded.");
            }
            else if (player1Move == Move.load && player2Move == Move.block)
            {
                player1.Bullets++;
                loadMessage("You loaded and the computer blocked, nothing happens.");
            }
            else if (player1Move == Move.block && player2Move == Move.load)
            {
                player2.Bullets++;
                loadMessage("You blocked and the computer loaded, nothing happens.");
            }
            else if (player1Move == Move.block && player2Move == Move.block)
            {
                loadMessage("Both players blocked, nothing happens.");
            }
            else if (player1Move == Move.shoot && player2Move == Move.block)
            {
                player1.Bullets--;
                loadMessage("The computer blocked your bullet!");
            }
            else if (player1Move == Move.block && player2Move == Move.shoot)
            {
                player2.Bullets--;
                loadMessage("You blocked the computers bullet!");
            }
            else if (player1Move == Move.shoot && player2Move == Move.shoot)
            {
                player1.Bullets--;
                player2.Bullets--;
                loadMessage("Both shoots!");
            }
            else if (player1Move == Move.load && player2Move == Move.shoot)
            {
                player2.IsWinner = true;
                loadMessage("Computer shoots and wins!");
                return true;
            }
            else if (player1Move == Move.shoot && player2Move == Move.load)
            {
                player1.IsWinner = true;
                loadMessage("You shot and won!");
                return true;
            }
            else if (player1Move == Move.shotgun && player2Move == Move.shoot || player2Move == Move.block
                || player2Move == Move.load)
            {
                player1.IsWinner = true;
                loadMessage("You used a shotgun, you win!");
                return true;
            }
            else if (player2Move == Move.shotgun && player1Move == Move.shoot || player1Move == Move.block
                || player1Move == Move.load)
            {
                player2.IsWinner = true;
                loadMessage("The computer used a shotgun, you lost!");
                return true;
            }
            return false;
        }
    }
}
