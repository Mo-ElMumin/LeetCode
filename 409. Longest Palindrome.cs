public class Solution {
    public int LongestPalindrome(string s) 
    {
        Dictionary<char, char> letters = new Dictionary<char, char>();
        int pairs = 0; 

        for (int i = 0; i < s.Length; i++)
        {
            if (letters.ContainsKey(s[i]))
            {
                letters.Remove(s[i]);
                pairs++;
            }
            else
            {
                letters.Add(s[i], s[i]);
            }
        } // end for 

        if (letters.Count > 0)
        {
            return pairs * 2 + 1;
        }
        return pairs * 2;
    }
}
