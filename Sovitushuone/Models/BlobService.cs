using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sovitushuone.Models
{
    public class BlobService : IBlobService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public BlobService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task<BlobInfo> GetBlobAsync(string blobName)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient("models");
            var blobClient = containerClient.GetBlobClient(blobName);
            var blobDownloadInfo = await blobClient.DownloadAsync();
            return new BlobInfo(blobDownloadInfo.Value.Content, blobDownloadInfo.Value.ContentType);
        }

        public async Task<IEnumerable<string>> ListBlobsAsync()
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient("models");
            var items = new List<string>();

            await foreach(var blobItem in containerClient.GetBlobsAsync())
            {
                items.Add(blobItem.Name);

            }
            return items;
        }

        
    }
    
}
