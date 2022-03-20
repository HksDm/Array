using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArray
{
    static class ArrayController
    {
        public static int[] GenRandom(int length, int min, int max)
        {
            if (length < 0)
            {
                throw new Exception("length must be >=0");
            }
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(min, max);
            }
            return array;
        }

        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        public static int GetMin(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int GetMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int GetMinIndex(int[] array)
        {
            int minindex = 0;
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minindex = i;
                }
            }
            return minindex;
        }
        public static int SumOddIndex(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 !=0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int[] Revers(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            int n = newArray.Length / 2;
            for (int i = 0; i < n; i++)
            {
                int tmp = newArray[i];
                newArray[i] = newArray[newArray.Length - (i + 1)];
                newArray[newArray.Length - (i + 1)] = tmp;
            }
            return newArray;
        }

        public static int[] SortBubble(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = 0; j < newArray.Length - (i + 1); j++)
                {
                    if (newArray[j] > newArray[j + 1])
                    {
                        int tmp = newArray[j];
                        newArray[j] = newArray[j + 1];
                        newArray[j + 1] = tmp;
                    }
                    
                }
            }
            return newArray;
        }

    }

}