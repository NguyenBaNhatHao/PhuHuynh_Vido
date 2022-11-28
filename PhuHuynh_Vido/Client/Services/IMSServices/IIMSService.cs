using PhuHuynh_Vido.Shared;
using PhuHuynh_Vido.Shared.Dtos;
namespace PhuHuynh_Vido.Client.Services.IMSServices
{
    public interface IIMSService
    {
        List<UserIMS> UserIMSServices { get; set; }
        UserIMSDTO userIMSDTOServices { get; set; }
        HttpResponseMessage RequestMessage { get; set; }
        Task GetUserIMS(UserIMS userIMS);
    }
}
