public class Solution {
    public int LengthOfLastWord(string s) 
    {
        string[] words = s.TrimEnd().Split();
        return words[words.Length - 1].Length; 
    }
}
