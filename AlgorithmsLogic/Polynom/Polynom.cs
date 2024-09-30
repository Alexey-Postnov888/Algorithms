namespace AlgorithmsLogic;

public class Polynom
{
    public static double Function(int[] vector, double varible)
    {
        double result = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            result += vector[i] * Math.Pow(varible, i - 1);
        }
        return result;
    }

}