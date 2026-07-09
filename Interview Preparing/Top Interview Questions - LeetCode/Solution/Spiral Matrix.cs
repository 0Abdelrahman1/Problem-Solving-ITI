public class Spiral_Matrix
{
    public IList<int> SpiralOrder(int[][] M)
    {
        int ii = M.Length - 1, jj = M[0].Length - 1;
        List<int> ret = new();
        int i = 0, j = 0;
        while (i < ii && j < jj)
        {
            for (int k = j; k < jj; k++) ret.Add(M[i][k]);
            for (int k = i; k < ii; k++) ret.Add(M[k][jj]);
            for (int k = jj; k > j; k--) ret.Add(M[ii][k]);
            for (int k = ii; k > i; k--) ret.Add(M[k][j]);
            i++; j++;
            ii--; jj--;
        }
        if (i == ii)
            for (int k = j; k <= jj; k++) ret.Add(M[i][k]);
        else if (j == jj)
            for (int k = i; k <= ii; k++) ret.Add(M[k][jj]);
        return ret;
    }
}
