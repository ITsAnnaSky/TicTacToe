using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class ComputerPlayer : Player
    {
        public (int, int) Move(int[,] table)
        {
            return GetNextStep(table);
        }
        private (int, int) GetNextStep(int[,] table)
        {
            int bestScore = int.MinValue;
            int moveI = -1;
            int moveJ = -1;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (table[i, j] == -1)
                    {
                        table[i, j] = 0;
                        var score = Minimax(table, 1);
                        table[i, j] = -1;

                        Console.WriteLine("Score: " + score);
                        Console.WriteLine("BestScore: " + bestScore);


                        if (score > bestScore)
                        {
                            bestScore = score;
                            moveI = i;
                            moveJ = j;
                        }
                    }
                }
            }
            return (moveI, moveJ);

        }
        static int CheckWhoWins(int[,] table, int forWho)
        {
            if ((table[0, 0] == forWho && table[0, 1] == forWho && table[0, 2] == forWho)
                || (table[1, 0] == forWho && table[1, 1] == forWho && table[1, 2] == forWho)
                || (table[2, 0] == forWho && table[2, 1] == forWho && table[2, 2] == forWho)
                || (table[0, 0] == forWho && table[1, 0] == forWho && table[2, 0] == forWho)
                || (table[0, 1] == forWho && table[1, 1] == forWho && table[2, 1] == forWho)
                || (table[0, 2] == forWho && table[1, 2] == forWho && table[2, 2] == forWho)
                || (table[0, 0] == forWho && table[1, 1] == forWho && table[2, 2] == forWho)
                || (table[0, 2] == forWho && table[1, 1] == forWho && table[2, 0] == forWho))
            {
                var score = 1;
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (table[i, j] == -1)
                        {
                            score++;
                        }
                    }
                }
                return score;
            }
            else
                return 0;
        }
        static int Minimax(int[,] table, int forWho)
        {
            var score = CheckWhoWins(table, forWho);
            if (score != 0)
            {
                return score;
            }

            if (forWho == 0)
            {
                var bestScore = int.MinValue;
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (table[i, j] == -1)
                        {
                            table[i, j] = forWho;
                            var currentScore = Minimax(table, 'x');
                            table[i, j] = -1;

                            bestScore = Math.Max(bestScore, currentScore);
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                var bestScore = int.MaxValue;
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (table[i, j] == -1)
                        {
                            table[i, j] = forWho;
                            var currentScore = Minimax(table, 'o');
                            table[i, j] = -1;

                            bestScore = Math.Min(bestScore, currentScore);
                        }
                    }
                }
                return bestScore;
            }
        }
    }
}
