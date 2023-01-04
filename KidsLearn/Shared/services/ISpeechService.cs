using KidsLearn.Shared.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearn.Shared.services
{
    public interface ISpeechService
    {
        Task Speak(string TextToSpeak, double Speed, int Pitch, string SelectedVoice);

        Task StopSpeaking();

        Task PauseSpeaking();

        Task<List<Language>> GetSupportedVoices();
    }
}
