using System.Numerics;

namespace AlgorithmsLogic;

public class MultiplicationOfElements
{
    private int[] Vector { get; init; }

    public MultiplicationOfElements(int[] inputVector)
    {
        Vector = inputVector;
    }

    public long Function()
    {
        long result = 1;
        for (int i = 0; i < Vector.Length; i++)
        {
            result *= Vector[i];
        }
        return result;
    }
}