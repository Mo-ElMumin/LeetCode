public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0; 

        for (int i = 0; i < prices.Length; i++) // single pass through
        {
            if (prices[i] < minPrice) // lower than lowest price
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit)
            {
                maxProfit =  prices[i] - minPrice;
            }
        } 
        
        return maxProfit;
    }
}
