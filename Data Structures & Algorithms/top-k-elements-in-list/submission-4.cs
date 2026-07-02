public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> hashTable = new();
        int max = 0;
        foreach(int i in nums)
        {
            if(!hashTable.ContainsKey(i))
            {
                hashTable[i] = 0;
            }
            hashTable[i] += 1;
            if(hashTable[i] > max)
            {
                max = hashTable[i];
            }
        }

        if(max <= 0)
        {
            return new int[0];
        }

        List<int>[] frequency = new List<int>[max + 1];
        foreach(KeyValuePair<int, int> hashElement in hashTable)
        {
            if(frequency[hashElement.Value] == null)
            {
                frequency[hashElement.Value] = new();
            }
            frequency[hashElement.Value].Add(hashElement.Key);
        }

        List<int> result = [];
        for(int i = max; i>=0; i--)
        {
            if(frequency[i] == null || frequency[i].Count() <= 0)
            {
                continue;
            }
            if(k <= 0)
            {
                break;
            }
            foreach(int j in frequency[i])
            {
                result.Add(j);
                k -= 1;
            }
        }

        return result.ToArray();
    }
}
