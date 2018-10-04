using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.Common.Enum;
using TinhGiaInOffset.Logic;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.WFUI.DTOContext;
using TinhGiaInOffset.WFUI.Model;

namespace TinhGiaInOffset.WFUI.Presentation
{
    public class QuanLyGiaInOffsetGiaCongPresenter
    {
        private GiaInOffsetGiaCongContext giaInOffsetGiaCongCont = new GiaInOffsetGiaCongContext();
        private NhaInOffsetContext nhaInOffsetCont = new NhaInOffsetContext();
        private MayInOffsetContext mayInOffsetCont = new MayInOffsetContext();
        
        public List<NhaInOffsetModel> NhaInOffsetS()
        {
            return nhaInOffsetCont.DocTatCa();
        }
        public List<GiaInOffsetGiaCongModel> GiaInOffsetS()
        {
            return giaInOffsetGiaCongCont.DocTatCa();
        }
        public List<MayInOffsetModel> MayInOffsetS()
        {
            return mayInOffsetCont.DocTatCa();
        }
        public List<GiaInOffsetGiaCongModel>GiaInOffsetSTheoNhaIn(int idNhaIn)
        {
            return giaInOffsetGiaCongCont.DocTheoIdNhaInOffset(idNhaIn);
        }
    }
}
