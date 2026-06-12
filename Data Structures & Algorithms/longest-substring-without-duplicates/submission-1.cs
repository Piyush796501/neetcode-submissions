public class Solution {
    public int LengthOfLongestSubstring(string s) {
      
      char[] chArray=s.ToCharArray();
      string res="";
      //res+=chArray[0];
      char ch,count;
      int n=chArray.Length,max=0;
      for(int i=0;i<n;i++)
      {
        if(!res.Contains(chArray[i]))
        {
            
          res+=chArray[i];
          Console.WriteLine("result "+res);
        }
        else
        {
            max=Math.Max(max,res.Length);
            res+=chArray[i];
            ch=chArray[i];
            count=res[0];
            while(ch!=count)
            {
                count=res[0];
                //res.Substring(1) drops the first character of res — it returns the string starting at index 1 to the end.
            //It's being used to shrink the sliding window from the left. 
                res=res.Substring(1);
            }
            res=res.Substring(1);
            
        }
      }
      return max>res.Length?max:res.Length;
    }
}
