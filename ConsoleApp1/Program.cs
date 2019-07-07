using System;

namespace Sorting.Sorting
{
    class Program
    {
        static int Main(string[] args)
        {
            var foo = new E1(10);
            var bar = new E1(20);
            var baz = new E1(30);

            foo.next = bar;
            bar.next = baz;

            Utils.Util.WriteS1L(foo);

            return 0;
        }

        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} values", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }
    }
}
