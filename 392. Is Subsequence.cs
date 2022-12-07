public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        
        if (s == String.Empty)
        {
            return true; 
        } 
        
        int pos = 0;
        foreach(char i in t)
        {
            if (i == s[pos] && pos < s.Length)
            {
                pos++;
                if (pos == s.Length)
                {
                    return true;
                }   
            }
        }
        
        if (pos == s.Length)
        {
            return true;
        }
        return false;
    }
}
