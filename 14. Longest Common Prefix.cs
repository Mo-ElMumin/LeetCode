public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        // 
        char[] common_prefix = {}; 
        // pick one word i.e first word, convert to chars 
        char[] cWord = strs[0].ToCharArray(); 
        bool end = false; 
        for (int i = 0; i < cWord.Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                char[] cNext = strs[j].ToCharArray();
                if (i + 1 > cNext.Length || cWord[i] != cNext[i])
                {
                    end = true; 
                    break; 
                }
            }
            if (!end)
            {
                common_prefix = common_prefix.Append(cWord[i]).ToArray();
            }
            else
            {
                break; 
            }
        }
        
        string prefix = new string(common_prefix); 
        return prefix; 
        
    }
}
