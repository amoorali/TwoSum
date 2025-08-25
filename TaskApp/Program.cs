namespace TaskSolution
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please run the `dotnet test` CLI to check the test cases.");
        }

        public static List<int[]> TwoSum_List(int[] nums, int target)
        {
            var result = new List<int[]>();
            for (int i = 0; i < nums.Length; i++)
            {
                var temp = target - nums[i];
                Console.WriteLine($"{temp}, {target}, {nums[i]}");
                var n2 = Array.IndexOf(nums, temp, i + 1);
                if (n2 >= 0) result.Add(new int[] { i, n2 });
            }

            return result;
        }

        public static List<int[]> TwoSum_BruteForce(int[] nums, int target)
        {
            var result = new List<int[]>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.Add(new int[] { i, j });
                    }
                }
            }
            return result;
        }

        public static List<int[]> TwoSum_Dictionary(int[] nums, int target)
        {
            var result = new List<int[]>();
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var temp = target - nums[i];
                if (dict.ContainsKey(temp)) result.Add(new int[] { dict[temp], i });
                if (!dict.ContainsKey(nums[i])) dict.Add(nums[i], i);
            }
            return result;
        }
    }
}