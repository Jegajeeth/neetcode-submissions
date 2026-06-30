public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        
        int[] alfaSArr = new int[26];
        int[] alfaTArr = new int[26];

        for(int i = 0; i < s.Length; i++)
        {
            alfaSArr[s[i] - 'a'] += 1;
            alfaTArr[t[i] - 'a'] += 1;
        }
        
        for(int i = 0; i < 26; i++)
        {
            if(alfaSArr[i] != alfaTArr[i])
            {
                return false;
            }
        }

        return true;
    }
}
