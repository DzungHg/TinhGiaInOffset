using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.Common.Enum;

namespace TinhGiaInOffset.WFUI.Model
{
    public class QuyCachInOffset
    {
        public int IdGiaInOffsetGiaCong { get; set; }
        public KieuInOffset KieuIn { get; set; }
        public int SoKemIn
        {
            get
            {
                int kq = 1;
                switch (this.KieuIn)
                {
                    case KieuInOffset.InAB:
                        kq = 2;                        
                        break;
                    case KieuInOffset.InMotMat:
                        kq = 1;
                        
                        break;
                    case KieuInOffset.InTuTroNhip:
                    case KieuInOffset.InTuTroTayKe:
                        kq = 1;
                        
                        break;
                }
                return kq;
            }
        }
        public int SoMatIn
        {
            get
            {
                int kq = 1;
                switch (this.KieuIn)
                {
                    case KieuInOffset.InAB:
                        
                        kq  = 2;
                        
                        break;
                    case KieuInOffset.InMotMat:
                        kq = 1;
                        break;
                    case KieuInOffset.InTuTroNhip:
                    case KieuInOffset.InTuTroTayKe:
                        kq = 2;
                        break;
                }
                return kq;
            }
        }
        public int SoLuotIn
        {
            get
            {
                int kq = 1;
                switch (this.KieuIn)
                {
                    case KieuInOffset.InAB:
                        kq = 2;

                        break;
                    case KieuInOffset.InMotMat:
                        kq = 1;
                        break;
                    case KieuInOffset.InTuTroNhip:
                    case KieuInOffset.InTuTroTayKe:
                        kq = 2;
                        break;
                }
                return kq;
            }
        }
        public QuyCachInOffset(int idBangGiaInOffset, KieuInOffset kieuIn)
        {
            this.IdGiaInOffsetGiaCong = idBangGiaInOffset;
            this.KieuIn = kieuIn;
        }
    }
}
