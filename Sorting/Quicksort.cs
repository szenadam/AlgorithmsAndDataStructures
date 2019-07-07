using System;

namespace Sorting
{
    public static class Quicksort
    {
        public static void qs(int[] A)
        {
            qs(A, 1, A.Length - 1);
        }

        public static void qs(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = partition(A, p, r);
                qs(A, p, q - 1);
                qs(A, q + 1, r);
            }
        }

        private static int partition(int[] A, int p, int r)
        {
            Random rand = new Random();
            int i = rand.Next(p, r);
            int x = A[i];
            A[i] = A[r];

            while (i < r && A[i] <= x)
            {
                i = i + 1;
            }

            if (i < r)
            {
                int j = i + 1;

                while (j < r)
                {
                    if (A[j] < x)
                    {
                        swap(ref A[i], ref A[j]);
                        i = i + 1;
                    }
                    j = j + 1;
                }
                A[r] = A[i];
                A[i] = x;
            }
            else
            {
                A[r] = x;
            }

            return i;
        }

        private static void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
