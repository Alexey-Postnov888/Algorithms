using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLogic
{
    public class AlgKadane
    {
        public static int Function(int[] vector)
        {
            int size = vector.Length;
            int maxSoFar = int.MinValue;
            int maxEndingHere = 0;

            for (int i = 0; i < size; i++)
            {
                maxEndingHere += vector[i];

                if (maxSoFar < maxEndingHere)
                {
                    maxSoFar = maxEndingHere;
                }

                if (maxEndingHere < 0)
                {
                    maxEndingHere = 0;
                }
            }

            return maxSoFar;
        }
    }
}
