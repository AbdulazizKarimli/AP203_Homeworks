using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Bicycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}
