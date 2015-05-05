using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSet
{
   class IterativePowerSet : BasePowerSet
   {
      public override void BuildPowerSet(List<int> numbers)
      {
         // Always add empty set first
         List<int> emptySet = new List<int>();
         AddSet(emptySet, 0);

         int startIndex = 0;
         int endIndex = numbers.Count;
         int jump = 0;
         int pow_set_size = (int)Math.Pow(2, endIndex);
         int counter, j;

         /*Run from counter 000..0 to 111..1*/
         for (counter = 1; counter < pow_set_size; counter++)
         {
            List<int> set = new List<int>();
            for (j = 0; j < endIndex; j++)
            {
               /* Check if jth bit in the counter is set
                  If set then add jth element from set */
               int num = counter & (1 << j);
               if( num > 0)
               {
                  set.Add(numbers[j]);
               }
            }
            AddSet(set,set.Count);
         }
      }
   }
}