namespace TaskSolution
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please run the `dotnet test` CLI to check the test cases.");
        }

        public static List<int[]> TwoSum(int[] nums, int target)
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
    }
}