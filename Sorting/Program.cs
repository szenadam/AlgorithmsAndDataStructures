using Sorting.Utils;

namespace Sorting
{
    class Program
    {
        static int Main()
        {
            var foo = new E1(10);
            var bar = new E1(20);
            var baz = new E1(30);

            foo.Next = bar;
            bar.Next = baz;

            Util.WriteS1L(foo);

            return 0;
        }
    }
}
