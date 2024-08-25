using GamingStoreTekrar.Abstractions;
using GamingStoreTekrar.Dtos;
using GamingStoreTekrar.Extensions;

namespace GamingStoreTekrar.Services
{
    public class LocalStorageService : IStorageService
    {
        public LocalStorageService(IWebHostEnvironment env)
        {
            _storagepath = Path.Combine(env.WebRootPath, "uploads");
        }

        private readonly string _storagepath;

        public async Task DeleteFileAsync(string dirPath, string fileName)
        {

            if (!HasFile(dirPath, fileName))
            {
                throw new FileNotFoundException("Bele bir fayl yoxdur");
            }
            else
            {
                var path = Path.Combine(_storagepath, dirPath, fileName);
                await Task.Run(() => File.Delete(path));
            }
        }

        public bool HasFile(string dirPath, string fileName)
        {

            var path = Path.Combine(_storagepath, dirPath, fileName);

            return File.Exists(path);
        }

        public async Task<UploadFileDto> UploadFileAsync(string dirPath, IFormFile file)
        {
            var path = Path.Combine(_storagepath, dirPath);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var uploadName = file.GenerateUploadName();
            var fs = File.Open(Path.Combine(path, uploadName), FileMode.CreateNew);
            await file.CopyToAsync(fs);
            fs.Close();

            return new()
            {
                FileName = uploadName,
                FullPath = $"{dirPath}/{uploadName}",
                Extensions = Path.GetExtension(uploadName)
            };

        }

        public async Task<List<UploadFileDto>> UploadFilesAsync(string dirPath, IFormFileCollection files)
        {
            var uploadedFiles = new List<UploadFileDto>();

            foreach (var file in files)
            {
                var result = await UploadFileAsync(dirPath, file);
                uploadedFiles.Add(result);
            }

            return uploadedFiles;
        }
    }
}
