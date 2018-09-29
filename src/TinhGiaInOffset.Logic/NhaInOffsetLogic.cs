
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.DAL;

namespace TinhGiaInOffset.Logic
{
    public class NhaInOffsetLogic
    {
        NhaInOffsetDAO dataDAO = new NhaInOffsetDAO();
        public List<NhaInOffsetBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public NhaInOffsetBDO DocTheoId(int idNhaInOffset)
        {
            return dataDAO.DocTheoId(idNhaInOffset);
        }
        public void Them(NhaInOffsetBDO nhaInOffset)
        {
            dataDAO.Them(nhaInOffset);
        }
        public void Sua(NhaInOffsetBDO nhaInOffset)
        {
            dataDAO.Sua(nhaInOffset);
        }
        public void Xoa(int idNhaInOffset)
        {
            dataDAO.Xoa(idNhaInOffset);
        }
    }
}
