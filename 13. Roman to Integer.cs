public class Solution {
    public int RomanToInt(string s) 
    {
        var rDict = new Dictionary<char, int>() {{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000} };
        s = s.Replace("IV", "IIII").Replace("IX", "VIIII").Replace("XL", "XXXX").Replace("XC", "LXXXX").Replace("CD", "CCCC").Replace("CM", "DCCCC");
        char[] roman = s.ToCharArray();        
        int number = 0; 
        foreach (char C in roman) 
        { 
          number += rDict[C]; 
         }
        return number; 
    }
}
