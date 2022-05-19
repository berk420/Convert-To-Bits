using System;

namespace Convert_to_bits
{
    class Program
    {
        public static void Reverse2DimArray(byte[,] theArray)
        {
            for (byte rowIndex = 0;
                 rowIndex <= (theArray.GetUpperBound(0)); rowIndex++)
            {
                for (byte colIndex = 0;
                     colIndex <= (theArray.GetUpperBound(1) / 2); colIndex++)
                {
                    byte tempHolder = theArray[rowIndex, colIndex];
                    theArray[rowIndex, colIndex] =
                      theArray[rowIndex, theArray.GetUpperBound(1) - colIndex];
                    theArray[rowIndex, theArray.GetUpperBound(1) - colIndex] =
                      tempHolder;
                }
            }
        }
        static void Main(string[] args)
        {

            string input = "Hello World!";
            byte[,] array = new byte[input.Length, 8];
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                byte mask = (byte)input[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((mask & 1) == 1)
                    {

                        array[i, j] = (byte)(array[i, j] | 1);
                    }
                    else
                    {
                        array[i, j] = (byte)(array[i, j] & 0);
                    }
                    mask >>= 1;
                    count++;

                }
            }
            Reverse2DimArray(array);

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + "->");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(array[i, j]);

                }
                Console.WriteLine(" ");
            }
        }
    }
}
