public partial class Solution
{
    public void Rotate(int[][] matrix)
    {
        int n = matrix.Length;

        int ii = n / 2;
        for (int i = 0; i < ii; i++)
            for (int j = i, jj = n - i - 1; j < jj; j++)
            {
                (int cx, int cy) = (j, n - 1 - i);
                int tmp = matrix[i][j];
                while ((cx, cy) != (i, j))
                {
                    (tmp, matrix[cx][cy]) = (matrix[cx][cy], tmp);
                    (cx, cy) = (cy, n - cx - 1); 
                }
                (tmp, matrix[cx][cy]) = (matrix[cx][cy], tmp);
            }
    }

    public void Rotate1(int[][] M)
    {
        int n = M.Length;

        int ii = n >> 1, jj = n - ii;
        for (int i = 0; i < ii; i++)
            for (int j = 0; j < jj; j++)
                (M[i][j], M[j][^(i + 1)], M[^(i + 1)][^(j + 1)], M[^(j + 1)][i]) =
                    (M[^(j + 1)][i], M[i][j], M[j][^(i + 1)], M[^(i + 1)][^(j + 1)]);
    }
}
