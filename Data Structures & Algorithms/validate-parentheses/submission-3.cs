public class Solution {
    public bool IsValid(string s) {
        Stack<char> bracketStack = new();
        for(int i = 0; i<s.Length; i++){
            char strEle = s[i];

            if(strEle == '[' || strEle == '{' || strEle == '(')
            {
                bracketStack.Push(strEle);
                continue;
            }
            if(bracketStack.Count == 0)
            {
                return false;
            }
                char stackPeek = bracketStack.Peek();
                if(strEle == ']' && stackPeek == '[')
                {
                    bracketStack.Pop();
                }
                else if(strEle == '}' && stackPeek == '{')
                {
                    bracketStack.Pop();
                }
                else if(strEle == ')' && stackPeek == '(')
                {
                    bracketStack.Pop();
                }
                else 
                {
                    return false;
                }
        }
        if(bracketStack.Count > 0)
        {
            return false;
        }
        return true; 
    }
}

