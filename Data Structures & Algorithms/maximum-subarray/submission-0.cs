public class Solution {
    public int MaxSubArray(int[] nums) {
        int n=nums.Length,max=-999999999,sum=0;
        for(int i=0;i<n;i++)
        {
            sum+=nums[i];
            
            max=Math.Max(max,sum);
            if(sum<0)
               sum=0;
        }
        return max;
    }
}
