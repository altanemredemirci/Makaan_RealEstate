using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;


namespace Makaan_BLL
{
    public class ImageMethods
    {
        private static string GenerateUniqueFileName(string fileExtension = ".png")
        {
            var timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            var uniqeuName = $"{timeStamp}{fileExtension}";

            return uniqeuName;
        }

        public static async Task<string> UploadImage(IFormFile file)
        {
            string newFileName = GenerateUniqueFileName();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", newFileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return newFileName;
        }

        public static void DeleteImage(string fileName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", fileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }
    }
}
