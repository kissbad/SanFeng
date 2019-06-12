using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.U8
{
    class fitemss97:DataInfor
    {
        public int I_id { get; set; }
        public string citemcode { get; set; }
        public string citemname { get; set; }
        public int bclose { get; set; }
        public string citemccode { get; set; }
        public int iotherused { get; set; }
        public DateTime dEndDate { get; set; }

        public void Save()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"if exists(select 1 from fitemss97 where citemcode = @citemcode)
begin 
	update a set a.citemname = @citemname,a.bclose = @bclose
	from fitemss97 a where citemcode = @citemcode
end
else
begin
	insert into fitemss97(citemcode,citemname,bclose,citemccode)
	select @citemcode,@citemname,@bclose,citemccode 
	from fitemss97class where  cItemCname = '单位联系人'
end";
                conn.Execute(sql, this);
            }
        }
    }
}
