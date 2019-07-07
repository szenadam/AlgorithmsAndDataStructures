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
    }
}
