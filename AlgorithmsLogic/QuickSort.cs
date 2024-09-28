namespace AlgorithmsLogic;

public class QuickSort
{
    private int[] Vector { get; init; }

    public QuickSort(int[] inputVector)
    {
        Vector = inputVector; 
    }

    public void Function(int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(low, high);
            Function(low, pivotIndex - 1);
            Function(pivotIndex + 1, high);
        }
    }

    private int Partition( int low, int high)
    {
        int pivot = Vector[(low + high) / 2];
        int i = low - 1;
        int j = high + 1;
        while (true)
        {
            do
            {
                i++;
            } while (Vector[i] < pivot);

            do
            {
                j--;
            } while (Vector[j] > pivot);

            if (i >= j)
                return j;

            Swap(i, j);
        }
    }

    private void Swap(int index1, int index2)
    {
        int temp = Vector[index1];
        Vector[index1] = Vector[index2];
        Vector[index2] = temp;
    }
}