using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship_week0
{
    internal class AlgorithamExercise
    {
        public int[] RemoveDuplicates(int[] arr)
        {
            if(arr.Length < 0)
            {
                throw new Exception();
            }
            return arr.Distinct().ToArray();
        }
        public int[] RemoveDuplicates2(int[] arr)
        {
            if (arr.Length < 0)
            {
                throw new Exception();
            }
            var hashset = new HashSet<int>(arr);
            return hashset.ToArray();

        }
        public int[] SortArray(int[] arr)
        {
            if (arr.Length < 0)
            {
                throw new Exception();
            }
            return arr.OrderBy(x => x).ToArray();
        }
        public IEnumerable<int> PairSocks(int[] arr)
        {
            var s = arr.GroupBy(x => x).Select(x => new { nesto = x.Key, nesto2 = x.Count() });
            return null;
            
        }
    }
}
