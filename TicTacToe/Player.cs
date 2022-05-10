using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public interface Player
    {
        public (int,int) Move(int[,] table);
        
    }
}
