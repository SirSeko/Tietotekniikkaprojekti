using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sovitushuone.Models
{
    public interface IBlobService
    {
        Task GetBlobAsync(string blobName);
        public Task<IEnumerable<string>> ListBlobsAsync();

        

        
    }
}