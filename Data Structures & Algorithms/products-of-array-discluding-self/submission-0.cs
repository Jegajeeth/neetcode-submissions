public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        if(nums.Length == 0)
        {
            return [];
        }

        int totalMultipleValue = 1;
        bool isOneZeroElement = false;
        int[] elementProductHeep = new int[nums.Length];
        int indexOfZeroValue = -1;

        for(int i = 0; i < nums.Length; i++)
        {
            int numsElement = nums[i];
            if(numsElement == 0)
            {
                if(isOneZeroElement)
                {
                    return new int[nums.Length];
                }
                else
                {
                    isOneZeroElement = true;
                    elementProductHeep[i] = numsElement;
                    indexOfZeroValue = i;
                    continue;
                }
            }
            totalMultipleValue *= numsElement;
            elementProductHeep[i] = numsElement;
        }

        int[] result = new int[nums.Length];
        if(isOneZeroElement)
        {
            result[indexOfZeroValue] = totalMultipleValue;
            return result;
        }

        for(int i = 0; i < elementProductHeep.Length; i++)
        {
            result[i] = totalMultipleValue / elementProductHeep[i];
        }
        return result;
    }
}
