public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> consecutiveSequence = new(nums);
        int longLen = 1;
        foreach(int num in nums)
        {
            if(consecutiveSequence.Contains(num+1))
            {
                int len = 1;
                while(consecutiveSequence.Contains(num + len))
                {
                    len += 1;
                }

                if(len > longLen)
                {
                    longLen = len;
                }
            }

        }
    return longLen;        
    }
}
