using Microsoft.AspNetCore.Http;

namespace HeartCore.Models.Uploads
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
