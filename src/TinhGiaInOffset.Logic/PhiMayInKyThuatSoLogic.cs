using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.DAL;


namespace TinhGiaInOffset.Logic
{
    public class PhiMayInKyThuatSoLogic
    {
        PhiMayInKyThuatSoDAO dataDAO = new PhiMayInKyThuatSoDAO();
        public List<PhiMayInKyThuatSoBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
        public PhiMayInKyThuatSoBDO DocTheoId(int idPhiMayInKyThuatSo)
        {
            return dataDAO.DocTheoId(idPhiMayInKyThuatSo);
        }
        

    }
}
