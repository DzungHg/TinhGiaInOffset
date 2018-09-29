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
    public class NhaInOffsetContext
    {
        NhaInOffsetLogic logic = new NhaInOffsetLogic();


        public List<NhaInOffsetModel> DocTatCa()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaInOffsetBDO, NhaInOffsetModel>());
            var mapper = config.CreateMapper();
            List<NhaInOffsetModel> nguon = mapper.Map<List<NhaInOffsetBDO>, List<NhaInOffsetModel>>(logic.DocTatCa());
            return nguon;
        }


        public NhaInOffsetModel DocTheoId(int idNhaInOffset)
        {
            var objBDO = logic.DocTheoId(idNhaInOffset);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaInOffsetBDO, NhaInOffsetModel>());
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<NhaInOffsetModel>(objBDO);

            //Trả về
            return objModel;
        }

        public void Sua(NhaInOffsetModel nhaInModel)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaInOffsetModel, NhaInOffsetBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<NhaInOffsetBDO>(nhaInModel);
            logic.Sua(objBDO);
        }

        public void Them(NhaInOffsetModel baiSP)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NhaInOffsetModel, NhaInOffsetBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<NhaInOffsetBDO>(baiSP);
            //Chuyển
            //ChuyenObjectDTOThanhObjectBDO(baiSP, objBDO);
            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
        }

        public void Xoa(int idNhaInOffset)
        {
            logic.Xoa(idNhaInOffset);
        }
    }
}
