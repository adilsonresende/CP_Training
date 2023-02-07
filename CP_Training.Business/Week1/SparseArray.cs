using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class SparseArray
    {
        public List<int> MatchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>();
            foreach(string s in queries)
            {
                int quantity = strings.Where(x => x == s).Count();
                result.Add(quantity);
            }

            return result;
        }
    }
}
