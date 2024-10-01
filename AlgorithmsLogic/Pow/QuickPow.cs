using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLogic
{
    public class QuickPow
    {
        public static void Function(int[] vector, int number)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                long result = AuxiliaryFunction(number, vector[i]);
            }
        }

        private static long AuxiliaryFunction(int number, int degree)
        {
            int temp = number;
            long result = 1;
            int count = degree;
            while(count != 0)
            {
                if(count % 2 == 0)
                {
                    temp *= temp;
                    count /= 2;
                }
                else
                {
                    result *= temp;
                    count--;
                }
            }
            return result;
        }
    }
}
