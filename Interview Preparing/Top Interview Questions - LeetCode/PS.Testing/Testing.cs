namespace PS.Testing
{
    public class Testing
    {
        [Fact]
        public void Test()
        {
            var tst = new Solution();
            int[] n1 = [1, 2, 3, 0, 0, 0];
            tst.Merge(n1, 3, [2, 5, 6], 3);
            Assert.Equal([1, 2, 2, 3, 5, 6], n1);
        }

    }
}
