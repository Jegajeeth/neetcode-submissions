public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> resultAnagSort = new();
        HashSet<string> checkedString = new();
        List<List<string>> outputFormate = new();
        for (int i = 0; i < strs.Count(); i++) {
            if(checkedString.Contains(strs[i]))
            {
                continue;
            }
            int[] alfaArrParent = new int[26];

            foreach(char c in strs[i])
            {
                alfaArrParent[c - 'a'] += 1;
            } 
            string parentKey = string.Join(",", alfaArrParent);
            if(!resultAnagSort.ContainsKey(parentKey))
            {
                resultAnagSort[parentKey] = new() {strs[i]};
            }
            for(int j = i+1; j< strs.Count(); j++)
            {
                int[] alfaArrChild = new int[26];
                foreach(char c in strs[j])
                {
                    alfaArrChild[c - 'a'] += 1;
                }
                
                string childKey = string.Join(",", alfaArrChild);
                if(string.Equals(childKey, parentKey))
                {
                    resultAnagSort[childKey].Add(strs[j]);
                    checkedString.Add(strs[j]);
                }
            }
            outputFormate.Add(resultAnagSort[parentKey]);
        }
        return outputFormate;
    }
}
