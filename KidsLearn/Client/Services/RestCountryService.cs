using KidsLearn.Client.Pages.Hangman;
using KidsLearn.Shared.models;
using KidsLearn.Shared.services;
using System.Net.Http.Json;

namespace KidsLearn.Client.Services
{
    public class RestCountryService : ICountryService
    {
        HttpClient Http;
        string wordMeaningEndpoint = "https://restcountries.com/v2/all?fields=name,capital,currencies";

        public RestCountryService(HttpClient http)
        {
            Http = http;
        }
        public async Task<IEnumerable<Country>> GetCountries()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, wordMeaningEndpoint);

            var response = await Http.SendAsync(request);
            var value = await response.Content.ReadAsStringAsync();
            return await response.Content.ReadFromJsonAsync<List<Country>>();
        }
    }
}
