namespace AlgorithmsLogic;

public class TimSort
{
    private int[] Vector { get; init; }

    public TimSort(int[] inputVector)
    {
        Vector = inputVector;
    }

    public void Function(int n)
    {

        for (int i = 0; i < n; i += RUN)
            insertionSort(i, Math.Min((i + RUN - 1), (n - 1)));

        for (int size = RUN; size < n; size = 2 * size)
        {

            for (int left = 0; left < n; left += 2 * size)
            {

                int mid = left + size - 1;
                int right = Math.Min((left + 2 * size - 1),
                                    (n - 1));

                if (mid < right)
                    merge(left, mid, right);
            }
        }
    }



    public const int RUN = 32;

    private void insertionSort( int left, int right)        
    {
        for (int i = left + 1; i <= right; i++)
        {
            int temp = Vector[i];
            int j = i - 1;
            while (j >= left && Vector[j] > temp)
            {
                Vector[j + 1] = Vector[j];
                j--;
            }
            Vector[j + 1] = temp;
        }
    }

    private void merge(int l, int m, int r)
    {
        int len1 = m - l + 1, len2 = r - m;
        int[] left = new int[len1];
        int[] right = new int[len2];
        for (int x = 0; x < len1; x++)
            left[x] = Vector[l + x];
        for (int x = 0; x < len2; x++)
            right[x] = Vector[m + 1 + x];

        int i = 0;
        int j = 0;
        int k = l;

        while (i < len1 && j < len2)
        {
            if (left[i] <= right[j])
            {
                Vector[k] = left[i];
                i++;
            }
            else
            {
                Vector[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < len1)
        {
            Vector[k] = left[i];
            k++;
            i++;
        }

        while (j < len2)
        {
            Vector[k] = right[j];
            k++;
            j++;
        }
    }


}