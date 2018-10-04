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
    public class MayInOffsetDAO : IMayInOffset
    {
        const string tenDB = "QuanLyGiaIn";

        public IEnumerable<MayInOffsetBDO> DocTatCa()
        {
            IEnumerable<MayInOffsetBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<MayInOffsetBDO>("dbo.spMayInOffset_DocTatCa");
                return output;
            }

        }

        public MayInOffsetBDO DocTheoId(int id)
        {
            MayInOffsetBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                //output = connection.Query<MayInOffsetBDO>("dbo.spMayInOffset_DocTheoId", id).SingleOrDefault();
                output = connection.Query<MayInOffsetBDO>("select * from MayInOffset where @id = id", new { id = id }).SingleOrDefault();
                return output;

            }
        }

        public void Sua(MayInOffsetBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@id", entityBDO.Id);
                p.Add("@TenMayIn", entityBDO.TenMayIn);
                p.Add("@MoTa", entityBDO.MoTa);
                p.Add("@KhoGiayToiDaRong", entityBDO.KhoGiayToiDaRong);
                p.Add("@KhoGiayToiDaDai", entityBDO.KhoGiayToiDaDai);
                p.Add("@KhoGiayToiThieuRong", entityBDO.KhoGiayToiThieuRong);
                p.Add("@KhoGiayToiThieuDai", entityBDO.KhoGiayToiThieuDai);
                p.Add("@KhoInToiDaRong", entityBDO.KhoInToiDaRong);
                p.Add("@KhoInToiDaDai", entityBDO.KhoInToiDaDai);
                p.Add("@KhoInToiThieuRong", entityBDO.KhoInToiThieuRong);
                p.Add("@KhoInToiThieuDai", entityBDO.KhoInToiThieuDai);
                p.Add("@ThongTinTocDo", entityBDO.ThongTinTocDo);
                p.Add("@TocDoToGio", entityBDO.TocDoToGio);
                p.Add("@GiayCoTheIn", entityBDO.GiayCoTheIn);
                p.Add("@SoMauIn", entityBDO.SoMauIn);
                p.Add("@DonViDemClick", entityBDO.DonViDemClick);
                p.Add("@HangSanXuat", entityBDO.HangSanXuat);
                p.Add("@LeBatNhip", entityBDO.LeBatNhip);
                p.Add("@LeTuTro", entityBDO.LeTuTro);

                //Excecute
                connection.Execute("dbo.spMayInOffset_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }

        }

        public void Them(MayInOffsetBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@TenMayIn", entityBDO.TenMayIn);
                p.Add("@MoTa", entityBDO.MoTa);
                p.Add("@KhoGiayToiDaRong", entityBDO.KhoGiayToiDaRong);
                p.Add("@KhoGiayToiDaDai", entityBDO.KhoGiayToiDaDai);
                p.Add("@KhoGiayToiThieuRong", entityBDO.KhoGiayToiThieuRong);
                p.Add("@KhoGiayToiThieuDai", entityBDO.KhoGiayToiThieuDai);
                p.Add("@KhoInToiDaRong", entityBDO.KhoInToiDaRong);
                p.Add("@KhoInToiDaDai", entityBDO.KhoInToiDaDai);
                p.Add("@KhoInToiThieuRong", entityBDO.KhoInToiThieuRong);
                p.Add("@KhoInToiThieuDai", entityBDO.KhoInToiThieuDai);
                p.Add("@ThongTinTocDo", entityBDO.ThongTinTocDo);
                p.Add("@TocDoToGio", entityBDO.TocDoToGio);
                p.Add("@GiayCoTheIn", entityBDO.GiayCoTheIn);
                p.Add("@SoMauIn", entityBDO.SoMauIn);
                p.Add("@DonViDemClick", entityBDO.DonViDemClick);
                p.Add("@HangSanXuat", entityBDO.HangSanXuat);
                p.Add("@LeBatNhip", entityBDO.LeBatNhip);
                p.Add("@LeTuTro", entityBDO.LeTuTro);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spMayInOffset_Them", p, commandType: CommandType.StoredProcedure);
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
