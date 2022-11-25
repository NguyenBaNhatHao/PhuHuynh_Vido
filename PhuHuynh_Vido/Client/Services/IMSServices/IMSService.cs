﻿using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using PhuHuynh_Vido.Shared;
using PhuHuynh_Vido.Shared.Dtos;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;

namespace PhuHuynh_Vido.Client.Services.IMSServices
{
    public class IMSService : IIMSService
    {
        public readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;
        public List<UserIMS> UserIMSServices { get; set; } = new List<UserIMS>();
        public HttpResponseMessage RequestMessage { get; set; }
        public IMSService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public async Task<string> GetUserIMS(UserIMS userIMS)
        {
            string searchDiemdanh = JsonConvert.SerializeObject(userIMS);
            HttpContent c = new StringContent(searchDiemdanh, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = await _http.PostAsync("http://localhost:8086/login", c);
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;

            //var result = await _http.PostAsJsonAsync("http://localhost:8086/login", userIMS);
            //RequestMessage = result;
            //await SetUserIMS(result);
        }
        private async Task SetUserIMS(HttpResponseMessage result)
        {
            Console.WriteLine(result.StatusCode);
            _navigationManager.NavigateTo("");
        }
    }
}
