using System;
using System.Collections.Generic;
using System.Text;

public class valid_sudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        bool[,] row = new bool[9, 9], col = new bool[9, 9];
        bool[,,] box = new bool[3, 3, 9];

        for (int i = 0; i < 9; i++)
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] == '.') continue;
                int x = board[i][j] - '1';
                
                if (row[i, x]) return false;
                else row[i, x] = true;
                
                if (col[j, x]) return false;
                else col[j, x] = true;

                if (box[i / 3, j / 3, x]) return false;
                else box[i / 3, j / 3, x] = true;
            }
        return true;
    }
}
