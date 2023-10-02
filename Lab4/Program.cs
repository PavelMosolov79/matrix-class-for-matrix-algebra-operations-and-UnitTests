using Lab4;
using System;

class Program
{
    static void Main()
    {
        // Создаем матрицы
        int[,] data1 = { { 1, 2 }, { 3, 4 } };
        int[,] data2 = { { 2, 1 }, { 4, 3 } };
        Matrix matrix1 = new Matrix(data1);
        Matrix matrix2 = new Matrix(data2);

        Matrix sumResult = matrix1 + matrix2;
        Console.WriteLine("Сумма матриц:");
        PrintMatrix(sumResult);

        Matrix subtractResult = matrix1 - matrix2;
        Console.WriteLine("Разность матриц:");
        PrintMatrix(subtractResult);

        Matrix multiplyResult = matrix1 * matrix2;
        Console.WriteLine("Произведение матриц:");
        PrintMatrix(multiplyResult);

        bool isEqual = matrix1 == matrix2;
        Console.WriteLine($"Матрицы равны: {isEqual}");

        Matrix transposedMatrix = matrix1.Transpose();
        Console.WriteLine("Транспонированная матрица:");
        PrintMatrix(transposedMatrix);

        int minValue = matrix1.Min();
        Console.WriteLine($"Минимальный элемент в матрице: {minValue}");

        string matrixString = matrix1.ToString();
        Console.WriteLine("Строковое представление матрицы:");
        Console.WriteLine(matrixString);
    }

    static void PrintMatrix(Matrix matrix)
    {
        for (int i = 0; i < matrix.I; i++)
        {
            for (int j = 0; j < matrix.J; j++)
            {
                Console.Write($"\t{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

