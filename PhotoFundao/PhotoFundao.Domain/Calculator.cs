using System;
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
            // Antes do refactor
            //var number2 = Numbers.Pop();
            //var number1 = Numbers.Pop();
            //var result = number2 + number1;
            //Numbers.Push(result);
            //return result;

            return Operate((x, y) => x + y);
        }

        public decimal Subtract()
        {
            // Antes do refactor
            //var number2 = Numbers.Pop();
            //var number1 = Numbers.Pop();
            //var result = number2 - number1;
            //Numbers.Push(result);
            //return result;

            return Operate((x, y) => y - x);
        }

        public decimal Multiply()
        {
            // Antes do refactor
            //var number2 = Numbers.Pop();
            //var number1 = Numbers.Pop();
            //var result = number2 * number1;
            //Numbers.Push(result);
            //return result;

            return Operate((x, y) => x * y);
        }

        public object Divide()
        {
            // Antes do refactor
            //var number2 = Numbers.Pop();
            //var number1 = Numbers.Pop();
            //var result = number2 / number1;
            //Numbers.Push(result);
            //return result;

            return Operate((x, y) => y / x);
        }

        private decimal Operate(Func<decimal,decimal,decimal> operation)
        {
            var number2 = Numbers.Pop();
            var number1 = Numbers.Pop();
            var result = operation(number1, number2);
            Numbers.Push(result);
            return result;
        }
    }
}