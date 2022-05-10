using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        
        public Player player; 
        public int currentMove = 0;
        private int countMove = 9;
        public int[,] table = { { -1, -1, -1 } , { -1, -1, -1 } , { -1, -1, -1 } };
        public Game(Player pl)
        {
            player = pl;
            
        }
        public void Move(int x, int y)
        {
            currentMove = (currentMove + 1) % 2;
            table[x, y] = currentMove;
            countMove = countMove - 1;
        }
        public bool IsVictory()
        {
            if (((table[0, 0] == table[0, 1]) && (table[0, 2] == currentMove)) && (table[0, 0] == table[0, 2]))
            {
                return true;
            }
            if (((table[1, 0] == table[1, 1]) && (table[1, 2] == currentMove)) && (table[1, 0] == table[1, 2]))
            {
                return true;
            }
            if (((table[2, 0] == table[2, 1]) && (table[2, 2] == currentMove)) && (table[2, 0] == table[2, 2]))
            {
                return true;
            }
            if (((table[0, 0] == table[1, 0]) && (table[2, 0] == currentMove)) && (table[0, 0] == table[2, 0]))
            {
                return true;
            }
            if (((table[0, 1] == table[1, 1]) && (table[2, 1] == currentMove)) && (table[0, 1] == table[2, 1]))
            {
                return true;
            }
            if (((table[0, 2] == table[1, 2]) && (table[2, 2] == currentMove)) && (table[0, 2] == table[2, 2]))
            {
                return true;
            }
            if (((table[0, 0] == table[1, 1]) && (table[2, 2] == currentMove)) && (table[0, 0] == table[2, 2]))
            {
                return true;
            }
            if (((table[0, 2] == table[1, 1]) && (table[2, 0] == currentMove)) && (table[0, 2] == table[2, 0]))
            {
                return true;
            }
            return false;

        }
        public bool GameIsOver()
        {
            return countMove == 0;
        }
    }
}
