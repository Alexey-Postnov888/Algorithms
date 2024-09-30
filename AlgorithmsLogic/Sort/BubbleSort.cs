namespace AlgorithmsLogic;

public class BubbleSort
{
    public static void Function(int[] vector)
    {
        int temp;
        for (int i = 0; i < vector.Length; i++)
        {
            for(int j = 0; j < vector.Length - 1; j++)
            {
                if (vector[j + 1] < vector[j])
                {
                    temp = vector[j + 1];
                    vector[j + 1] = vector[j];
                    vector[j] = temp;
                }
            }
        }
    }
}