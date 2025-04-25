using System;

namespace MatrixApp
{
    public class Matrix : IComparable<Matrix>
    {
        private readonly double[,] data;
        public int Rows { get; }
        public int Cols { get; }

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            data = new double[rows, cols];
        }

        public Matrix(double[,] array)
        {
            Rows = array.GetLength(0);
            Cols = array.GetLength(1);
            data = (double[,])array.Clone();
        }

        public double this[int i, int j]
        {
            get => data[i, j];
            set => data[i, j] = value;
        }

        public bool IsSquare => Rows == Cols;

        public bool IsZero()
        {
            foreach (var v in data)
                if (v != 0) return false;
            return true;
        }

        public bool IsIdentity()
        {
            if (!IsSquare) return false;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    if ((i == j && data[i, j] != 1) || (i != j && data[i, j] != 0))
                        return false;
            return true;
        }

        public bool IsDiagonal()
        {
            if (!IsSquare) return false;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    if (i != j && data[i, j] != 0)
                        return false;
            return true;
        }

        public bool IsSymmetric()
        {
            if (!IsSquare) return false;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    if (data[i, j] != data[j, i])
                        return false;
            return true;
        }

        public bool IsUpperTriangular()
        {
            if (!IsSquare) return false;
            for (int i = 1; i < Rows; i++)
                for (int j = 0; j < i; j++)
                    if (data[i, j] != 0)
                        return false;
            return true;
        }

        public bool IsLowerTriangular()
        {
            if (!IsSquare) return false;
            for (int i = 0; i < Rows; i++)
                for (int j = i + 1; j < Cols; j++)
                    if (data[i, j] != 0)
                        return false;
            return true;
        }

        // Сравнение по сумме всех элементов
        public int CompareTo(Matrix? other)
        {
            if (other == null) return 1;
            double sum1 = 0, sum2 = 0;
            foreach (var v in data) sum1 += v;
            foreach (var v in other.data) sum2 += v;
            return sum1.CompareTo(sum2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Matrix m || Rows != m.Rows || Cols != m.Cols)
                return false;

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    if (data[i, j] != m[i, j])
                        return false;

            return true;
        }

        public override int GetHashCode() => data.GetHashCode();

        public static bool operator ==(Matrix a, Matrix b) => a.Equals(b);
        public static bool operator !=(Matrix a, Matrix b) => !a.Equals(b);

        public override string ToString()
        {
            var result = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                    result += $"{data[i, j],6:0.##} ";
                result += "\n";
            }
            return result;
        }
    }
}