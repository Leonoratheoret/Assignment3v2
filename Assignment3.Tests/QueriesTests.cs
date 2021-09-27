using System;
using Xunit;
using System.Collections;
using System.Linq;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
    
    
        [Fact]
        public void test_Sith_Lords_Year()
        {
            Queries q = new Queries();
            Assert.Equal(1977, q.Sith_Lords_Year());
        }

         [Fact]
        public void test_Sith_Lords_Year2()
        {
            Queries q = new Queries();
            Assert.Equal(1977, q.Sith_Lords_Year2());
        }

         [Fact]
        public void Order_Wizards_List2()
        {
            Queries q = new Queries();

            Assert.Equal(55, q.Order_Wizards_List2().Count());
        }
       
    }
}
