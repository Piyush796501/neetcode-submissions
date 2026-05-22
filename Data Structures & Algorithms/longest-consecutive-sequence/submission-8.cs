public class Solution {
    public int LongestConsecutive(int[] nums) {
         HashSet<int> hs = new HashSet<int>();
         int n=nums.Length;
         int previous=0,next=0,max=0,count=1,index=0;
         if(nums.Length==0)
           return 0;

         for(int i=0;i<n;i++)
         {
            hs.Add(nums[i]);
         }
         var sortedView = hs.OrderBy(x => x);
         foreach(int number in sortedView)
         {
            Console.WriteLine("num"+number);
            if(index==0)
              {
                previous=number;
                
                
              }
             else
             {
                next=number;
                if(previous==next-1)
                {
                    count++;
                    Console.WriteLine("count"+count);
                }
                else
                {
                    if(max<=count)
                      max=count;
                    count=1;
                    //Console.WriteLine("max"+max);
                }
                previous=next;
                //Console.WriteLine("count"+count);
             }
             index++;
             //Console.WriteLine("count"+count);
         }
         return max>count?max:count;
    }
}
