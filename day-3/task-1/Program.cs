using System;

namespace task1
{
    class MainClass
    {
        class TwoDimArr
        {
            public int[][] array;
            private int arrayLength;
            private int secondDimensionLength;

            public TwoDimArr(int[][] array)
            {
                this.array = array;
                arrayLength = array.Length;
                secondDimensionLength = array[0].Length;
            }

            public int[][] multWithArr(int[][] additionalArr)
            {
                if (
                    additionalArr.Length == this.arrayLength &&
                    additionalArr[0].Length == this.secondDimensionLength
                    )
                {
                    for(int i = 0; i < this.arrayLength; i++)
                    {
                        for(int j = 0; j < this.secondDimensionLength; j++)
                        {
                            this.array[i][j] *= additionalArr[i][j];
                        }
                    }
                }

                return this.array;
            }
        }
        public static void Main(string[] args)
        {
            TwoDimArr arr = new TwoDimArr(new int[][] { new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 } });

            int[][] additionalArr = new int[][] { new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 } };

            Console.WriteLine(arr.multWithArr(additionalArr)[0][2]);
        }
    }
}
