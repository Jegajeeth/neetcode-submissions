public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        HashSet<string> checkedString = new();
        List<List<string>> outputFormate = new();
        for (int i = 0; i < strs.Count(); i++) {
            if(checkedString.Contains(strs[i]))
            {
                continue;
            }
            List<string> resultAnagSort = new() {strs[i]};
            int[] alfaArrParent = new int[26];

            foreach(char c in strs[i])
            {
                alfaArrParent[c - 'a'] += 1;
            } 
            for(int j = i+1; j< strs.Count(); j++)
            {
                int[] alfaArrChild = new int[26];
                bool isCheckPass = true;
                foreach(char c in strs[j])
                {
                    alfaArrChild[c - 'a'] += 1;
                }
                for(int k = 0; k< 26; k++)
                {
                    if(alfaArrParent[k] != alfaArrChild[k])
                    {
                        isCheckPass = false;
                        break;
                    }
                }
                if(isCheckPass)
                {
                    resultAnagSort.Add(strs[j]);
                    checkedString.Add(strs[j]);
                }
            }
            outputFormate.Add(resultAnagSort);
        }
        return outputFormate;
    }
}
