public class Solution {
    public int SingleNumber(int[] nums) {
        int ans = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            ans ^= nums[i]; // Bitwise XOR each array elemnt so that at last only the element that appears once remains
        }
        return ans;
    }
}
