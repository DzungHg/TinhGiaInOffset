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
    public class GiaInOffsetGiaCongDAO : IGiaInOffsetGiaCong
    {
        const string tenDB = "QuanLyGiaIn";
        public IEnumerable<GiaInOffsetGiaCongBDO> DocTatCa()
        {
            IEnumerable<GiaInOffsetGiaCongBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<GiaInOffsetGiaCongBDO>("dbo.spGiaInOffsetGiaCong_DocTatCa");
                return output;
            }
        }
        public IEnumerable<GiaInOffsetGiaCongBDO> DocTatCa_ConDung_CoTenNhaIn()
        {
            IEnumerable<GiaInOffsetGiaCongBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<GiaInOffsetGiaCongBDO>("dbo.spGiaInOffsetGiaCong_DocTatCa_ConDung_CoTenNhaIn");
                return output;
            }
        }
        public GiaInOffsetGiaCongBDO DocTheoId(int id)
        {
            GiaInOffsetGiaCongBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters();//dapper
               p.Add("@id", id);

             
                //Excecute
                //
                //return output = connection.QuerySingle<GiaInOffsetGiaCongBDO>("dbo.spGiaInOffsetGiaCong_DocTheoId", new { id = id });

                connection.Execute("dbo.spGiaInOffsetGiaCong_DocTheoId", p, commandType: CommandType.StoredProcedure);
                //output = connection.Query<GiaInOffsetGiaCongBDO>("dbo.spGiaInOffsetGiaCong_DocTheoId", new { id = id }).SingleOrDefault();
                output = connection.Query<GiaInOffsetGiaCongBDO>("select * from GiaInOffsetGiaCong where id = @id", new { id = id }).SingleOrDefault();
                return output;
            }
        }

        public void Sua(GiaInOffsetGiaCongBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@id", entityBDO.Id);
                p.Add("@TenGia", entityBDO.TenGia);
                p.Add("@DienGiai", entityBDO.DienGiai);
                p.Add("@IdNhaIn", entityBDO.IdNhaIn);
                p.Add("@IdMayIn", entityBDO.IdMayIn);
                p.Add("@DoiMayIn", entityBDO.DoiMayIn);
                p.Add("@DonGiaBai", entityBDO.DonGiaBai);
                p.Add("@SoToChayBuHaoCoBan", entityBDO.SoToChayBuHaoCoBan);
                p.Add("@SoLuongBaoIn", entityBDO.SoToChayBuHaoCoBan);
                p.Add("@DonGiaVuot", entityBDO.DonGiaVuot);
                p.Add("@DonViTinhSoLuong", entityBDO.DonViTinhSoLuong);
                p.Add("@GiaDaBaoKem", entityBDO.GiaDaBaoKem);
                p.Add("@ThongTinLienHe", entityBDO.ThongTinLienHe);
                p.Add("@GhiChu", entityBDO.GhiChu);
                p.Add("@KhongSuDung", entityBDO.KhongSuDung);
                p.Add("@ThuTuSapXep", entityBDO.ThuTuSapXep);

                //Excecute
                connection.Execute("dbo.spGiaInOffsetGiaCong_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void Them(GiaInOffsetGiaCongBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@TenGia", entityBDO.TenGia);
                p.Add("@DienGiai", entityBDO.DienGiai);
                p.Add("@IdNhaIn", entityBDO.IdNhaIn);
                p.Add("@IdMayIn", entityBDO.IdMayIn);
                p.Add("@DoiMayIn", entityBDO.DoiMayIn);
                p.Add("@DonGiaBai", entityBDO.DonGiaBai);
                p.Add("@SoToChayBuHaoCoBan", entityBDO.SoToChayBuHaoCoBan);
                p.Add("@SoLuongBaoIn", entityBDO.SoToChayBuHaoCoBan);
                p.Add("@DonGiaVuot", entityBDO.DonGiaVuot);
                p.Add("@DonViTinhSoLuong", entityBDO.DonViTinhSoLuong);
                p.Add("@GiaDaBaoKem", entityBDO.GiaDaBaoKem);
                p.Add("@ThongTinLienHe", entityBDO.ThongTinLienHe);
                p.Add("@GhiChu", entityBDO.GhiChu);
                p.Add("@KhongSuDung", entityBDO.KhongSuDung);
                p.Add("@ThuTuSapXep", entityBDO.ThuTuSapXep);

                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spGiaInOffsetGiaCong_Them", p, commandType: CommandType.StoredProcedure);
                //xử lý id out
                entityBDO.Id = p.Get<int>("@id");
                ///nếu cần có thể
                ///đặt return ở đay cũng được
            }
        }
        
        public void Xoa(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
                p.Add("@id", id);

                //Excecute
                connection.Execute("spGiaInOffsetGiaCong_XoaTheoId", p, commandType: CommandType.StoredProcedure);

            }


        }
    }
}
