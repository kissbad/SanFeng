using API.IP_analyse;


namespace API
{
    public class Com
    {
        public static async void IP_record(HttpContext httpContext) {
            string? sourceIP = httpContext.Connection.RemoteIpAddress?.ToString();
            int port = httpContext.Connection.RemotePort;
            string path = httpContext.Request.Path;

            IP_information respContent = await IP_information.get_infor(sourceIP);


            new YK.WQH_WEBLOG { CREATEDATE = DateTime.Now, IP = sourceIP, PORT = port ,PATH = path, ADDRESS = respContent.address }.Save();
        }
    }
}
