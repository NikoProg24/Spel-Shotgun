using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;

namespace Inlämningsuppgift2.Classes
{
    public class Computer : Player
    {
        private Random random; //Generar ett random drag för datorn.


        //private Random random;

        public Computer()
        {
            random = new Random();
        }

        public Move MakeMove()
        {
            Move computerMove;

            if (Bullets < 1)
            {
                computerMove = Move.load;
            }

            else if (Bullets >= 3)
            {
                computerMove = Move.shotgun;
            }

            else
            {
                computerMove = RandomMove();
            }
            MakeMove(computerMove);
            return computerMove;
        }

        //Här skapar vi en metod som genererar ett random tal.
        public Move RandomMove()
        {
            int computerPlay = random.Next(0, 3);

            switch (computerPlay)
            {
                case 0:
                    return Move.load;

                case 1:
                    return Move.shoot;
                //break;

                case 2:
                    return Move.block;
                    //break;
            }
            return RandomMove();
        }
    }
}
