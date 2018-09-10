using MobilePhone;
using MobilePhone.MobileComponents.Speaker;
using MobilePhone.MobileComponents.Screen;
using MobilePhone.MobileComponents.SimCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.MobileComponents.Battery;
using MobilePhone.MobileComponents.AudioJack;
using MobilePhone.MobileComponents.Charger;
using MobilePhone.MobileComponents;

namespace MobilePhoneProgram {
    class Program {
        static void Main(string[] args) {
            SimCorpMobilePhone mobile = new SimCorpMobilePhone();
            mobile.GetDescription();
            Console.WriteLine(System.Environment.NewLine + "Press any key to continue...");
            Console.ReadKey();
            IPlayback playbackComponent = SelectPlaybackComponent();
            mobile.PlaybackComponent = playbackComponent;
            mobile.Play();
            Console.WriteLine(System.Environment.NewLine + "Press any key to continue...");
            Console.ReadKey();
            ICharge chargerComponent = SelectChargerComponent();
            mobile.ChargerComponent = chargerComponent;
            mobile.Charge();
            Console.WriteLine(System.Environment.NewLine + "Press any key to continue...");
            Console.ReadKey();
            mobile.GetDescription();
        }
        private static ICharge SelectChargerComponent() {
            var consoleOutput = new ConsoleOutput();
            Console.Clear();
            ICharge chargeComponent = null;
            string chargeIndex = GetChosenIndex(chargeComponent);
            switch (chargeIndex) {
                case "1":
                chargeComponent = new iPhoneCharger(consoleOutput);
                break;
                case "2":
                chargeComponent = new SamsungCharger(consoleOutput);
                break;
                case "3":
                chargeComponent = new UnofficialiPhoneCharger(consoleOutput);
                break;
                default:
                Console.WriteLine("Unknown charger component selected, please select component from the list.");
                Console.WriteLine(System.Environment.NewLine + "Press any key to continue...");
                Console.ReadKey();
                chargeComponent = SelectChargerComponent();
                break;
            }
            return chargeComponent;
        }
        private static IPlayback SelectPlaybackComponent() {
            Console.Clear();
            var consoleOutput = new ConsoleOutput();
            IPlayback playbackComponent = null;
            string playbackIndex = GetChosenIndex(playbackComponent);
            switch (playbackIndex) {
                case "1":
                playbackComponent = new iPhoneHeadset(consoleOutput);
                break;
                case "2":
                playbackComponent = new SamsungHeadset(consoleOutput);
                break;
                case "3":
                playbackComponent = new UnofficialiPhoneHeadset(consoleOutput);
                break;
                case "4":
                playbackComponent = new PhoneSpeaker(consoleOutput);
                break;
                default:
                Console.WriteLine("Unknown playback component selected, please select component from the list.");
                Console.WriteLine(System.Environment.NewLine + "Press any key to continue...");
                Console.ReadKey();
                playbackComponent = SelectPlaybackComponent();
                break;
            }
            return playbackComponent;
        }
        private static string GetChosenIndex(IPlayback playbackComponent) {
            var text = new StringBuilder();
            text.Append("Select playback component (specify index): " + System.Environment.NewLine);
            text.Append("1 - iPhoneHeadset" + System.Environment.NewLine);
            text.Append("2 - SamsungHeadset" + System.Environment.NewLine);
            text.Append("3 - UnofficialiPhoneHeadset" + System.Environment.NewLine);
            text.Append("4 - PhoneSpeaker");
            Console.WriteLine(text.ToString());
            string playbackIndex = Console.ReadLine();
            return playbackIndex;
        }
        private static string GetChosenIndex(ICharge playbackComponent) {
            var text = new StringBuilder();
            text.Append("Select charger component (specify index): " + System.Environment.NewLine);
            text.Append("1 - iPhoneCharger" + System.Environment.NewLine);
            text.Append("2 - SamsungCharger" + System.Environment.NewLine);
            text.Append("3 - UnofficialiPhoneCharger");
            Console.WriteLine(text.ToString());
            string playbackIndex = Console.ReadLine();
            return playbackIndex;
        }
    }
}

