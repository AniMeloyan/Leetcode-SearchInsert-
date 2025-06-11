using System;
public class Solution {
    public int SearchInsert (int[] nums, int target)
    {
        for(int i = 0; i < nums.Length; i++) {
            if (nums[i] >= target) {
                return i;
            }
        }
        
        return nums.Length;
    }
}


class Program {
  static void Main() {
    Solution sol = new Solution();
    int[] nums = {1, 3, 5, 6};
    Console.WriteLine(sol.SearchInsert(nums, 5)); 
    Console.WriteLine(sol.SearchInsert(nums, 2)); 
    Console.WriteLine(sol.SearchInsert(nums, 7)); 
    Console.WriteLine(sol.SearchInsert(nums, 0)); 
  }
}