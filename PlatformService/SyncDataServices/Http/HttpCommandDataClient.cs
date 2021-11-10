
using System.Text;
using System.Text.Json;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClinet;

        public IConfiguration _configuration { get; }

        public HttpCommandDataClient(HttpClient httpClient,IConfiguration configuration)
        {
             _httpClinet = httpClient;
             _configuration=configuration;
        }

        async Task  ICommandDataClient.SendPlatformToCommand(PlatformReadDto plat)
        {
            var httpContent=new StringContent(
                JsonSerializer.Serialize(plat),
                Encoding.UTF8,
                "application/json"
            );
            var response= await _httpClinet.PostAsync($"{_configuration["CommandService"]}/api/c/platforms",httpContent);
            if(response.IsSuccessStatusCode)
                Console.WriteLine("---> Sync POST To Command service was okay");
            else    
                Console.WriteLine("---> Sync POST to CommandService was not okay");
        }
    }
}