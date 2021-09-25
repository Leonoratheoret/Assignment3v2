using System;
using Xunit;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Fact]        
        public void IsSecure_when_given_uri_starting_with_https_returns_true()
        {

            Uri u = new Uri("https://docs.microsoft.com/en-us/dotnet/api/system.uri?view=net-5.0");
            bool actual = u.IsSecure();
            
            Assert.Equal(true, actual);

        }

        [Fact] 
        public void IsSecure_when_given_uri_starting_with_http_returns_false()
        {

            Uri u = new Uri("http://docs.microsoft.com/en-us/dotnet/api/system.uri?view=net-5.0");
            var actual = u.IsSecure();
            
            Assert.Equal(false, actual);

        }

        [Fact] 
        public void WordCount_when_given_string_with_6_word_return_6()
        {

            string s = "Hej med dig. Hvad hedder du";
            var actual = s.WordCount();
             Assert.Equal(6, actual);

        }
        
    }
}
