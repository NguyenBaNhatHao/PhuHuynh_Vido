using PhuHuynh_Vido.Shared;

namespace PhuHuynh_Vido.Client.Services.IMSServices
{
    public interface IIMSService
    {
        List<UserIMS> UserIMSServices { get; set; }
        HttpResponseMessage RequestMessage { get; set; }
        Task<string> GetUserIMS(UserIMS userIMS);
    }
}
