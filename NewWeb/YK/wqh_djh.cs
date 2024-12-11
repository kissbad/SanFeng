namespace NewWeb.YK
{
    public class wqh_djh
    {
        public int PICKDOCID { get; set; }
        public DateTime CREDATE { get; set; }
        public int USESTATUS { get; set; }
        public int DRAWSTATUS { get; set; }
        public int XSZT { get; set; }

        public static int first_jhd()
        {
            string sql = @"select Pickdocid from wqh_djh where rownum = 1";

            var data = Oracle.ExecuteDataTable(sql);
            if (data.Rows.Count <= 0) throw new Exception("无待拣货单！！");

            return Convert.ToInt32(data.Rows[0][0]);
        }
    }
}
