using System;
using System.IO;
using Xunit;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        [Fact] 
        public void Reverse_test()
        {

            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("!dlroW ,olleH", output);

        }

        [Fact] 
        public void Product_When_Given_numbers_10_and_5_return_50()
        {

            var actual = Extensions.Product(10, 5);

            Assert.Equal(50, actual);
        
        }

        [Fact] 
        public void  NumericallyEqual_When_Given_String_898_and_integer_898_return_true()
        {

          var actual = Extensions.NumericallyEqual("898",898);
          Assert.Equal(true, actual);

        }

        [Fact] 
        public void  NumericallyEqual_When_Given_String_00898_and_integer_898_return_true()
        {

          var actual = Extensions.NumericallyEqual(" 00898",898);
          Assert.Equal(true, actual);

        }
        
        [Fact] 
        public void  NumericallyEqual_When_Given_String_Voldemort_and_integer_29_return_false()
        {

          var actual = Extensions.NumericallyEqual("Voldemort",29);
          Assert.Equal(false, actual);

        }

        [Fact] 
        public void  NumericallyEqual_When_Given_String_80_and_integer_29_return_false()
        {

          var actual = Extensions.NumericallyEqual("80",29);
          Assert.Equal(false, actual);

        }

    }
}
