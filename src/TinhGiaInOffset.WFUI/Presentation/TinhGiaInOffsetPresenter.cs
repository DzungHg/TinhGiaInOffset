using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.Common.Enum;
using TinhGiaInOffset.Logic;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.WFUI.DTOContext;
using TinhGiaInOffset.WFUI.Model;

namespace TinhGiaInOffset.WFUI.Presentation
{
   
    public class TinhGiaInOffsetPresenter
    {
        IViewTinhGiaInOffset View;
        public List<BaiInOffsetGiaCongModel> BaiInOffsetGiaCongBaoGom = new List<BaiInOffsetGiaCongModel>();
        public List<GiaBanThanhPhamTaiChoModel> GiaBanThanhPhamTaiChoBaoGom = new List<GiaBanThanhPhamTaiChoModel>();
        public List<GiaBanThanhPhamGiaCongModel> GiaBanThanhPhamGiaCongBaoGom = new List<GiaBanThanhPhamGiaCongModel>();
        public List<ChiPhiOffsetKhacModel> ChiPhiKhacBaoGom = new List<ChiPhiOffsetKhacModel>();
        public TinhGiaInOffsetPresenter(IViewTinhGiaInOffset view)
        {
            View = view;
        }
       
    }
}
