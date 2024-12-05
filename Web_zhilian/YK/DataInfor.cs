namespace Web_zhilian.YK
{
    public class DataInfor
    {
        public static readonly string ConnectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Database:ConnectionString")?.Value;
    }
}
