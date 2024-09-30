namespace AlgorithmsLogic;

public class GornerMethod
{
    public static double Function(int[] vector, double varible, int iterationNumber)
    {
        if (iterationNumber >= vector.Length)
            return 1;
        return vector[iterationNumber] + varible * Function( vector, varible,  iterationNumber + 1);
    }
}