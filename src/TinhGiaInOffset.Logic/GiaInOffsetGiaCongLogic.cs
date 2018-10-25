using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.DAL;

namespace TinhGiaInOffset.Logic
{
    public class GiaInOffsetGiaCongLogic
    {
        GiaInOffsetGiaCongDAO dataDAO = new GiaInOffsetGiaCongDAO();
        public List<GiaInOffsetGiaCongBDO> DocTatCa()
        {
            return dataDAO.DocTatCa().OrderBy(x => x.ThuTuSapXep).ToList();
        }
        public List<GiaInOffsetGiaCongBDO> DocTatCa_ConDung_CoTenNhaIn()
        {
            return dataDAO.DocTatCa_ConDung_CoTenNhaIn().ToList();
        }
        public GiaInOffsetGiaCongBDO DocTheoId(int idGiaInOffsetGiaCong)
        {
            return dataDAO.DocTheoId(idGiaInOffsetGiaCong);
        }
        public void Them(GiaInOffsetGiaCongBDO giaInOffsetGiaCong)
        {
            dataDAO.Them(giaInOffsetGiaCong);
        }
        public void Sua(GiaInOffsetGiaCongBDO giaInOffsetGiaCong)
        {
            dataDAO.Sua(giaInOffsetGiaCong);
        }
        public void Xoa(int idGiaInOffsetGiaCong)
        {
            dataDAO.Xoa(idGiaInOffsetGiaCong);
        }
    }
}
