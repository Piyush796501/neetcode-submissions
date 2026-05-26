public class Solution {
    public bool IsValid(string s) {
        Stack<char> st=new Stack<char>();
        if(s.Length==1)
          return false;
        char ch,remove;
        for(int i=0;i<s.Length;i++)
        {
            if(s[i]=='('|| s[i]=='{' || s[i] =='[')
            {
                st.Push(s[i]);
            }
            else
            {
                if(st.Count==0)
                  return false;
                remove='a';
                if(s[i]==')')
                  remove='(';
                else if(s[i]=='}')
                  remove='{';
                else if(s[i]==']')
                  remove='[';
                 
                if(st.TryPeek(out char result))
                {
                if(result==remove)
                {
                  st.Pop();
                }
                else
                   return false;
                }
            }
        }
        return st.Count == 0;
    }
}
