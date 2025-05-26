namespace task3;

class Program
{
    static void Main(string[] args)
    {
        RealMatrix realMatrix=new RealMatrix(3,6);
        FillMatrix(realMatrix);
        DisplayMatrix(realMatrix);

        Console.WriteLine();
        realMatrix.Normalize();
        DisplayMatrix(realMatrix);
    }

    public static void FillMatrix(RealMatrix matrix)
    {
        Random rand = new Random();
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                matrix[i, j] = rand.Next(1, 10);
            }
        }
    }
    
    public static void DisplayMatrix(RealMatrix matrix)
    {
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}