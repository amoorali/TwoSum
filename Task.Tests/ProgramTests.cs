namespace TaskSolution
{
    public class ProgramTests
    {
        // Helper function to convert integer array to an array of integers.
        private static List<(int i, int j)> ToPairs(List<int[]> nums)
            => nums.Select(n => (n[0], n[1])).ToList();

        [Fact]
        public void SinglePairListTest()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = Program.TwoSum_List(nums, target);
            var expected = new List<(int i, int j)> { (0, 1) };
            Assert.Equal(expected, ToPairs(result));
        }

        [Fact]
        public void MultiplePairsListTest()
        {
            var nums = new int[] { 3, 2, 4, 3 };
            var target = 6;
            var result = Program.TwoSum_List(nums, target);
            var expected = new List<(int i, int j)> { (0, 3), (1, 2)};
            Assert.Equal(expected, ToPairs(result));
        }

        [Fact]
        public void SinglePairBruteForceTest()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = Program.TwoSum_BruteForce(nums, target);
            var expected = new List<(int i, int j)> { (0, 1) };
            Assert.Equal(expected, ToPairs(result));
        }

        [Fact]
        public void MultiplePairsBruteForceTest()
        {
            var nums = new int[] { 3, 2, 4, 3 };
            var target = 6;
            var result = Program.TwoSum_BruteForce(nums, target);
            var expected = new List<(int i, int j)> { (0, 3), (1, 2)};
            Assert.Equal(expected, ToPairs(result));
        }

        [Fact]
        public void SinglePairDictionaryTest()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = Program.TwoSum_Dictionary(nums, target);
            var expected = new List<(int i, int j)> { (0, 1) };
            Assert.Equal(expected, ToPairs(result));
        }

        [Fact]
        public void MultiplePairsDictionaryTest()
        {
            var nums = new int[] { 3, 2, 4, 3 };
            var target = 6;
            var result = Program.TwoSum_Dictionary(nums, target);
            var expected = new List<(int i, int j)> { (1, 2), (0, 3) };
            Assert.Equal(expected, ToPairs(result));
        }
    }
}
