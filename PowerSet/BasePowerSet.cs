using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSet
{
   abstract class BasePowerSet
   {
      public BasePowerSet()
      {
         m_powerSetList = new List<List<int>>();
         m_listCount = 0;
         m_NumberOfElements = 0;
      }

      private List<List<int>> m_powerSetList;
      private int m_listCount;
      private int m_NumberOfElements;


      

      protected void AddSet(List<int> setOfInt, int numberOfElements)
      {
         m_powerSetList.Add(setOfInt);
         m_listCount++;
         m_NumberOfElements += numberOfElements;
      }


      public virtual void BuildPowerSet(List<int> numbers)
      {
      }

      public void PrintPowerSet()
      {
         foreach (List<int> listOfInt in m_powerSetList)
         {
            Console.WriteLine("New set Starts:");
            Console.WriteLine("Contains below elements: [ ");
            if(listOfInt.Count == 0)
            {
               Console.Write("Empty Set");
            }
            foreach (int i in listOfInt)
            {
               Console.Write(i + " , ");
            }
            Console.WriteLine("] .... set ends.");
         }
      }

   }
}
