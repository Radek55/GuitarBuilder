using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie5
{
    class Electronics : Guitar
    {
        public Electronics(int pickupAmount, string pickupType)
        {
            PickupAmount = pickupAmount;
            PickupType = pickupType;
        }
        public override string ToString()
        {
            return PickupAmount + " " + PickupType + " pickups";
        }
    }
}
