using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment3
{
    public static class Extensions
    {
        public static void Flatten()
        {
            var x = new List<int> {1, 2, 3, 4, 5};
            var s = new List<int> {6, 7, 8, 9, 10};
            List<int>[] xs = new[] {x, s};

            var flattenXS = xs.SelectMany(i => i);
            foreach (var VARIABLE in flattenXS) Console.WriteLine(VARIABLE);
        }
        
        public static void Divisble()
        {
            var x = new List<int> {2, 7, 14, 42, 49, 70, 80};
            var filtredX = x.Where(i => i > 42 && i % 7 == 0);
            
            foreach (var VARIABLE in filtredX) Console.WriteLine(VARIABLE);
        }
        
        public static void LeapYear()
        {
            var x = new List<int> {1820, 1822, 2000, 2001, 2012, 2016, 2017, 2020};
            var filtredX = x.Where(i =>
            {
                if (i % 4 == 0)  { //Tests if "normal" leap year
                    if(i % 100 != 0 || i % 400 == 0) { //Tests special cases of leap years
                        return true; 
                    }
                    else {
                        return false;
                    }
                } else {
                    return false;
                }
            });
            
            foreach (var VARIABLE in filtredX) Console.WriteLine(VARIABLE);
        }
        public static bool IsSecure(this Uri uri)
        {
            return uri.Scheme.Equals("https");
        }
        
        public static int WordCount(this String s)
        {
            var words = Regex.Split(s, @"\P{L}+");
            return words.Length;
        }

        public static void ReverseString(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            var reverseString = new string(chars);

            Action<string> ReverseString = s => Console.WriteLine(reverseString);
            ReverseString(s);

        }

        public static double Product(double number1, double numebr2)
        {
             Func<double,double,double> product = (x, y) => x * y;
             return product(number1, numebr2); 
        }

        public static bool NumericallyEqual(string numericalString, int number)
        {
             Func<string, int,bool> numericallyEqual = (s, i) => 
             {
                try {
                var intValue = int.Parse(s);
                if(intValue == i) return true;
                return false;
                } catch (Exception) {
                return false;
                }
             };
             return numericallyEqual(numericalString, number); 
        }

    }
}
