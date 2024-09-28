namespace AlgorithmsLogic;

public class GornerMethod
{
    private int[] Vector { get; init; }

    public GornerMethod(int[] inputVector)
    {
        Vector = inputVector;
    }

    public double Function(double varible, int iterationNumber)
    {
        if (iterationNumber >= Vector.Length)
            return 1;
        return Vector[iterationNumber] + varible * Function(varible,  iterationNumber + 1);
    }
}