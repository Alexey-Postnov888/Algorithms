using System.Runtime.CompilerServices;

namespace AlgorithmsLogic;

public class SumOfElements
{
    private int[] Vector {  get; init; }

    public SumOfElements(int[] inputVector)
    {
        Vector = inputVector;
    }

    public long Function()
    {
        int sum = 0;
        for (int i = 0; i < Vector.Length; i++)
        {
            sum += Vector[i];
        }
        return sum;
    }
}