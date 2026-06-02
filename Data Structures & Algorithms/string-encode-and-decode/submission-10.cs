public class Solution {
 
    public string Encode(IList<string> strs) {
        StringBuilder stb=new StringBuilder();
        List<string> res=new List<String>();
        foreach(string str in strs)
          stb.Append(str.Length).Append('#').Append(str);
       
        return stb.ToString();
    }

    public List<string> Decode(string s) {
       List<string> result=new List<string>();
       //Console.WriteLine("new"+s);
       
       if(s.Length==1)
       {
          result.Add(s[0].ToString());
          return result;
       }
       int i=0;
      while(i<s.Length)
      {
        int index=s.IndexOf('#',i);
        int len=int.Parse(s.Substring(i,index-i));
        result.Add(s.Substring(index+1,len));
        i=index+1+len;
        //Console.WriteLine("ind "+i);
      }
       return result;
   }
}
