using System.Collections.Generic;
using System.Linq;

namespace PhotoFundao.Domain
{
    public class Calculator
    {
        private Stack<decimal> Numbers { get; set; }

        public Calculator()
        {
            Numbers = new Stack<decimal>();
        }

        public void EnterNumber(decimal number)
        {
            Numbers.Push(number);
        }

        public decimal Add()
        {
            return Numbers.Sum();
        }
    }
}