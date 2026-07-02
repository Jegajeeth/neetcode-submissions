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

        var sortedResultValues = hashTable.OrderByDescending(dict => dict.Value)
        .Select(dict => dict.Key)
        .ToArray()[0..k];

        return sortedResultValues;
    }
}
