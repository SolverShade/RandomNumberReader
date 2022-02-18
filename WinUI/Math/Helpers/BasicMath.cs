using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI.Math.Helpers
{
    public static class BasicMath
    {
        public static int getSumOfNumbers(List<int> numbers)
        {
            int sum = numbers.Sum();
            return sum; 
        }

        public static int getAmountOfWholeNumbers(List<int> numbers)
        {
            int amount = numbers.Count;
            return amount;
        }

        
    }
}
