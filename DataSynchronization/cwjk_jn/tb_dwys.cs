using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.cwjk_jn
{
    class tb_dwys : DataInfor
    {
        public int id { get; set; }
        public int type { get; set; }
        public string yws { get; set; }
        public string cws { get; set; }
        public string ywdwn { get; set; }
        public string cwdwn { get; set; }
        public string pk_corp { get; set; }
        public string is_zdsc { get; set; }

        public void Save()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"if not exists(select 1 from tb_dwys where yws = @yws and type = @type)
begin
	insert into tb_dwys(type,yws,cws,ywdwn,cwdwn,is_zdsc)
	select @type,@yws,@cws,@ywdwn,@cwdwn,@is_zdsc 
end";
                conn.Execute(sql, this);
            }
        }
    }
}
