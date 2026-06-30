public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> arrayElements = new();
        for(int i = 0; i < nums.Count(); i++)
        {
            int element = nums[i];
            if(!arrayElements.ContainsKey(element))
            {
                arrayElements[element] = 1;
            }else
            {
                return true;
            }
        }
        return false;
    }
}