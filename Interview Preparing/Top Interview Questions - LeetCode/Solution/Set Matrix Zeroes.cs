public partial class Solution
{
    public void SetZeroes(int[][] M)
    {
        int n = M.Length, m = M[0].Length;
        bool[] cz = new bool[m], rz = new bool[n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (M[i][j] == 0)
                    cz[j] = rz[i] = true;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (cz[j] || rz[i])
                    M[i][j] = 0;
    }

    public void SetZeroes1(int[][] M)
    {
        int n = M.Length, m = M[0].Length;
        bool fr = false, fc = false;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (M[i][j] == 0)
                {
                    if (i == 0) fr = true;
                    if (j == 0) fc = true;
                    M[0][j] = M[i][0] = 0;
                }
        for (int i = n - 1; i >= 0; i--)
            for (int j = m - 1; j >= 0; j--)
                if (i * j == 0)
                    M[i][j] = i == 0 && fr || j == 0 && fc ? 0 : M[i][j];
                else if (M[i][0] == 0 || M[0][j] == 0)
                    M[i][j] = 0;
    }
}
