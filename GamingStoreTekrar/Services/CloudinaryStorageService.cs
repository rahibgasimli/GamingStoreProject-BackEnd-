using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using GamingStoreTekrar.Abstractions;
using GamingStoreTekrar.Dtos;
using GamingStoreTekrar.Extensions;
using GamingStoreTekrar.OptionTypes;

namespace GamingStoreTekrar.Services
{
    public class CloudinaryStorageService : IStorageService
    {
        public CloudinaryStorageService(CloudinaryOptions options)
        {
            var acc = new Account(cloud: options.CloudName, apiKey: options.ApiKey, apiSecret: options.ApiSecret);

            _cloudinary = new Cloudinary(acc);
        }


        private readonly Cloudinary _cloudinary;


        public Task DeleteFileAsync(string dirPath, string fileName)
        {
            throw new NotImplementedException();
        }

        public bool HasFile(string dirPath, string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task<UploadFileDto> UploadFileAsync(string dirPath, IFormFile file)
        {
            var directories = await _cloudinary.RootFoldersAsync();
            bool dirExists = false;

            foreach (var directory in directories.Folders)
            {
                dirExists = directory.Name == dirPath;
            }

            if (!dirExists)
            {
                await _cloudinary.CreateFolderAsync(dirPath);
            }

            var uploadName = file.GenerateUploadName();
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription()
                {
                    FileName = uploadName,
                    FilePath = $"{dirPath}/{uploadName}",
                    FileSize = file.GetSizeKb(),
                    Stream = file.OpenReadStream(),
                },
                PublicId = uploadName,
                Folder = dirPath
            };

            var res = await _cloudinary.UploadAsync(uploadParams);

            return new()
            {
                FileName = res.PublicId,
                FullPath = res.Url.AbsoluteUri,
                Extensions = Path.GetExtension(uploadName)
            };

        }

        public async Task<List<UploadFileDto>> UploadFilesAsync(string dirPath, IFormFileCollection files)
        {
            var uploadedFiles = new List<UploadFileDto>();

            foreach (var file in files)
            {
                var dto = await UploadFileAsync(dirPath, file);
                uploadedFiles.Add(dto);
            }

            return uploadedFiles;
        }
    }
}
