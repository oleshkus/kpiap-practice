namespace task3;

public class RealMatrix
{
    private double[,] _matrix { get; set; }

    public int Rows => _matrix.GetLength(0);

    public int Columns => _matrix.GetLength(1);

    public double this[int i, int j]
    {
        get => _matrix[i, j];
        set => _matrix[i, j] = value;
    }

    public RealMatrix(int rows,int columns)
    {
        _matrix = new double[rows, columns];
    }
    public void Normalize()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                if (_matrix[i,j] != 0)
                {
                    _matrix[i, j] *= -1;
                }
                else
                {
                    _matrix[i,j] = 1;
                }
            }
        }
    }
}