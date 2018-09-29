using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;

namespace TinhGiaInOffset.DAL.IRespos
{
    interface IGiaInOffsetGiaCong
    {
        IEnumerable<GiaInOffsetGiaCongBDO> DocTatCa();
        GiaInOffsetGiaCongBDO DocTheoId(int id);
        void Them(GiaInOffsetGiaCongBDO entityBDO);
        void Sua(GiaInOffsetGiaCongBDO entityBDO);
        void Xoa(int id);

    }
}
