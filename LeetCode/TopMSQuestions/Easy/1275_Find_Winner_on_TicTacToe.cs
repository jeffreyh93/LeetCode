using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TopMSQuestions.Easy
{
    public class _1275_Find_Winner_on_TicTacToe
    {
        /**
         * Algorithms:
         * 
         * 1. Brute Force - evaluate the board after every movement placed on the grid
         *      - place the movement on the grid
         *      - evaluate the rows / cols / diags, check if there's a win
         *      - after every move is placed, determine if it's a draw or pending
         * 2. Optimized - only need to track winning rows, cols, diags
         *      - for each move placed, add the player's value to that row / col / diag
         *      - if at any point any of the array absolute values add up to the number of rows/cols then that's a win
         */ 
        public string TicTacToe_Brute(int[][] moves) {
            int[,] grid = new int[3, 3];
            for (int i = 0; i < moves.Length; i++) {
                int player = i % 2 == 0 ? 1 : 2;
                if (grid[moves[i][0], moves[i][1]] != 0) return "Invalid";

                grid[moves[i][0], moves[i][1]] = player;

                // evaluate the grid's rows/cols
                for (int j = 0; j < 3; j++) {
                    if (grid[0, j] != 0 && grid[0, j] == grid[1, j] && grid[1, j] == grid[2, j]) return grid[0, j] == 1 ? "A" : "B";
                    if (grid[j, 0] != 0 && grid[j, 0] == grid[j, 1] && grid[j, 1] == grid[j, 2]) return grid[j, 0] == 1 ? "A" : "B";
                }

                // evaluate the diags
                if (grid[0, 0] != 0 && grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2]) return grid[0, 0] == 1 ? "A" : "B";
                if (grid[2, 0] != 0 && grid[2, 0] == grid[1, 1] && grid[1, 1] == grid[0, 2]) return grid[1, 1] == 1 ? "A" : "B";
            }

            return moves.Length == 3 * 3 ? "Draw" : "Pending";
        }

        public string TicTacToe_Optimal(int[][] moves) {
            int n = 3;
            int[] rows = new int[n];
            int[] cols = new int[n];
            int diag = 0;
            int aDiag = 0;

            for (int i = 0; i < moves.Length; i++) {
                int player = i % 2 == 0 ? 1 : -1;
                int r = moves[i][0];
                int c = moves[i][1];

                rows[r] += player;
                cols[c] += player;

                if (r == c) diag += player;
                if (r + c == n - 1) aDiag += player;

                if (Math.Abs(rows[r]) == n || Math.Abs(cols[c]) == n || Math.Abs(diag) == n || Math.Abs(aDiag) == n) {
                    return player == 1 ? "A" : "B";
                }
            }

            return moves.Length == n * n ? "Draw" : "Pending";
        }
    }
}
