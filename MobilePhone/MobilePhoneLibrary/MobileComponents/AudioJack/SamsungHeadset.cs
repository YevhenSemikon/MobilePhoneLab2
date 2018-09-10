using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.MobileComponents.AudioJack {
    public class SamsungHeadset : IPlayback {
        private ConsoleOutput Output;
        public SamsungHeadset(ConsoleOutput output) {
            Output = output;
            Output.WriteLine($"{nameof(SamsungHeadset)} playback selected");
        }
        public void Play() {
            Output.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
        public override string ToString() {
            return "SamsungHeadset";
        }
    }
}
