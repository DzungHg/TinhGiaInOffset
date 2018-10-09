using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;

namespace TinhGiaInOffset.DAL.IRespos
{
    interface IPhiMayInKyThuatSo
    {
        IEnumerable<PhiMayInKyThuatSoBDO> DocTatCa();
        PhiMayInKyThuatSoBDO DocTheoId(int id);
        void Them(PhiMayInKyThuatSoBDO entityBDO);
        void Sua(PhiMayInKyThuatSoBDO entityBDO);
        void Xoa(int id);

    }
}
