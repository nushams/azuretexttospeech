using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Threading.Tasks;

namespace TextToSpeech
{
    class Program
    {
        static async Task Main()
        {
            await SynthesizeAudioAsync();
        }

        static async Task SynthesizeAudioAsync()
        {
            var config = SpeechConfig.FromSubscription("48a4ded4c654418592712c18acf2a428", "eastus");
            using var synthesizer = new SpeechSynthesizer(config);

            await synthesizer.SpeakTextAsync("Hi, I am neural text to speech from Azure AI. I warmly welcome Google Dev Fest participants in December 2023!");
        }
    }

}