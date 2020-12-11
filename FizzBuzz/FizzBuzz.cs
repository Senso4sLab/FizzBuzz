using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        IList<IDisplayRule> _rules;
        public FizzBuzz()
        {
            _rules = new List<IDisplayRule>();

            // without extra credit
            //var frizz = new DiplayFizz();
            //var buzz = new DiplayBuzz();
            //var frizBuzz = new DisplayFizzBuzz(frizz, buzz);
            //_rules.Add(frizz);
            //_rules.Add(buzz);
            //_rules.Add(frizBuzz);

            // with extra credit
            var frizz = new DisplayFizzExtended(new DisplayFizz());
            var buzz = new DisplayBuzzExtended(new DisplayBuzz());
            var frizBuzz = new DisplayFizzBuzzExtended(frizz, buzz);
            _rules.Add(frizz);
            _rules.Add(buzz);
            _rules.Add(frizBuzz);

        }
        public void Start()
        {
            for(int i = 1; i <= 100; i++)
            {
                string printValue = i.ToString();
                foreach(var rule in _rules)
                {
                    if (rule.IsMatched(i))
                    {
                        printValue = rule.DisplayValue;
                        break;
                    }
                }
                Console.WriteLine(printValue);
            }

        }
    }
}
