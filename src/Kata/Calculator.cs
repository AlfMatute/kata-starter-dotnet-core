using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            if (!String.IsNullOrEmpty((number)))
            {
                return Int32.Parse(number);   
            }
            return 0;
        }
    }
}