using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.Logic;
using TinhGiaInOffset.Common;
using TinhGiaInOffset.WFUI.Model;
using AutoMapper;

namespace TinhGiaInOffset.WFUI.DTOContext
{
    public class MayInOffsetContext
    {
        MayInOffsetLogic logic = new MayInOffsetLogic();


        public List<MayInOffsetModel> DocTatCa()
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<MayInOffsetBDO, MayInOffsetModel>());
            var mapper = config.CreateMapper();
            List<MayInOffsetModel> nguon = mapper.Map<List<MayInOffsetBDO>, List<MayInOffsetModel>>(logic.DocTatCa());
            return nguon;
        }


        public MayInOffsetModel DocTheoId(int idMayInOffset)
        {
            var objBDO = logic.DocTheoId(idMayInOffset);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<MayInOffsetBDO, MayInOffsetModel>());
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<MayInOffsetModel>(objBDO);

            //Trả về
            return objModel;
        }

        public void Sua(MayInOffsetModel mayInModel)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<MayInOffsetModel, MayInOffsetBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<MayInOffsetBDO>(mayInModel);
            logic.Sua(objBDO);
        }

        public void Them(MayInOffsetModel baiSP)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<MayInOffsetModel, MayInOffsetBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<MayInOffsetBDO>(baiSP);
            //Chuyển
            //ChuyenObjectDTOThanhObjectBDO(baiSP, objBDO);
            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
        }

        public void Xoa(int idMayInOffset)
        {
            logic.Xoa(idMayInOffset);
        }
    }
}
