using System;

namespace MinimaxAlg
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = { { '-', 'o', 'x'},
                              { '-', 'o', '-'},
                              { 'x', '-', '-'} };

            int bestScore = int.MinValue;
            int moveI = -1;
            int moveJ = -1;

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (board[i, j] == '-')
                    {
                        board[i, j] = 'o';
                        var score = Minimax(board, 'x');
                        board[i, j] = '-';

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
            board[moveI, moveJ] = 'p';

            foreach (var i in board)
            {
                Console.WriteLine(i);
            }
        }


        static int CheckWhoWins(char[,] board, char forWho)
        {
            if ((board[0, 0] == forWho && board[0, 1] == forWho && board[0, 2] == forWho)
                || (board[1, 0] == forWho && board[1, 1] == forWho && board[1, 2] == forWho)
                || (board[2, 0] == forWho && board[2, 1] == forWho && board[2, 2] == forWho)
                || (board[0, 0] == forWho && board[1, 0] == forWho && board[2, 0] == forWho)
                || (board[0, 1] == forWho && board[1, 1] == forWho && board[2, 1] == forWho)
                || (board[0, 2] == forWho && board[1, 2] == forWho && board[2, 2] == forWho)
                || (board[0, 0] == forWho && board[1, 1] == forWho && board[2, 2] == forWho)
                || (board[0, 2] == forWho && board[1, 1] == forWho && board[2, 0] == forWho))
            {
                var score = 1;
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (board[i, j] == '-')
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
        static int Minimax(char[,] board, char forWho)
        {
            var score = CheckWhoWins(board, forWho);
            if (score != 0)
            {
                return score;
            }

            if (forWho == 'o')
            {
                var bestScore = int.MinValue;
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (board[i, j] == '-')
                        {
                            board[i, j] = forWho;
                            var currentScore = Minimax(board, 'x');
                            board[i, j] = '-';

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
                        if (board[i, j] == '-')
                        {
                            board[i, j] = forWho;
                            var currentScore = Minimax(board, 'o');
                            board[i, j] = '-';

                            bestScore = Math.Min(bestScore, currentScore);
                        }
                    }
                }
                return bestScore;
            }
        }
    }
}