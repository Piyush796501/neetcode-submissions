public class Solution {
    public List<List<int>> Generate(int numRows) {
        List<List<int>> num=new List<List<int>>();
        
        for(int i=0;i<numRows;i++)
        {
            List<int> elem=new List<int>(i+1);
            if(i==0){
             elem.Add(1);
              num.Add(elem);
             
            }
            else if(i==1){
              elem.Add(1);
              elem.Add(1);
              num.Add(elem);
             
            }
            else
            {
                
                for(int j=0;j<=i;j++)
                {
                  if(j==0)
                     elem.Add(1);
                  else if(j<i)
                  {
                    List<int> previousRow = num[i - 1];

int res = previousRow[j - 1] + previousRow[j];
                    elem.Add(res);
                  }
                  else
                  {
                   elem.Add(1);
                  }
                }
                num.Add(elem);
            }

        }
        return num;
    }
}