public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict=new Dictionary<int,int>();
        int difference=0;
        int n=nums.Length,k;
        int[] res=new int[2];
        
        
        for(int i=0;i<n;i++)
        {
          difference=target-nums[i];
          if(dict.ContainsKey(difference))
          {
            Console.WriteLine(dict[difference]+"result "+i);
            return new int[2]{dict[difference],i};
          }
          if(!dict.ContainsKey(nums[i]))
          {
            Console.WriteLine(nums[i]+"res "+i);
            dict.Add(nums[i],i);
          }
        }
        return new int[2];

    }
}
