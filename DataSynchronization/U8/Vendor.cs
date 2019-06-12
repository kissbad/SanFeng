using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.U8
{
    /// <summary>
    /// 供应商档案
    /// </summary>
    class Vendor : DataInfor
    {
        public string cVenCode { get; set; }
        public string cVenName { get; set; }
        public string cVenAbbName { get; set; }
        public string cVCCode { get; set; }

        public void Save()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"if exists(select 1 from Vendor where cVenCode = @cVenCode)
begin
update a set cVenName = @cVenName,cVenAbbName = @cVenAbbName from Vendor a where cVenCode = @cVenCode
end 
else
begin
insert into Vendor(cVenCode,cVenName,cVenAbbName,cVCCode,cVenHeadCode,cVenExch_name)
values(@cVenCode,@cVenName,@cVenAbbName,@cVCCode,@cVenCode,'人民币')
end";
                conn.Execute(sql, this);
            }
        }
    }
}
