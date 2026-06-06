public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<string> stc=new Stack<string>();
        int n =tokens.Length;
        for(int i=0;i<n;i++)
        {
          if(tokens[i]=="+" || tokens[i]=="-" || tokens[i]=="*" || tokens[i]=="/")
          {
            int elem2=int.Parse(stc.Pop());
            int elem1=int.Parse(stc.Pop());
            string op=tokens[i];
            int result = op switch
            {
                "+" => elem1 + elem2,
                "-" => elem1 - elem2,
                "*" => elem1 * elem2,
                "/" => elem2 != 0 ? elem1 / elem2 : throw new DivideByZeroException("Cannot divide by zero."),
                _   => throw new InvalidOperationException($"Unknown operator: {op}")
            };
            stc.Push(result.ToString());
          }
          else
          {
            stc.Push(tokens[i]);
          }
       
        }
        return int.Parse(stc.Peek());
    }
}
