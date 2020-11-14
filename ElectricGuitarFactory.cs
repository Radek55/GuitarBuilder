using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    class ElectricGuitarFactory : GuitarFactory
    {
        public string Name()
        {
            return "electric";
        }
        public Guitar CreateStrings()
        {
            return new Strings(6, 0.11);
        }
        public Guitar CreateBody()
        {
            return new WoodenParts("basswood", "white");
        }
        public Guitar CreateNeck()
        {
            return new Neck("maple", 25.0);
        }
        public Guitar CreatePickups()
        {
            return new Electronics(2, "humbucker");
        }
    }
}
