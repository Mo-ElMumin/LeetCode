public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // define variables
        int[] answer = new int[2];
        int i, j;

        // loop through the digit in Nums Array
        for (i = 0; i < nums.Length; i++)
        {
            // loop through the remaining digits in Nums Array 
            for (j = i + 1; j < nums.Length; j++)
            {

                if (nums[i] + nums[j] == target)
                {
                    answer[0] = i;
                    answer[1] = j;
                }
            }
        }
        return answer;
    }
}
