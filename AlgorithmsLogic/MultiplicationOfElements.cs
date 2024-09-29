using System.Numerics;

namespace AlgorithmsLogic;

public class MultiplicationOfElements
{
    public static long Function(int[] vector)
    {
        long result = 1;
        for (int i = 0; i < vector.Length; i++)
        {
            result *= vector[i];
        }
        return result;
    }
}