using System.Security.Cryptography;

namespace GamingStoreTekrar.Extensions
{
    public static class FormFileExtensions
    {
        public static string GenerateUploadName(this IFormFile file)
        {
            var ext = Path.GetExtension(file.FileName);
            var bytes = new byte[20];
            var rng = RandomNumberGenerator.Create();

            rng.GetBytes(bytes);
            var newName = Convert.ToBase64String(bytes);
            newName = newName.Replace("/", "_");
            newName = newName.Replace("\\", "_");

            return $"{newName}{ext}";
        }

        public static long GetSizeKb(this IFormFile file) => file.Length / 1024;

    }
}
