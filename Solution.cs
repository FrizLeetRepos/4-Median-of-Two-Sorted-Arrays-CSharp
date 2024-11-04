public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var nums = nums1.Concat(nums2).ToArray();
        Array.Sort(nums);
        var length = nums.Length;
        if (length > 0 && length % 2 == 0) {
            //even
            return (nums[length / 2] + nums[length / 2 - 1]) / 2.0;
        } else {
            //odd
            return nums[length / 2];
        }
    }
}