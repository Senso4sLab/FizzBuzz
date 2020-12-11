using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class DisplayFizzExtended : IDisplayRule
    {
        public string DisplayValue => "Fizz";
        IDisplayRule _rule;
        public DisplayFizzExtended(IDisplayRule rule)
        {
            _rule = rule;
        }
        public bool IsMatched(int value)
        {
            if (_rule.IsMatched(value) || value.ToString().Contains("3"))
                return true;
            else
                return false;
        }
    }

    public class DisplayBuzzExtended : IDisplayRule
    {
        public string DisplayValue => "Buzz";
        IDisplayRule _rule;
        public DisplayBuzzExtended(IDisplayRule rule)
        {
            _rule = rule;
        }
        public bool IsMatched(int value)
        {
            if (_rule.IsMatched(value) || value.ToString().Contains("5"))
                return true;
            else
                return false;
        }
    }

    public class DisplayFizzBuzzExtended : IDisplayRule
    {
        public string DisplayValue => "FizzBuzz";
        IDisplayRule _frizzRuleExtended;
        IDisplayRule _buzzRuleExtended;

        public DisplayFizzBuzzExtended(IDisplayRule frizzRuleExtended, IDisplayRule buzzRuleExtended)
        {
            _frizzRuleExtended = frizzRuleExtended;
            _buzzRuleExtended = buzzRuleExtended;
        }
        public bool IsMatched(int value)
        {
            if (_frizzRuleExtended.IsMatched(value) && _buzzRuleExtended.IsMatched(value))
                return true;
            else
                return false;
        }
    }
}
