using Xunit;

namespace ArrayTest
{
    public class ArrayTests
    {
        [Fact]
        public void ArraySetValueTest()
        {   //arrenge
            var arr = new Array.Array();

            //act
            arr.SetValue(10, 0);

            //assert
            Assert.Equal(10, arr.GetValue(0));



        }
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]


        public void CheckDefaultSizeFeature(int defaultSize)
        {
            var arr = new Array.Array(defaultSize);
            Assert.Equal( defaultSize, arr.Lengt);
        }
        public void CheckCloneableTest()
        {
            var arr = new Array.Array();

            arr.SetValue(1, 0);
            arr.SetValue(2, 0);
            arr.SetValue(3, 0);
            arr.SetValue(4, 0);

            var cloneArr = arr.Clone() as Array.Array;

            Assert.IsType<Array.Array>(cloneArr);
        }
    }
}