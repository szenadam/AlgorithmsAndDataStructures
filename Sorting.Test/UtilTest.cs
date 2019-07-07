using Sorting.Utils;
using Xunit;

namespace Sorting.Test
{
    public class UtilTest
    {
        
        private readonly int[] _array = {1, 2, 3, 4, 5};
        
        
        [Fact]
        public void Should_Create_S1L_from_int_array()
        {
            var head = Util.BuildS1LFromArray(_array);
            
            Assert.Equal(1, head.key);
            Assert.Equal(2, head.next.key);
            Assert.Equal(3, head.next.next.key);
            Assert.Equal(4, head.next.next.next.key);
            Assert.Equal(5, head.next.next.next.next.key);
            Assert.Null(head.next.next.next.next.next);
        }

        [Fact]
        public void Should_Return_null_on_empty_array()
        {
            var head = Util.BuildS1LFromArray(new int[]{});
            Assert.Null(head);
        }
    }
}