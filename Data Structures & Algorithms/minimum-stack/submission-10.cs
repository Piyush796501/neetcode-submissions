public class MinStack {
     Stack<int> customStack;
     
    public MinStack() {
        customStack=new Stack<int>();
       
    }
    
    public void Push(int val) {

        customStack.Push(val);
    }
    
    public void Pop() {
        
        customStack.Pop();
    }
    
    public int Top() {
         return customStack.Peek();
    }
    
    public int GetMin() {
       int min=int.MaxValue;
        foreach(var elem in customStack)
        {
          if(min>=elem)
            min=elem;
        }
        return min;
    }
}
