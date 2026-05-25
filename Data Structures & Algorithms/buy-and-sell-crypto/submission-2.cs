public class Solution {
    public int MaxProfit(int[] prices) {
        int min=prices[0],max=0;
        int n=prices.Length,maxo=0;
        for(int i=1;i<n;i++)
        {
           if(prices[i]<min)
           {
            min=prices[i];
           }
           else
           {
            max=Math.Max(max,prices[i]-min);
           }
            
        }
        return max;
    }
}
