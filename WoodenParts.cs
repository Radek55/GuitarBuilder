using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    class WoodenParts : Guitar
    {
        public WoodenParts(string woodType, string color)
        {
            WoodType = woodType;
            Color = color;
        }
        public override string ToString()
        {
            return "with " + Color + " " + WoodType + " body,";
        }
    }
}
