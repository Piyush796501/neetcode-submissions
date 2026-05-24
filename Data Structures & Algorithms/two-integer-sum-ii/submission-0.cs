public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n=numbers.Length;
        int i=0,j=n-1,sum=0;
        while(i<j)
        {
            sum=numbers[i]+numbers[j];
            if(sum==target)
             return new int[]{i+1,j+1};
            if(sum<target)
            {
                i++;
            }
            if(sum>target)
             j--;
            
        }
        return new int[2];
    }
}
