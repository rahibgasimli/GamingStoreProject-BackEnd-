using GamingStoreTekrar.Dtos;

namespace GamingStoreTekrar.Abstractions
{
    public interface IStorageService
    {
        Task DeleteFileAsync(string dirPath, string fileName);
        bool HasFile(string dirPath, string fileName);
        Task<UploadFileDto> UploadFileAsync(string dirPath, IFormFile file);
        Task<List<UploadFileDto>> UploadFilesAsync(string dirPath, IFormFileCollection files);
    }
}
