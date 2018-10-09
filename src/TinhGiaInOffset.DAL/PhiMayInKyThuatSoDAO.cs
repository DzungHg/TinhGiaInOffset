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
    public class PhiMayInKyThuatSoDAO : IPhiMayInKyThuatSo
    {
        const string tenDB = "QuanLyGiaIn";

        public IEnumerable<PhiMayInKyThuatSoBDO> DocTatCa()
        {
            IEnumerable<PhiMayInKyThuatSoBDO> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<PhiMayInKyThuatSoBDO>("dbo.spPhiMayInKyThuatSo_DocTatCa");
                return output;
            }

        }

        public PhiMayInKyThuatSoBDO DocTheoId(int id)
        {
            PhiMayInKyThuatSoBDO output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                //output = connection.Query<PhiMayInKyThuatSoBDO>("dbo.spPhiMayInKyThuatSo_DocTheoId", id).SingleOrDefault();
                output = connection.Query<PhiMayInKyThuatSoBDO>("select * from PhiMayInKyThuatSo where @id = id", new { id = id }).SingleOrDefault();
                return output;

            }
        }

        public void Sua(PhiMayInKyThuatSoBDO entityBDO)
        {
            throw new NotImplementedException();
        }

        public void Them(PhiMayInKyThuatSoBDO entityBDO)
        {
            throw new NotImplementedException();
        }

        public void Xoa(int id)
        {
            throw new NotImplementedException();
        }
    }
}
