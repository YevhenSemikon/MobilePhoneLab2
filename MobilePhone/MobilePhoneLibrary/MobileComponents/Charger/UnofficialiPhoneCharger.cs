using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.MobileComponents.Charger {
    public class UnofficialiPhoneCharger : ICharge {
        private ConsoleOutput Output;
        public UnofficialiPhoneCharger(ConsoleOutput output)
        {
            Output = output;
            Output.WriteLine($"{nameof(UnofficialiPhoneCharger)} selected");
        }
        public void Charge()
        {
            Output.WriteLine($"Charging by {nameof(UnofficialiPhoneCharger)}");
        }
        public override string ToString()
        {
            return "UnofficialiPhoneCharger";
        }
    }
}
