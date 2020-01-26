namespace Katas
{
    public class Matrix
    {
        public static int Determinant(int[][] matrix)
        {
            var length = matrix.GetLength(0);
            if (length == 1) return matrix[0][0];
            if (length == 2) return Calculate2x2Matrix(matrix);
            return CalculateBiggerMatrix(matrix);
        }

        private static int CalculateBiggerMatrix(int[][] matrix)
        {
            var add = true;
            var total = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var determinant = CalculateDeterminant(i, matrix);
                total += add ? determinant : determinant * -1;
                add = !add;
            }
            return total;
        }

        private static int CalculateDeterminant(int a_index, int[][] matrix)
        {
            int a_value = matrix[0][a_index];
            return a_value * Determinant(GetSmallerMatrix(a_index, matrix));
        }

        private static int Calculate2x2Matrix(int[][] matrix)
        {
            return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
        }

        private static int[][] GetSmallerMatrix(int a_index, int[][] matrix)
        {
            //Create a new matrix that is 1 row and column smaller than the original matrix
            int[][] smallerMatrix = new int[matrix.GetLength(0) - 1][];

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                smallerMatrix[r] = new int[matrix.GetLength(0) - 1];

                for (int c = 0; c < matrix.GetLength(0); c++)
                {
                    if (c < a_index)
                    {
                        smallerMatrix[r][c] = matrix[r + 1][c];
                    }
                    else if (c == a_index)
                    {
                        //skip this column...
                    }
                    else
                    {
                        smallerMatrix[r][c - 1] = matrix[r + 1][c];
                    }
                }
            }

            return smallerMatrix;
        }
    }
}
