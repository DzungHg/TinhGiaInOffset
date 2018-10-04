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
    
    public class TaoMayInOffsetPresenter
    {
        IViewTaoMayInOffset View;
        private MayInOffsetContext mayInOffsetCont = new MayInOffsetContext();
        public TaoMayInOffsetPresenter(IViewTaoMayInOffset view)
        {
            this.View = view;
        }
        public void Sua(MayInOffsetModel mayIn)
        {
            mayInOffsetCont.Sua(mayIn);
        }
        public void Them(MayInOffsetModel mayIn)
        {
            mayInOffsetCont.Them(mayIn);
        }
    }
}
