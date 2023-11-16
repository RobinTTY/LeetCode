var solution = new Solution();
var result = solution.TwoSum(new[]{2, 7, 11, 15}, 9);
result.ToList().ForEach(Console.WriteLine);

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var num = target - nums[i];
            if (map.TryGetValue(num, out var index))
                return new[] {i, index};
            map[nums[i]] = i;
        }

        return new int[2];
    }
}
