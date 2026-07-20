public class Word_Search
{
    public bool Exist(char[][] board, string word)
    {
        int n = board.Length + 2, m = board[0].Length + 2;
        board = [new char[m], .. board.Select(r => (char[])['\0', .. r, '\0']), new char[m]];

        bool Solve(int x, int y, int s)
        {
            if (s == word.Length - 1) return true;
            board[x][y] ^= char.MaxValue;
            if (board[x - 1][y] == word[s + 1] && Solve(x - 1, y, s + 1)) return true;
            if (board[x + 1][y] == word[s + 1] && Solve(x + 1, y, s + 1)) return true;
            if (board[x][y - 1] == word[s + 1] && Solve(x, y - 1, s + 1)) return true;
            if (board[x][y + 1] == word[s + 1] && Solve(x, y + 1, s + 1)) return true;
            board[x][y] ^= char.MaxValue;
            return false;
        }

        for (int i = 1; i < n; i++)
            for (int j = 1; j < m; j++)
                if (board[i][j] == word[0] && Solve(i, j, 0))
                    return true;
        return false;
    }
}
