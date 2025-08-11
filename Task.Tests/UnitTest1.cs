namespace TaskSolution
{
    public class UnitTest1
    {
        // Helper function to convert integer array to an array of integers.
        private static List<(int i, int j)> ToPairs(List<int[]> nums)
            => nums.Select(n => (n[0], n[1])).ToList();

        [Fact]
        public void SinglePairTest()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = Program.TwoSum(nums, target);
            var expected = new List<(int i, int j)> { (0, 1) };
            Assert.Equal(expected, ToPairs(result));
        }

        [Fact]
        public void MultiplePairsTest()
        {
            var nums = new int[] { 3, 2, 4, 3 };
            var target = 6;
            var result = Program.TwoSum(nums, target);
            var expected = new List<(int i, int j)> { (0, 3), (1, 2)};
            Assert.Equal(expected, ToPairs(result));
        }
    }
}
