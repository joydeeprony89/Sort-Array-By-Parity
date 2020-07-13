using System;

namespace Sort_Array_By_Parity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 9 , 4 , 12, 90 };
            SortArrayByParity(A);
            Console.WriteLine("Hello World!");
        }

        public static int[] SortArrayByParity(int[] A)
        {
            for(int lastEvenFound = 0, cur = 0; cur < A.Length; cur++)
            {
                if(A[cur] % 2 == 0)
                {
                    int current = A[cur];
                    int temp = A[lastEvenFound];
                    A[lastEvenFound++] = current;
                    A[cur] = temp;
                }
            }

            return A;
        }
    }
}
