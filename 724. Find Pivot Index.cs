public class Solution {
    public int PivotIndex(int[] nums) {
        int rSum = nums.Sum();
        int lSum = 0; 
        
        for (int i = 0; i < nums.Length; i++)
        {  
            rSum -= nums[i];
            if (rSum == lSum)
            {
                return i;
            }
            lSum += nums[i];
        } 
        return -1; 
        
        
    }
}
