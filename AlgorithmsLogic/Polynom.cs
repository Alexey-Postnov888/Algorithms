namespace AlgorithmsLogic;

public class Polynom
{
    private int[] Vector { get; init; }

    public Polynom(int[] inputVector)
    {
        Vector = inputVector;
    }

    public double Function(double varible)
    {
        double result = 0;
        for (int i = 0; i < Vector.Length; i++)
        {
            result += Vector[i] * Math.Pow(varible, i - 1);
        }
        return result;
    }

}