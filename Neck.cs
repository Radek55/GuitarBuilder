using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    class Neck : Guitar
    {
        public Neck(string fingerboardMaterial, double scaleLenght)
        {
            FingerboardMaterial = fingerboardMaterial;
            ScaleLenght = scaleLenght;
        }
        public override string ToString()
        {
            return FingerboardMaterial + " fingerboard (" + ScaleLenght + "' scale),";
        }
    }
}
