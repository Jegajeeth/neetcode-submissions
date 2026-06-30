public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        
        List<char> strEles = new();

        for(int i = 0; i < s.Length; i++)
        {
            strEles.Add(s[i]);
        }

        for(int j = 0;j < t.Length; j++)
        {
            strEles.Remove(t[j]);
        }

        if(strEles.Count() > 0)
        {
            return false;
        }

        return true;
    }
}
