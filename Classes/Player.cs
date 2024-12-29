using System;
using System.Web;

namespace Inlämningsuppgift2.Classes
{
    public enum Move
    {
        shoot,
        block,
        load,
        shotgun
    }
    public class Player
    {
        public int Bullets { get; set; } //Antalet kulor spekaren har.
        public Move CurrentMove { get; set; } //Spelaren nuvarande drag.
        public bool IsWinner { get; set; } //Anger om spelaren vunnit.

        //Här sätter vi standardkulor till 0.
        public Player()
        {
            Bullets = 0;
        }

        //Metod som låter spelaren göra ett drag baserat på det valda draget.
        public void MakeMove(Move move)
        {
            CurrentMove = move; //Här sätter vi nuvarande draget till det valda draget.

            switch (move) //Switch-sats som utför handlingar beroende på vilket drag som valts.
            {
                case Move.block:
                    Block();
                    break;

                case Move.load:
                    LoadBullet();
                    break;

                case Move.shoot:
                    Shoot();
                    break;

                case Move.shotgun:
                    if (Bullets >= 3)
                    {
                        UseShotgun();
                    }
                    else
                    {
                        break;
                    }
                    break;

            }
        }
        public void LoadBullet()
        {
            
        }

        public void Shoot()
        {
           
        }

        public void Block()
        {

        }

        public void UseShotgun()
        {
            IsWinner = true;
        }

    }
}





       