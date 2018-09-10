using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.MobileComponents.AudioJack {
    public class PhoneSpeaker : IPlayback {
        private ConsoleOutput Output;
        public PhoneSpeaker(ConsoleOutput output) {
            Output = output;
            Output.WriteLine($"{nameof(PhoneSpeaker)} playback selected");
        }
        public void Play() {
            Output.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
        public override string ToString() {
            return "PhoneSpeaker";
        }
    }
}
