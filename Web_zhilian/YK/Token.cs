namespace Web_zhilian.YK
{
    public class Token
    {
        public string userid { get; set; }
        public string token { get; set; }
        public DateTime expire_time { get; set; }
        public DateTime create_time { get; set; }

        private static string GenerateToken(string user_id, string pass_word, DateTime expire_time)
        {
            return WQH.String.CreateMD5Hash(user_id + "|" + pass_word + "|" + expire_time.ToString());
        }
    }
}
