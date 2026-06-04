public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
       var result=new List<int[]>();
        int n=intervals.Length;

        int i=0;
        //before;
        while(i<n && intervals[i][1]<newInterval[0])
          result.Add(intervals[i++]);
        //overlapp
        while(i<n && intervals[i][0]<=newInterval[1])
         {
            newInterval[0]=Math.Min(intervals[i][0],newInterval[0]);
            newInterval[1]=Math.Max(intervals[i][1],newInterval[1]);
            i++;
         }
         result.Add(newInterval);

         //after
         while(i<n)
            result.Add(intervals[i++]);
        
        return result.ToArray();
    }
}
