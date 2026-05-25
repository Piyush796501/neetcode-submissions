public class Solution {
    public int MaxProfit(int[] prices) {
        int min=prices[0],max=prices[0];
        int n=prices.Length,maxo=0;
        for(int i=1;i<n;i++)
        {
            if(min>prices[i])
            {
              min=prices[i];
              max=prices[i];
            }
            else if(max<prices[i])
             max=prices[i];
           if(maxo<(max-min))
             maxo=max-min;
            
        }
        return maxo;
    }
}
