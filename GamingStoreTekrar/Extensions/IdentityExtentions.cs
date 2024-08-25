using Microsoft.AspNetCore.Identity;

namespace GamingStoreTekrar.Extensions
{
    public static class IdentityExtentions
    {
        public static string ErrorsToString(this IEnumerable<IdentityError> errors) => string.Join("\n",errors.Select(e => e.Description).ToList());
    }
}
