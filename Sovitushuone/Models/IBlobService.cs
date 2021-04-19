using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sovitushuone.Models
{
    public interface IBlobService
    {
        // BlobPalvelun interface
        Task<BlobInfo> GetBlobAsync(string blobName);
       
        public Task<IEnumerable<string>> ListBlobsAsync();

        

        
    }
}