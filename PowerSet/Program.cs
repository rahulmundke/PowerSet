using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSet
{
   class Program
   {
      static void Main(string[] args)
      {
         BasePowerSet powerSet = new RecursivePowerSet();
         List<int> listOfInts = new List<int>(){2,3,4};
         powerSet.BuildPowerSet(listOfInts);
         powerSet.PrintPowerSet();

         powerSet = new IterativePowerSet();
         powerSet.BuildPowerSet(listOfInts);
         powerSet.PrintPowerSet();

         Console.ReadKey();
      }
   }
}
