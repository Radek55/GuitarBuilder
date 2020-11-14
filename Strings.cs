using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    class Strings : Guitar
    {
        public Strings(int amount, double size)
        {
            Amount = amount;
            Size = size;
        }
        public override string ToString()
        {
            return "and " + Amount + " strings with " + Size + "mm gauge";
        }
    }
}
