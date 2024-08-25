using System.ComponentModel.DataAnnotations;

namespace GamingStoreTekrar.CustomValidations
{
    public class FileValidator : ValidationAttribute
    {
        public FileValidator()
        {
            ErrorMessage = "Fayl movcud deyildir";
        }

        public string? AcceptedTypes { get; set; }

        public override bool IsValid(object? value)
        {
            if (string.IsNullOrWhiteSpace(AcceptedTypes))
                return true;

            if (value != null && value is IFormFile file)
            {
                var ext = Path.GetExtension(file.FileName);
                var accepteds = AcceptedTypes.Split(',');

                foreach (var accepted in accepteds)
                {
                    if (accepted.Trim().ToLower() == ext.Trim().ToLower())
                        return true;
                }
            }

            return false;
        }
    }
}
