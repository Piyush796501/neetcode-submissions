public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freq=new Dictionary<int,int>();
        int n=nums.Length;
        for(int i=0;i<n;i++)
        {
          if(freq.ContainsKey(nums[i]))
          {
            freq[nums[i]]++;
          }
          else
             freq[nums[i]]=1;
        }
        var sortedMap = freq.OrderByDescending(x => x.Value);
        int[] res=new int[k];
        int count=0;
        foreach (var item in sortedMap)
        {
           
           res[count]=item.Key;
           count++;
           if(count==k)
             break;
           
        }
        return res;

    }
}
