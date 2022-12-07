public class Solution {
    
    // recursive code 
    public bool IsPalindrome(int x) {
        string xStr = x.ToString();
        for (int i = 0; i < xStr.Length / 2; i++)
        {
            if (xStr[i] != xStr[xStr.Length-i-1])
            {
                return false;
            }
        }
        return true;
    }
}
