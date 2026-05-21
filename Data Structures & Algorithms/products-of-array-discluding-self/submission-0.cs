public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n=nums.Length;
        int[] prefix=new int[n];
        int[] suffix=new int[n];
        int[] result=new int[n];
        int res=1;
        for(int i=0;i<n;i++)
        {
            
            if(i==0)
             prefix[i]=1;
            else
              prefix[i]=res;
            res*=nums[i];
        }
        res=1;
        for(int i=n-1;i>=0;i--)
        {
            
            if(i==n-1)
             suffix[i]=1;
            else
              suffix[i]=res;
            res*=nums[i];
        }
        for(int i=0;i<n;i++)
        {
            result[i]=prefix[i]*suffix[i];
        }
return result;
    }
}
