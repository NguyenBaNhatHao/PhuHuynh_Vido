using PhuHuynh_Vido.Shared;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Net.Http.Json;
using PhuHuynh_Vido.Shared.Dtos;

namespace PhuHuynh_Vido.Client.Services.PhuhuynhServices
{
    public class PhuhuynhService : IPhuhuynhService
    {
        public readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public List<UserPH> UserPHServices { get; set; } = new List<UserPH>();
        public HttpResponseMessage RequestMessage { get; set; }
        public PhuhuynhService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public async Task GetUserPH()
        {
            var resutl = await _http.GetFromJsonAsync<List<UserPH>>("api/phuhuynh");
            if (resutl != null)
            {
                UserPHServices = resutl;
            }
        }

        public async Task CreatePH(UserPHDTO userPHDTO)
        {
            var result = await _http.PostAsJsonAsync("http://localhost:8086/registerPH", userPHDTO);
            RequestMessage = result;
            await SetPhuhuynh(result);
        }
        private async Task SetPhuhuynh(HttpResponseMessage result)
        {
            Console.WriteLine(result.StatusCode);
            _navigationManager.NavigateTo("");
        }
    }
}
