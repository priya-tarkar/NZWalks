using Azure.Storage.Blobs;

namespace bookproject.Helper
{
    public static class FileHelper
    {
        public static async Task<String> UploadImage(IFormFile file)
        {
            String filename = Guid.NewGuid().ToString();
            String connectionString = @"DefaultEndpointsProtocol=https;AccountName=shoppingcartaccount;AccountKey=gW8zCvpYuF3Ywwm3FLz/zOaWNjCHoysz2XANMMzRIDLD+pnOkLhVlau7ojhwXSfGAjdi+sG6+D1H+AStrUS4rQ==;EndpointSuffix=core.windows.net";
            String containername = "bookphotos";
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containername);
            BlobClient blobClient = containerClient.GetBlobClient(filename+file.FileName);
            MemoryStream ms = new MemoryStream();
            await file.CopyToAsync(ms);
            ms.Position = 0;
            await blobClient.UploadAsync(ms);
            return blobClient.Uri.AbsoluteUri;

        }

        public static async Task<String> UploadUrl(IFormFile file)
        {
            String filename = Guid.NewGuid().ToString();

            String connectionString = @"DefaultEndpointsProtocol=https;AccountName=shoppingcartaccount;AccountKey=gW8zCvpYuF3Ywwm3FLz/zOaWNjCHoysz2XANMMzRIDLD+pnOkLhVlau7ojhwXSfGAjdi+sG6+D1H+AStrUS4rQ==;EndpointSuffix=core.windows.net";
            String containername = "bookurl";
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containername);
            BlobClient blobClient = containerClient.GetBlobClient(filename+file.FileName);
            MemoryStream ms = new MemoryStream();
            await file.CopyToAsync(ms);
            ms.Position = 0;
            await blobClient.UploadAsync(ms);
            return blobClient.Uri.AbsoluteUri;

        }
    }
}
