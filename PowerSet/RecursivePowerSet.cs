using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSet
{
   class RecursivePowerSet:BasePowerSet
   {
      public RecursivePowerSet()
      {
         m_RecpowerSet = new List<List<int>>();
      }

      public override void BuildPowerSet(List<int> numbers)
      {
         PowerSet(numbers, 0);
         foreach (List<int> listOfInt in m_RecpowerSet)
         {
            AddSet(listOfInt, listOfInt.Count);
         }
      }

      private void PowerSet(List<int> set, int index)
      {
         m_RecpowerSet.Add(set);
         
         for ( int i = index ; i < set.Count; i++)
         {
            List<int> temp = new List<int>(set);
            temp.RemoveAt(i);
            PowerSet(temp,i);
         }
      }

      private List<List<int>> m_RecpowerSet;
   }
}
