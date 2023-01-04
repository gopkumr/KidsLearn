using KidsLearn.Shared.models;
using KidsLearn.Shared.services;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace KidsLearn.Client.Services
{
    public class DictionaryApiDictionaryService : IDictionaryService
    {
        HttpClient Http;
        string wordMeaningEndpoint = "https://api.dictionaryapi.dev/api/v2/entries/en/{0}";

        public DictionaryApiDictionaryService(HttpClient http)
        {
            Http = http;
        }

        public async Task<List<DictionaryResponse>> GetMoreAboutTheWord(string word)
        {
            var uri = string.Format(wordMeaningEndpoint,word);
            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = await Http.SendAsync(request);
            var value = await response.Content.ReadAsStringAsync();
            return await response.Content.ReadFromJsonAsync<List<DictionaryResponse>>();
        }
    }
}
