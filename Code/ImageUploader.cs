using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet.Code
{
    public static class ImageUploader
    {
        public static async Task Upload(IWebHostEnvironment environment, IFormFile Image, string folder, string name)
        {
            if (Image != null)
            {
                var directory = $"{environment.WebRootPath}/img/{folder}/";
                Directory.CreateDirectory(directory);
                var file = Path.Combine(directory, $"{name}.jpg");

                using (var fileStream = new FileStream(file, FileMode.Create))
                {
                    await Image.CopyToAsync(fileStream);
                }
            }
        }
    }
}
