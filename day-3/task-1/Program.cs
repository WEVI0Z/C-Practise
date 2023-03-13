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

        }
    }
}
