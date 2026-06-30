public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> checkedElements = new();

        for(int i = 0; i < nums.Count(); i++)
        {
            int ele = nums[i];
            if(checkedElements.ContainsKey(ele))
            {
                return [checkedElements[ele], i];
            }
            int diff = target - ele;
            checkedElements.Add(diff, i);
        }
        return [];
    }
}
