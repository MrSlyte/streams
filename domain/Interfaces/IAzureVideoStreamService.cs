using System.IO;
using System.Threading.Tasks;

namespace domain.Interfaces
{
    public interface IAzureVideoStreamService
    {
        Task<Stream> GetVideoByName(string name);
    }
}
