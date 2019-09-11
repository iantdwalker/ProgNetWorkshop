using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace ImageAnalyse.Repository
{
    public class FileToImage
    {
        private string BytesToSrcString(byte[] bytes) => "data:image/jpg;base64, " + Convert.ToBase64String(bytes);

        public string FileToImgSrcString(IFormFile file){
            byte[] fileBytes;
            using (var stream = file.OpenReadStream()){
                using (var memoryStream = new MemoryStream()){
                    stream.CopyTo(memoryStream);
                    fileBytes = memoryStream.ToArray();
                }
            }

            return BytesToSrcString(fileBytes);
        }
    }
}

