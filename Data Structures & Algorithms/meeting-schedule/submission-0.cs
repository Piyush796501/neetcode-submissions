/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
    intervals.Sort((a,b)=>a.start.CompareTo(b.start));
     int n=intervals.Count;
      for(int i=0;i<n-1;i++)
      {
        var elem=intervals[i];
        var elem2=intervals[i+1];
        if(elem.end>elem2.start)
          return false;
      }
      return true;
    }
}
