using System.Collections.Generic;
using ValueAndReferenceTypes;
using Xunit;

namespace ReferenceAndValueTypesTests
{
    public class RefAndValueTypeTests
    {
        [Fact]
        public void check_reference_type_test()
        {
            // Arrange
            var p1 = new ReferenceType(3, 4);
            var p2 = p1;
            
            // Act
            p2.X = 10;

            // Assert
            Assert.Equal(p1.X, p2.X);
        }

        [Fact]
        public void check_value_type_test()
        {
            // Arrange
            var p1 = new ValueType(3, 4);
            var p2 = p1;

            // Act
            p2.X = 10;

            // Assert
            Assert.NotEqual(p1.X, p2.X);
        }

        [Fact]
        public void check_list_type_test()
        {
            // Arrange
            var list = new List<string>
            {
                "Samsun",
                "Amasya",
                "Yozgat",
                "Sinop",
                "Bitlis",
                "Adana"
            };

            // Act
            var list2 = new List<string>(list);
            list.Add("Ýstanbul");

            // Assert
            Assert.NotEqual(list.Count, list2.Count);


               
        }
        [Fact]
        public void check_list_reference_type_test()
        {
            // Arrange
            var list = new List<string>
            {
                "Samsun",
                "Amasya",
                "Yozgat",
                "Sinop",
                "Bitlis",
                "Adana"
            };

            // Act
            var list2 = list;
            list.Add("Ýstanbul");
          
            // Assert
            Assert.Equal(list.Count, list2.Count);



        }
    }
}