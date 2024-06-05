using Microsoft.Extensions.Options;

namespace NewWeb.Models
{
    public class DBSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string get(IOptions<Models.DBSettings> s) {
            return s.Value.ConnectionString;
        }
    }
}
