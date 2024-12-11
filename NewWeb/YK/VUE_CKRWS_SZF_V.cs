namespace NewWeb.YK
{
    public class VUE_CKRWS_SZF_V
    {
        public int COUNT { get; set; }
        public int RWLX { get; set; }

        public static int count_wjh()
        {
            var data = Oracle.ExecuteDataTable("SELECT nvl(SUM(COUNT),0) as COUNT FROM VUE_CKRWS_SZF_V a WHERE COUNT<>0");
            return WQH.Convert.TableToList<VUE_CKRWS_SZF_V>(data)[0].COUNT;
        }

        public static List<VUE_CKRWS_SZF_V> get_list()
        {
            var data = Oracle.ExecuteDataTable("SELECT COUNT,RWLX FROM VUE_CKRWS_SZF_V WHERE nvl(COUNT,0) <> 0");
            return WQH.Convert.TableToList<VUE_CKRWS_SZF_V>(data);
        }
    }
}
