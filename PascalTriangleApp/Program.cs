namespace PascalTriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Height = 15;

            int[][] triangle = MakePascalTria(Height);

            PascalTriangle(triangle);

        }

        public static int[][] MakePascalTria(int rows)
        {
            int[][] triangle = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;
                triangle[i][i] = 1;

                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            return triangle;
        }

        public static void PascalTriangle(int[][] triangle)
        {
            for (int i = 0; i < triangle.Length; i++)
            {
                Console.Write(new string(' ', (triangle.Length - i - 1) * 3));
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write($"{triangle[i][j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
