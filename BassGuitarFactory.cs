using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    class BassGuitarFactory : GuitarFactory
    {
        public string Name()
        {
            return "bass";
        }
        public Guitar CreateStrings()
        {
            return new Strings(4, 0.45);
        }
        public Guitar CreateBody()
        {
            return new WoodenParts("mahogany","black");
        }
        public Guitar CreateNeck()
        {
            return new Neck("indian naurel", 34.0);
        }
        public Guitar CreatePickups()
        {
            return new Electronics(2,"single coil");
        }
    }
}
