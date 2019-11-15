using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Checkers
{
    public class Game
    {
        public Color Turn = Color.Red;

        public Checker[,] Board = new Checker[8, 8];

        public Game()
        {
            for(int i = 0; i < 8; i+=2)
            {
                Board[i, 0] = new Checker(Color.Black);
                Board[i+1, 1] = new Checker(Color.Black);
                Board[i, 2] = new Checker(Color.Black);

                Board[i+1, 5] = new Checker(Color.Red);
                Board[i, 6] = new Checker(Color.Red);
                Board[i+1, 7] = new Checker(Color.Red);
            }
        }
    }
}
