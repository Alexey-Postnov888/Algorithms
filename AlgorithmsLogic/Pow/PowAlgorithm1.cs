namespace AlgorithmsLogic;

public class PowAlgorithm
{
    public static void Function(int[] vector, int number)
    {
        for (var i = 0; i < vector.Length; i++)
        {
            var result = AuxiliaryFunction(number, vector[i]);
        }
    }

    private static long AuxiliaryFunction(int number, int degree)
    {
        var count = 0;
        var result = 1;
        while (count < degree)
        {
            result *= number;
            count++;
        }

        return result;
    }
}