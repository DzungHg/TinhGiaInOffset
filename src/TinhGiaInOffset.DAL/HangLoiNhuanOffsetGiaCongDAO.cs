using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using TinhGiaInOffset.Common;
using TinhGiaInOffset.BDO;

namespace TinhGiaInOffset.DAL
{
    public class HangLoiNhuanOffsetGiaCongDAO
    {
        public IEnumerable<HangLoiNhuanOffsetGiaCongBDO> DocTatCa()
        {
            const string tenDB = "QuanLyGiaIn";
            IEnumerable<HangLoiNhuanOffsetGiaCongBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<HangLoiNhuanOffsetGiaCongBDO>("dbo.spHangLoiNhuanOffsetGiaCong_DocTatCa");
                return output;
            }
        }
    }
}
