using System.Text.Json;

namespace NewWeb.IP_analyse
{
    public class IP_information
    {
        public string? address { get; set; }
        static readonly HttpClient client = new HttpClient();
        public static async Task<IP_information> get_infor(string? IP)
        {
            string url = "https://searchplugin.csdn.net/api/v1/ip/get?ip=" + IP;

            Response rep;
            string respContent;

            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                respContent = await response.Content.ReadAsStringAsync();
                rep = JsonSerializer.Deserialize<Response>(respContent);

                if (rep.code != 200) { return new IP_information { address = rep.msg }; }
                return new IP_information { address = rep?.data?.address };
            }
        }
    }
}
