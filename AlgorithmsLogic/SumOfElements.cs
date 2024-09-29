using System.Runtime.CompilerServices;

namespace AlgorithmsLogic;

public class SumOfElements
{
    public static long Function(int[] vector)
    {
        int sum = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            sum += vector[i];
        }
        return sum;
    }
}