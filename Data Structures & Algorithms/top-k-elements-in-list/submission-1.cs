public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> hashTable = new();
        foreach(int i in nums)
        {
            if(!hashTable.ContainsKey(i))
            {
                hashTable[i] = 0;
            }
            hashTable[i] += 1;
        }

        var sortedvalues = hashTable.OrderByDescending(dict => dict.Value).Select(dict => dict.Key);
        int[] result = new int[k];
        while(--k >= 0)
        {
            result[k] = sortedvalues.ElementAt(k);
        }

        return result;
    }
}
