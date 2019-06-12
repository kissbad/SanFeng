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
    /// 客户档案
    /// </summary>
    class Customer : DataInfor
    {
        public string cCusCode { get; set; }
        public string cCusName { get; set; }
        public string cCusAbbName { get; set; }
        public string cCCCode { get; set; }

        public void Save()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"if exists(select 1 from Customer where cCusCode = @cCusCode)
begin
update a set cCusName = @cCusName,cCusAbbName = @cCusAbbName,cCCCode = @cCCCode 
from Customer a where cCusCode = @cCusCode
end
else
begin
insert into Customer(cCusCode,cCusName,cCusAbbName,cCCCode,cCusHeadCode,iId,cInvoiceCompany,cCusExch_name,
cCusCreditCompany,cCusMngTypeCode,account_type)
values(@cCusCode,@cCusName,@cCusAbbName,@cCCCode,@cCusCode,@cCusCode,@cCusCode,'人民币',
@cCusCode,999,26)
end";
                conn.Execute(sql, this);
            }
        }
    }
}
