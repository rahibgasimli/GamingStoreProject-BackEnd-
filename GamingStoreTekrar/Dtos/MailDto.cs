using MimeKit;

namespace GamingStoreTekrar.Dtos
{
    public class MailDto
    {
        public List<MailboxAddress> Addresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
