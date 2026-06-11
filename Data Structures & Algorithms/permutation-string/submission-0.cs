public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        string sorteds1=string.Concat(s1.OrderBy(c=>c));
        int i=0,j=s1.Length;
        while(i<=(s2.Length-s1.Length))
        {
            string str=s2.Substring(i,s1.Length);
            string sorted2=string.Concat(str.OrderBy(c=>c));
            if(sorted2==sorteds1)
             return true;
            i++;
        }            
        return false;
    }
}
