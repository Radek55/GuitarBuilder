using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    class Guitar
    {
        public void Info()
        {
            Console.WriteLine("Unknown");
        }
        public string WoodType { get; set; }
        public string Color { get; set; }
        public int Amount { get; set; }
        public double Size { get; set; }
        public int PickupAmount { get; set; }
        public string PickupType { get; set; }
        public string FingerboardMaterial { get; set; }
        public double ScaleLenght { get; set; }
    }
}
