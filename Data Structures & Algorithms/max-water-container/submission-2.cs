public class Solution {
    public int MaxArea(int[] heights) {
       int n=heights.Length,result=0,max=0;
       int i=0,j=n-1,count=n-1;

       while(i<j)
       {
          //Console.WriteLine(i+ " resukt "+j);
        if(heights[i]<=heights[j])
        {
            result=heights[i]*count;
            i++;
        }
        else if(heights[i]>heights[j])
        {
          result=heights[j]*count;
            j--;
        }
        //Console.WriteLine(i+ " resukt "+j);
        if(max<result)
         max=result;
        count--;
       } 
       return max;
    }
}

