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
    }
}
