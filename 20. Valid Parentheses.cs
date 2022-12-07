public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> bStack = new Stack<char>();
        IDictionary<char, char> pairs = new Dictionary<char, char>() { { ')' , '(' } , { '}' , '{' } , { ']' , '[' } ,};
                
        foreach (char i in s)
        {
            if (!pairs.ContainsKey(i))
            {
                bStack.Push(i);
            } 
            else
            {
                if (bStack.Count == 0 || bStack.Peek() != pairs[i] )
                {
                    return false;
                }
                else
                {
                    bStack.Pop(); 
                }    
            } 
        } // end for 
        
        if (bStack.Count == 0)
        {
            return true;
        }
        return false;      
    }
}
