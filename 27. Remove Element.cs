public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int pos = 0; 
        foreach (int i in nums)
        {
            if (i != val)
            {
                nums[pos] = i;
                pos++;
            }
        }
        return pos;
    }
}
