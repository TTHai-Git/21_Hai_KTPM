using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_21_Hai
{
    public class Calculation_21_Hai
    {
        private int a, b;

        public Calculation_21_Hai(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

       public int Execute(string CalSymbol)
        {
            int result = 0;
            switch (CalSymbol)
            {
                case "+":
                    {
                        result = this.a + this.b;
                        break;
                    }
                case "-":
                    {
                        result = this.a - this.b;
                        break;
                    }
                case "*":
                    {
                        result = this.a * this.b;
                        break;
                    }
                case "/":
                    {
                        result = this.a / this.b;
                        break;
                    }

            }
            return result;
        }
    }
}
