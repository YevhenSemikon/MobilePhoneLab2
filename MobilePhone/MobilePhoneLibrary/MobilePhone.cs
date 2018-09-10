using MobilePhone.MobileComponents.Battery;
using MobilePhone.MobileComponents.Speaker;
using MobilePhone.MobileComponents.Microphone;
using MobilePhone.MobileComponents.Screen;
using MobilePhone.MobileComponents.SimCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.MobileComponents.AudioJack;
using MobilePhone.MobileComponents.Charger;
using MobilePhone.MobileComponents;

namespace MobilePhone {
    public abstract class MobilePhone {
        private IPlayback vplaybackComponent;
        private ICharge vchargerComponent;
        private ConsoleOutput output = new ConsoleOutput();
        public IPlayback PlaybackComponent {
            get { return vplaybackComponent; }
            set {
                vplaybackComponent = value;
                output.WriteLine("Set playback to Mobile...");
            }
        }
        public ICharge ChargerComponent {
            get { return vchargerComponent; }
            set {
                vchargerComponent = value;
                output.WriteLine("Set charger to Mobile...");
            }
        }
        public abstract ScreenBase Screen { get; }
        public abstract MicrophoneBase Microphone { get; }
        public abstract BatteryBase Battery { get; }
        public abstract SpeakerBase Speaker { get; }
        public abstract SimCardBase SimCard { get; }
        private void Show(IScreenImage screenImage) { Screen.Show(screenImage); }
        public void GetDescription() {
            Console.Clear();
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Microphone Type: {Microphone.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Speaker Type: {Speaker.ToString()}");
            descriptionBuilder.AppendLine($"SimCard Type: {SimCard.ToString()}");
            descriptionBuilder.AppendLine($"AudioJack Type: {PlaybackComponent?.ToString() ?? "AudioJack is not set"}");
            descriptionBuilder.AppendLine($"Charger Type: {ChargerComponent?.ToString() ?? "Charger is not set"}");
            output.WriteLine(descriptionBuilder.ToString());
        }
        public void Play() {
            PlaybackComponent.Play();
        }
        public void Charge() {
            ChargerComponent.Charge();
        }
    }
}
