using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.MobileComponents.AudioJack {
    public class UnofficialiPhoneHeadset : IPlayback {
        private ConsoleOutput Output;
        public UnofficialiPhoneHeadset(ConsoleOutput output)
        {
            Output = output;
            Output.WriteLine($"{nameof(UnofficialiPhoneHeadset)} playback selected");
        }
        public void Play() {
            Output.WriteLine($"{nameof(UnofficialiPhoneHeadset)} sound");
        }

        public override string ToString()
        {
            return "UnofficialiPhoneHeadset";
        }
    }
}
