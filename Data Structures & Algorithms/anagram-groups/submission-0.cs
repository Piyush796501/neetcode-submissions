public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map=new Dictionary<string,List<string>>();
        List<List<string>> reslst=new List<List<string>>();
        foreach(string str in strs)
        {
            
            string sorted = string.Concat(str.OrderBy(c => c));
            var lst=new List<string>();
            if(map.ContainsKey(sorted))
            {
                map[sorted].Add(str);
            }
            else
            {
                lst.Add(str);
                map.Add(sorted,lst);
            }
        }
        // Option A: Using implicit typing (var)
        foreach (var kvp in map)
        {
            reslst.Add(kvp.Value);
            //Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
        return reslst;
    }
}
