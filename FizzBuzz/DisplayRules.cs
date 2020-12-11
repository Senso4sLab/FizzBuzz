using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public interface IDisplayRule
    {
        string DisplayValue { get; }
        bool IsMatched(int value);
       
    }

    public class DisplayFizz : IDisplayRule
    {
        public string DisplayValue => "Fizz";    

        public bool IsMatched(int value)
        {
            return value % 3 == 0 ? true : false;
        }
    }

    public class DisplayBuzz : IDisplayRule
    {
        public string DisplayValue => "Buzz";

        public bool IsMatched(int value)
        {
            return value % 5 == 0 ? true : false;
        }
    }

    public class DisplayFizzBuzz : IDisplayRule
    {
        IDisplayRule _frizzRule;
        IDisplayRule _buzzRule;
        public DisplayFizzBuzz(IDisplayRule frizzRule, IDisplayRule buzzRule)
        {
            _frizzRule = frizzRule;
            _buzzRule = buzzRule;
        }
        public string DisplayValue => "FizzBuzz";

        public bool IsMatched(int value)
        {
            if (_frizzRule.IsMatched(value) && _buzzRule.IsMatched(value))
                return true;
            else
                return false;
        }
    }

    


}
