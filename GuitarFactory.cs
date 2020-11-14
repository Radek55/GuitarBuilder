using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    interface GuitarFactory
    {
        public abstract Guitar CreateStrings();
        public abstract Guitar CreateBody();
        public abstract Guitar CreateNeck();
        public abstract Guitar CreatePickups();

    }
}
