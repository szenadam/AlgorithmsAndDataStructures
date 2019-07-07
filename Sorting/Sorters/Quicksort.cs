using System;

namespace Sorting.Sorters
{
    public static class Quicksort
    {
        public static void Qs(int[] a)
        {
            Qs(a, 1, a.Length - 1);
        }

        private static void Qs(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(a, p, r);
                Qs(a, p, q - 1);
                Qs(a, q + 1, r);
            }
        }

        private static int Partition(int[] a, int p, int r)
        {
            Random rand = new Random();
            int i = rand.Next(p, r);
            int x = a[i];
            a[i] = a[r];

            while (i < r && a[i] <= x)
            {
                i = i + 1;
            }

            if (i < r)
            {
                int j = i + 1;

                while (j < r)
                {
                    if (a[j] < x)
                    {
                        Swap(ref a[i], ref a[j]);
                        i = i + 1;
                    }
                    j = j + 1;
                }
                a[r] = a[i];
                a[i] = x;
            }
            else
            {
                a[r] = x;
            }

            return i;
        }

        private static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
