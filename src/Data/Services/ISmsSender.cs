using System.Threading.Tasks;

namespace Data.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
