namespace AlgorithmsLogic;

public class Matrix
{
    public int Columns;
    public int Rows;
    public int[,] Data;

    public Matrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        Data = new int[rows, columns];
    }

    public Matrix GenerateMatrix(int minValue, int maxValue)
    {
        var random = new Random();
        var matrix = new Matrix(Rows, Columns);

        for (var i = 0; i < Rows; i++) 
            for (var j = 0; j < Columns; j++) 
                matrix.Data[i, j] = random.Next(minValue, maxValue);

        return matrix;
    }

    /*public void Print()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.Write(Data[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }*/
}