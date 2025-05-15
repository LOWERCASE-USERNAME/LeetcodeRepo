public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numSet = new();
        foreach(int num in nums){
            if(numSet.Contains(num)){
                return true;
            }
            numSet.Add(num);
        }
        return false;
    }
}