using System;

namespace OOP_lab_2_4_4
{
    public class Program
    {
        public static int IndexOfMax(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[index] <= array[i])
                {
                    index = i;
                }
            }

            return index;
        }

        public static int AbsSumBetweenFirstAndLastZeroes(int[] array)
        {
            int firstZeroIndex = 0;
            int lastZeroIndex = 0;

            int sum = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 0)
                {
                    firstZeroIndex = i;
                    break;
                }
            }

            for (int i = array.Length - 1; i >= firstZeroIndex; --i)
            {
                if (array[i] == 0)
                {
                    lastZeroIndex = i;
                    break;
                }
            }

            for (int i = firstZeroIndex + 1; i < lastZeroIndex; ++i)
            {
                sum += Math.Abs(array[i]);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Hомер максимального елемента масиву: {0}", IndexOfMax(a));
            Console.WriteLine("Cумa модулiв елементiв масиву, розташованих мiж першим й останнiм нульовими елементами: {0}", AbsSumBetweenFirstAndLastZeroes(a));
        }
    }
}
