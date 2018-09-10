using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.MobileComponents.AudioJack {
    public class iPhoneHeadset : IPlayback {
        private ConsoleOutput Output;
        public iPhoneHeadset(ConsoleOutput output) {
            Output = output;
            Output.WriteLine($"{nameof(iPhoneHeadset)} playback selected");
        }
        public void Play() {
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }
        public override string ToString() {
            return "iPhoneHeadset";
        }
    }
}
