using KidsLearn.Shared.models;
using KidsLearn.Shared.services;
using Microsoft.JSInterop;

namespace KidsLearn.Client.Services
{
    public class JSSpeechService : ISpeechService
    {
        private readonly IJSRuntime _js;

        public JSSpeechService(IJSRuntime js)
        {
            _js = js;
        }
        public async Task<List<Language>> GetSupportedVoices()
        {
           return await _js.InvokeAsync<List<Language>>("getAllVoices");
        }

        public async Task PauseSpeaking()
        {
            await _js.InvokeVoidAsync("pauseSpeaking");
        }

        public async Task Speak(string TextToSpeak, double Speed, int Pitch, string SelectedVoice)
        {
            await _js.InvokeVoidAsync("speakText", TextToSpeak, Speed, Pitch, SelectedVoice);
        }

        public async Task StopSpeaking()
        {
            await _js.InvokeVoidAsync("stopSpeaking");
        }
    }
}
