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

        public int Execute(string CalSymbol)
        {
            int result = 0;
            switch (CalSymbol)
            {
                case "+":
                    return result = this.a + this.b;
                    break;
                case "-":
                    return result = this.a - this.b;
                    break;
                case "*":
                    return result = this.a * this.b;
                    break;
                case "/":
                    return result = this.a / this.b;
                    break;
            }
            return result;
        }

    }

}
