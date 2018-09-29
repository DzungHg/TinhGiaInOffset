using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using TinhGiaInOffset.Common;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.DAL.IRespos;

namespace TinhGiaInOffset.DAL
{
    public class NhaInOffsetDAO : INhaInOffset
    {
        const string tenDB = "QuanLyGiaIn";
        public IEnumerable<NhaInOffsetBDO> DocTatCa()
        {
            IEnumerable<NhaInOffsetBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<NhaInOffsetBDO>("dbo.spNhaInOffset_DocTatCa");
                return output;
            }
        }

        public NhaInOffsetBDO DocTheoId(int id)
        {
            NhaInOffsetBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<NhaInOffsetBDO>("dbo.spNhaInOffset_DocTheoId", id).SingleOrDefault();
                return output;

            }
        }

        public void Sua(NhaInOffsetBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@id", entityBDO.Id);
                p.Add("@TenNhaIn", entityBDO.TenNhaIn);
                p.Add("@DiaChi", entityBDO.DiaChi);
                p.Add("@DienThoai", entityBDO.DienThoai);
                p.Add("@LienHe", entityBDO.LienHe);

                //Excecute
                connection.Execute("dbo.spNhaInOffset_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }
        }
      
        public void Them(NhaInOffsetBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@TenNhaIn", entityBDO.TenNhaIn);
                p.Add("@DiaChi", entityBDO.DiaChi);
                p.Add("@DienThoai", entityBDO.DienThoai);
                p.Add("@LienHe", entityBDO.LienHe);
               

                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spNhaInOffset_Them", p, commandType: CommandType.StoredProcedure);
                //xử lý id out
                entityBDO.Id = p.Get<int>("@id");
                ///nếu cần có thể
                ///đặt return ở đay cũng được
            }
        }

        public void Xoa(int id)
        {
            throw new NotImplementedException();
        }
    }
}
