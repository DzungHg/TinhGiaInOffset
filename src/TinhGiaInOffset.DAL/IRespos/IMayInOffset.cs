using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;

namespace TinhGiaInOffset.DAL.IRespos
{
    public interface IMayInOffset
    {

        IEnumerable<MayInOffsetBDO> DocTatCa();
        MayInOffsetBDO DocTheoId(int id);
        void Them(MayInOffsetBDO entityBDO);
        void Sua(MayInOffsetBDO entityBDO);
        void Xoa(int id);

    }
}
