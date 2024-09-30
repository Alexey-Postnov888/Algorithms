namespace AlgorithmsLogic;

public class MatrixMultiplication
{
    public Matrix Multiply(Matrix matrixA, Matrix matrixB)
    {
        if (matrixA.Rows != matrixB.Columns) throw new ArgumentException("Вспомни условие умножения матриц :)");

        var matrixResult = new Matrix(matrixA.Rows, matrixB.Columns);

        for (var i = 0; i < matrixA.Rows; i++) 
            for (var j = 0; j < matrixB.Columns; j++) 
                for (var g = 0; g < matrixA.Columns; g++) 
                    matrixResult.Data[i, j] += matrixA.Data[i, g] * matrixB.Data[g, j];

        return matrixResult;
    }
}