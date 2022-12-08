public class Solution {
    public int Search(int[] nums, int target) {
        int answer = Array.BinarySearch(nums, target);
        bool valid = (answer < 0 || answer > nums.Length);
        return valid ? -1 : answer;
    }
}
