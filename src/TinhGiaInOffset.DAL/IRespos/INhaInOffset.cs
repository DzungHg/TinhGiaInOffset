using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;

namespace TinhGiaInOffset.DAL.IRespos
{
    public interface INhaInOffset
    {

        IEnumerable<NhaInOffsetBDO> DocTatCa();
        NhaInOffsetBDO DocTheoId(int id);
        void Them(NhaInOffsetBDO entityBDO);
        void Sua(NhaInOffsetBDO entityBDO);
        void Xoa(int id);
    }
}
