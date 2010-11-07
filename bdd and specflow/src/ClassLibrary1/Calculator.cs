using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Calculator
    {
        private readonly List<int> numbers = new List<int>();

        public void Enter(int number)
        {
            numbers.Add(number);
        }

        public int Add()
        {
            return numbers.Sum();
        }

        public int Subtract()
        {
                var result = numbers.First();

                var hit = false;
                foreach(var number in numbers)
                {
                    if (hit)
                        result -= number;
                    hit = true;
                }
                return result;
        }
    }
}