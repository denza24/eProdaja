using Flurl.Http;

namespace WinUI
{
    public class APIService
    {
        private string _apiUrl = "https://localhost:44360/api/";
        private string _resource { get; set; }

        public APIService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> Get<T>()
        {
            return await $"{_apiUrl}{_resource}".GetJsonAsync<T>();
        }
    }
}
