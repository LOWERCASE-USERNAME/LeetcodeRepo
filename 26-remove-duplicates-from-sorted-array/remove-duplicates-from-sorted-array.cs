public class Solution {
    // No need to track the last unique index of the current value. Only need to know when the value change since:
    // 1. It is sorted, so the changes mean that the i-pointer have reached the next desirable value
    // 2. We already know the index of where the value need to be inserted with k
    // => We know both the index and value.

    // public int RemoveDuplicates(int[] nums) {
    //     int k = 1;
    //     int lastUniqueIdx = 0;
    //     for(int i = 1; i < nums.Length; i++){
    //         if(nums[i] != nums[lastUniqueIdx]){
    //             nums[k++] = nums[i];
    //             lastUniqueIdx = i;
    //         }
    //     }
    //     return k;
    // }

    public int RemoveDuplicates(int[] nums) {
        int k = 1;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] != nums[i - 1]){
                nums[k++] = nums[i];
            }
        }
        return k;
    }
}