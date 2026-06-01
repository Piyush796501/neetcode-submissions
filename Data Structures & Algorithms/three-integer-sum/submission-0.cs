public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        string str="";
        List<List<int>> lst=new List<List<int>>();
        
        HashSet<string> unique=new HashSet<string>();
        HashSet<int> sum=new HashSet<int>();
        for(int i=0;i<nums.Length;i++)
        {
            sum.Clear();
            for(int j=i+1;j<nums.Length;j++)
            {
            
              str="";
              int third=-(nums[i]+nums[j]);
              if(!sum.Contains(third))
              {
                sum.Add(nums[j]);
                //Console.WriteLine("resultnum"+nums[j]);
              }
              else
              {
                int[] triplet={nums[i],nums[j],third};
                Array.Sort(triplet);
                str=$"{triplet[0]},{triplet[1]}{triplet[2]}";
                
                if(!unique.Contains(str))
                {
                    //Console.WriteLine("elem");

                    var elem=new List<int>
                    {
                        nums[i],
                        nums[j],
                        third
                    };
                    lst.Add(elem);
                  unique.Add(str);
                } 
                
                
              }
            }
        }
        return lst;
    }
}
