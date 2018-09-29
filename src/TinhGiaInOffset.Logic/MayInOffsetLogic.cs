using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.DAL;


namespace TinhGiaInOffset.Logic
{
    public class MayInOffsetLogic
    {
        MayInOffsetDAO dataDAO = new MayInOffsetDAO();
        public List<MayInOffsetBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public MayInOffsetBDO DocTheoId(int idMayInOffset)
        {
            return dataDAO.DocTheoId(idMayInOffset);
        }
        public void Them(MayInOffsetBDO mayInOffset)
        {
            dataDAO.Them(mayInOffset);
        }
        public void Sua(MayInOffsetBDO mayInOffset)
        {
            dataDAO.Sua(mayInOffset);
        }
        public void Xoa(int idMayInOffset)
        {
            dataDAO.Xoa(idMayInOffset);
        }

    }
}
