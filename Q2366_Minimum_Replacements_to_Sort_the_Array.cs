public class Solution {
    public long MinimumReplacement(int[] nums) {
        long operations = 0;
        long prev_bound = nums[^1];
        
        for (int i = nums.Length - 2; i >= 0; i--) {
            long num = nums[i];
            long no_of_times = (num + prev_bound - 1) / prev_bound;
            operations += no_of_times - 1;
            prev_bound = num / no_of_times;
        }
        return operations;
    }
}