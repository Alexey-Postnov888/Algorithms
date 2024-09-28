namespace AlgorithmsLogic;

public class BubbleSort
{
    private int[] Vector { get; init; }

    public BubbleSort(int[] inputVector)
    {
        Vector = inputVector; 
    }

    public void Function()
    {
        int temp;
        for (int i = 0; i < Vector.Length; i++)
        {
            for(int j = 0; j < Vector.Length - 1; j++)
            {
                if (Vector[j + 1] < Vector[j])
                {
                    temp = Vector[j + 1];
                    Vector[j + 1] = Vector[j];
                    Vector[j] = temp;
                }
            }
        }
    }
}