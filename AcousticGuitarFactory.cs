using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    class AcousticGuitarFactory : GuitarFactory
    {
        public string Name()
        {
            return "acoustic";
        }
        public Guitar CreateStrings()
        {
            return new Strings(6, 0.09);
        }
        public Guitar CreateBody()
        {
            return new WoodenParts("spruce", "black");
        }
        public Guitar CreateNeck()
        {
            return new Neck("rosewood", 24.5);
        }
        public Guitar CreatePickups()
        {
            return new Electronics(1, "piezo");
        }
    }
}
