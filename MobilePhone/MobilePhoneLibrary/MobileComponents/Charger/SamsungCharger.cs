﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.MobileComponents.Charger {
    public class SamsungCharger : ICharge {
        private ConsoleOutput Output;
        public SamsungCharger(ConsoleOutput output)
        {
            Output = output;
            Output.WriteLine($"{nameof(SamsungCharger)} charger selected");
        }
        public void Charge()
        {
            Output.WriteLine($"Charging by {nameof(SamsungCharger)}");
        }

        public override string ToString()
        {
            return "SamsungCharger";
        }
    }
}