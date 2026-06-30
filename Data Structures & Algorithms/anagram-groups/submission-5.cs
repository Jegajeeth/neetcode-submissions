public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> resultAnagSort = new();
        HashSet<string> checkedString = new();
        for (int i = 0; i < strs.Count(); i++) {
            if(checkedString.Contains(strs[i]))
            {
                continue;
            }
            if(!resultAnagSort.ContainsKey(strs[i]))
            {
                resultAnagSort[strs[i]] = new() {strs[i]};
            }
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
                    resultAnagSort[strs[i]].Add(strs[j]);
                    checkedString.Add(strs[j]);

                }
            }
            
            // if(checkedString.Contains(strs[i]))
            // {
            //     continue;
            // }

            // resultAnagSort[asciiInt] = new() { strs[i] };

            // for (int j = i + 1; j < strs.Count(); j++) {

                
            //     if (checkAsciiInt == asciiInt) {
            //         resultAnagSort[asciiInt].Add(strs[j]);
            //         checkedString.Add(strs[j]);
            //     }
            // }
        }

        List<List<string>> outputFormat = new();
        foreach (KeyValuePair<string, List<string>> anagPairs in resultAnagSort) {
            outputFormat.Add(anagPairs.Value);
        }
        return outputFormat;
    }
}
