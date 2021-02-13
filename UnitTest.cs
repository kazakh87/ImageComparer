#if !RELEASE
using Xunit;

namespace ImageComparer
{
    public class UnitTest
    {
        [Fact]
        internal void PassingTestAdder()
        {
            Assert.Equal(4, Program.Adder(1, 3));
        }

        //[Fact]
        //internal void FailingTestAdder()
        //{
        //    Assert.Equal(4, Program.Adder(1, 1));
        //}
    }
}
#endif