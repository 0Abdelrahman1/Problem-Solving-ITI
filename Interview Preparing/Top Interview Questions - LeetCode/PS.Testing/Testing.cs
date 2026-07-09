namespace PS.Testing
{
    public class Testing
    {
        [Fact]
        public void PermutationsTest()
        {
            var tst = new Permutations();
            Assert.Equal([[1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]], tst.Permute1([1,2,3]));
        }

        [Fact]
        public void RotateTest()
        {
            var tst = new Rotate_Image();
            tst.Rotate([[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]]);
            tst.Rotate([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);
            Assert.True(false);
        }

    }
}
