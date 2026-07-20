class Climbing_Stairs
{
    public int ClimbStairs(int n)
    {
        int x = 1, y = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            x = x + y;
            (x, y) = (y, x);
        }
        return y;
    }

    public int ClimbStairs1(int n)
    {
        int[][] MM(int[][] M, int[][] N) // Matrix Multiplication For 2x2 Matrices
        {
            return [[M[0][0] * N[0][0] + M[0][1] * N[1][0], M[0][0] * N[0][1] + M[0][1] * N[1][1]],
                    [M[1][0] * N[0][0] + M[1][1] * N[1][0], M[1][0] * N[0][1] + M[1][1] * N[1][1]]];
        }

        int[][] MP(int[][] M, int p)
        {
            if (p == 0) return [[1, 0], [0, 1]];
            var SM = MP(M, p / 2);
            if ((p & 1) == 1)
                return MM(MM(SM, SM), M);
            return MM(SM, SM);
        }

        return MM(MP([[0, 1], [1, 1]], n - 1), [[1, 0], [1, 0]])[1][0];
    }

}
