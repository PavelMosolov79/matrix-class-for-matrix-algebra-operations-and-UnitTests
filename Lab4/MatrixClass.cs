using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    using System;
    using System.Text;

    public class Matrix
    {
        private int[,] data;
        public int I { get; private set; }
        public int J { get; private set; }

        public Matrix(int[,] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            I = array.GetLength(0);
            J = array.GetLength(1);
            data = array;
        }

        //+
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.I != b.I || a.J != b.J)
                throw new InvalidOperationException("Матрицы имеют разные размеры.");

            int[,] result = new int[a.I, a.J];
            for (int i = 0; i < a.I; i++)
            {
                for (int j = 0; j < a.J; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return new Matrix(result);
        }

        //-
        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.I != b.I || a.J != b.J)
                throw new InvalidOperationException("Матрицы имеют разные размеры.");

            int[,] result = new int[a.I, a.J];
            for (int i = 0; i < a.I; i++)
            {
                for (int j = 0; j < a.J; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return new Matrix(result);
        }

        //*
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.J != b.I)
                throw new InvalidOperationException("Число столбцов первой матрицы не равно числу строк второй матрицы.");

            int[,] result = new int[a.I, b.J];
            for (int i = 0; i < a.I; i++)
            {
                for (int j = 0; j < b.J; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.J; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return new Matrix(result);
        }

        //==
        public static bool operator ==(Matrix a, Matrix b)
{
    if (ReferenceEquals(a, b))
        return true;

    if (a is null || b is null)
        return false;

    if (a.I != b.I || a.J != b.J)
        return false;

    for (int i = 0; i < a.I; i++)
    {
        for (int j = 0; j < a.J; j++)
        {
            if (a[i, j] != b[i, j])
                return false;
        }
    }
    return true;
}

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        //Транспонирование
        public Matrix Transpose()
        {
            int[,] result = new int[J, I];
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    result[j, i] = data[i, j];
                }
            }
            return new Matrix(result);
        }

        //min
        public int Min()
        {
            int min = data[0, 0];
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    if (data[i, j] < min)
                    {
                        min = data[i, j];
                    }
                }
            }
            return min;
        }

        //str
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            for (int i = 0; i < I; i++)
            {
                sb.Append("{");
                for (int j = 0; j < J; j++)
                {
                    sb.Append(data[i, j]);
                    if (j < J - 1)
                    {
                        sb.Append(", ");
                    }
                }
                sb.Append("}");
                if (i < I - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append("}");
            return sb.ToString();
        }

        //index
        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= I || j < 0 || j >= J)
                    throw new IndexOutOfRangeException("Индексы выходят за пределы матрицы.");
                return data[i, j];
            }
        }

        public override bool Equals(object? obj)
{
    if (obj == null || !(obj is Matrix))
        return false;

    Matrix other = (Matrix)obj;

    if (I != other.I || J != other.J)
        return false;

    for (int i = 0; i < I; i++)
    {
        for (int j = 0; j < J; j++)
        {
            if (this[i, j] != other[i, j])
                return false;
        }
    }

    return true;
}


        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + I.GetHashCode();
            hash = hash * 23 + J.GetHashCode();
            return hash;
        }
    }

}
