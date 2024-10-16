

using System;

namespace Course_23___Algorithms___Problem_Solving_Level_6
{
    public class Program
    {
        public static int BinarySearch(int[] Arr, int x)
        {
            int Start = 0;
            int End = Arr.Length - 1;

            int Trails = 0;
            while (Start <= End)
            {
                Trails++;
                Console.WriteLine($"\n\tTrail Number : {Trails}");


                int Middle = Start + (End - Start) / 2;

                if (Arr[Middle] == x)
                {
                    return Middle;
                }

                if (x > Arr[Middle])
                {
                    Start = Middle + 1;
                }
                else
                    End = Middle - 1;
            }


            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };

            int X = 22;

            int Result = BinarySearch(arr, X);

            Console.Write("\n\n Array elements : ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"\n The Index Of {X} Was Found In Position {Result}");



            Console.ReadKey();
        }
    }
}
