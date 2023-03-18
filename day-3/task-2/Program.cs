using System;

namespace task2
{
    class MainClass
    {
        class RealMatrix
        {
            private int[,] matrix;

            public RealMatrix(int rows, int columns)
            {
                matrix = new int[rows, columns];
            }

            public RealMatrix(int[,] matrix)
            {
                this.matrix = matrix;
            }

            public int Rows
            {
                get { return matrix.GetLength(0); }
            }

            public int Columns
            {
                get { return matrix.GetLength(1); }
            }

            public int this[int row, int column]
            {
                get { return matrix[row, column]; }
                set { matrix[row, column] = value; }
            }

            public bool IsSquare()
            {
                return Rows == Columns;
            }

            public bool IsDiagonal()
            {
                if (!IsSquare())
                {
                    return false;
                }

                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (i != j && matrix[i, j] != 0)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            public bool IsZero()
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            public bool IsIdentity()
            {
                if (!IsSquare())
                {
                    return false;
                }

                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        if (i == j && matrix[i, j] != 1)
                        {
                            return false;
                        }
                        else if (i != j && matrix[i, j] != 0)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            public bool IsSymmetric()
            {
                if (!IsSquare())
                {
                    return false;
                }

                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (matrix[i, j] != matrix[j, i])
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            public bool IsUpperTriangular()
            {
                if (!IsSquare())
                {
                    return false;
                }

                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            public bool IsLowerTriangular()
            {
                if (!IsSquare())
                {
                    return false;
                }

                for (int i = 0; i < Rows; i++)
                {
                    for (int j = i + 1; j < Columns; j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }
        public static void Main(string[] args)
        {
            RealMatrix mat = new RealMatrix(new int[,] { { 1, 4 }, { 3, 5 } });

            Console.WriteLine(mat.IsDiagonal());
        }
    }
}