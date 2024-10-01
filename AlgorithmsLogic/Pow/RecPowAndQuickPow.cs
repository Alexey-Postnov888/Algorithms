using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLogic
{
    public class RecPowAndQuickPow
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
            long result;
            if(degree == 0)
            {
                return 1;
            }
            else
            {
                result = AuxiliaryFunction(number, degree / 2);
                if(degree % 2 == 1)
                {
                    result = result * result * number;
                }
                else
                {
                    result = result * result;
                }
            }
            return result;
        }
    }
}
