namespace AlgorithmsLogic;

public class PowAlgorithm
{
    public static void Function(int[] vector, int number)
    {
        for(int i = 0; i < vector.Length; i++)
        {
            long result = AuxiliaryFunction(number, vector[i]);
        }
    }

    private static long AuxiliaryFunction(int number, int degree)
    {
        int count = 0;
        int result = 1;
        while (count < degree)
        {
            result *= number;
        }
        return result;
    }
}