using PhuHuynh_Vido.Shared;
using PhuHuynh_Vido.Shared.Dtos;

namespace PhuHuynh_Vido.Client.Services.PhuhuynhServices
{
    public interface IPhuhuynhService
    {
        List<UserPH> UserPHServices { get; set; }
        HttpResponseMessage RequestMessage { get; set; }
        Task GetUserPH();
        Task CreatePH(UserPHDTO userPHDTO);
    }
}
