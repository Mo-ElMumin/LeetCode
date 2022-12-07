public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        Queue<int> values = new Queue<int>();
        int count;  
            
        foreach (int i in nums)
        {
            if (!values.Contains(i))
            {
                values.Enqueue(i);
            }
        }
        
        count = values.Count;
        
        Array.Clear(nums);
        
        for (int i = 0; i < count; i++)
        {
            nums[i] = values.Dequeue();
        }
        
        return count;
    }
}
