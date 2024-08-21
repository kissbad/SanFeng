using NewWeb.IP_analyse;

namespace NewWeb
{
    public class Com
    {
        public static async void IP_record(HttpContext httpContext)
        {
            string? sourceIP = httpContext?.Connection.RemoteIpAddress?.ToString();
            int? port = httpContext?.Connection.RemotePort;
            string? path = httpContext?.Request.Path;

            IP_information respContent = await IP_information.get_infor(sourceIP);


            new YK.WQH_WEBLOG { CREATEDATE = DateTime.Now, IP = sourceIP, PORT = (int)(port.HasValue? port:0), PATH = path, ADDRESS = respContent.address }.Save();
        }
    }
}
