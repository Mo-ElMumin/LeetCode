public class Solution {
    public int ClimbStairs(int n) {
        if (n < 3) { return n; }
        
        int[] values = new int[n];
        values[0] = 1;
        values[1] = 2;

        for (int i = 2; i < n; i++) 
        {
            values[i] = values[i-1] + values[i-2];
        }

        return values[n - 1];
    }
}
