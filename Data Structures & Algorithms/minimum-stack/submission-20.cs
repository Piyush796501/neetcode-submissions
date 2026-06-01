public class MinStack  {
     Stack<int> customStack;
     Stack<int> _minStack;
     
    public MinStack() {
        customStack=new Stack<int>();
        _minStack=new Stack<int>();
       
    }
    
    public void Push(int val) {

        customStack.Push(val);
        if (_minStack.Count == 0 || val <=_minStack.Peek())
        {
            _minStack.Push(val);
        }
       
    }
    
    public void Pop() {
        
        int val=customStack.Peek();
          if(val==_minStack.Peek())
             _minStack.Pop();
        customStack.Pop();
        
    }
    
    public int Top() {
         return customStack.Peek();
    }
    
    public int GetMin() {
       
       
        return _minStack.Peek();
       
    }
}
