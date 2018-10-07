using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.DAL;

namespace TinhGiaInOffset.Logic
{
    public class HangLoiNhuanOffsetGiaCongLogic
    {
        HangLoiNhuanOffsetGiaCongDAO dataDAO = new HangLoiNhuanOffsetGiaCongDAO();
        public List<HangLoiNhuanOffsetGiaCongBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().ToList();
        }
    }
}
