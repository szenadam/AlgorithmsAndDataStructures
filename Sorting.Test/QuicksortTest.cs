using Sorting.Sorters;
using Xunit;

namespace Sorting.Test
{
    public class QuicksortTest
    {
        private readonly int[] _array = {5, 4, 3, 2, 1};

        [Fact]
        public void Should_Sort_Array()
        {
            Quicksort.Qs(_array);
            Assert.Equal(1, _array[0]);
        }
    }
}