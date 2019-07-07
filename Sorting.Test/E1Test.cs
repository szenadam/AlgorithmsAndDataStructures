using Xunit;

namespace Sorting.Test
{
    public class E1Test
    {
        [Fact]
        public void Should_initialize_3_E1_to_S1L()
        {
            var foo = new E1(1);
            var bar = new E1(2);
            var baz = new E1(3);

            foo.next = bar;
            bar.next = baz;

            Assert.NotNull(foo.next);
            Assert.NotNull(bar.next);
            Assert.Null(baz.next);
        }
    }
}
