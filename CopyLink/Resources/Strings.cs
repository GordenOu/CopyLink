using Core.Resources.Json;

namespace CopyLink.Resources
{
    internal class Strings : JsonResource<Strings>
    {
        public static string Message => GetString(nameof(Message));
    }
}
