using GamingStoreTekrar.Dtos;

namespace GamingStoreTekrar.Abstractions
{
    public interface IEmailService
    {
        Task SendAsync(MailDto mailDto);
    }
}
