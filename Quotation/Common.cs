namespace Quotation
{
    public class Common
    {
        public static readonly string? CompanyName = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Other:CompanyName")?.Value;
        public static readonly string? logo = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Other:logo")?.Value;
    }
}
