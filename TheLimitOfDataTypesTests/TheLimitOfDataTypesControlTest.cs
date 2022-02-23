using Xunit;

namespace TheLimitOfDataTypesTests
{
    public class TheLimitOfDataTypesControlTest
    {
        [Fact]
        public void byte_data_type_control_tests()
        {     
            // arrange
            byte minValue, maxValue;

            // act
            minValue = 0;
            maxValue = 255;


            // assert
            Assert.Equal(minValue, byte.MinValue);
            Assert.Equal(maxValue, byte.MaxValue);

        }

        [Fact]
        public void sbyte_data_type_control_tests()
        {
            // arrange
            sbyte minValue, maxValue;

            // act
            minValue = -128;
            maxValue = 127;

            // assert
            Assert.Equal(minValue, sbyte.MinValue);
            Assert.Equal(maxValue, sbyte.MaxValue);

        }


        [Fact]
        public void int_data_type_control_tests()
        {
            // arrange
            int minValue, maxValue;

            //act
            maxValue = 0;
            minValue = -2147483648;

            // assert
            Assert.Equal(minValue, int.MinValue);

        }
        [Fact]
        public void double_data_type_control_tests()
        {
            // arrange
            double minValue, maxValue;

            //act
            maxValue = 1.123456789 + 308;

            // assert
            minValue = - 1.123456789 + 308;
            
        }

    }
}