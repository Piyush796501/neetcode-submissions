public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals.Length==0)
          return new int[0][];
        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));

        var merged=new List<int[]>(){intervals[0]};
        foreach(var curr in intervals.Skip(1))
        {
            var last=merged[merged.Count-1];
            if(curr[0]<=last[1])
             last[1]=Math.Max(last[1],curr[1]);
            else
              merged.Add(curr);
        }
       return merged.ToArray();
    }
}
