public class Solution {
    public bool IsIsomorphic(string s, string t) 
    {
        Dictionary<char, char> pairs = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (pairs.ContainsKey(s[i])) // preexisting pair is found
            {
                if (pairs[s[i]] != t[i]) // if pair does not match return false
                {
                    return false;
                }
                
                // is pair found and matches; continue 
            }
            else // no pair found
            {
                if (pairs.ContainsValue(t[i]))
                {
                    return false;            
                }
                pairs.Add(s[i], t[i]); // else add a pair
            }
            
        } // end for 
        
        return true;
    }
}
