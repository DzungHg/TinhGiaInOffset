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
    public class GiaInOffsetGiaCongContext
    {
        GiaInOffsetGiaCongLogic logic = new GiaInOffsetGiaCongLogic();


        public List<GiaInOffsetGiaCongModel> DocTatCa()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<GiaInOffsetGiaCongBDO, GiaInOffsetGiaCongModel>());
            var mapper = config.CreateMapper();
            List<GiaInOffsetGiaCongModel> nguon = mapper.Map<List<GiaInOffsetGiaCongBDO>, List<GiaInOffsetGiaCongModel>>(logic.DocTatCa());
            return nguon;
        }
        public List<GiaInOffsetGiaCongModel> DocGiaConSuDung()
        {
            return this.DocTatCa().Where(x => x.KhongSuDung == false).ToList();
        }
        public List<GiaInOffsetGiaCongModel> DocTheoIdNhaInOffset(int idNhaIn)
        {
            var nguon = this.DocTatCa().Where(x => x.IdNhaIn == idNhaIn).ToList();
            return nguon;
        }

        public GiaInOffsetGiaCongModel DocTheoId(int idGiaInOffsetGiaCong)
        {
            var objBDO = logic.DocTheoId(idGiaInOffsetGiaCong);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<GiaInOffsetGiaCongBDO, GiaInOffsetGiaCongModel>());
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<GiaInOffsetGiaCongModel>(objBDO);

            //Thêm chi tiết Máy in tại đây

            var chiTietGiaInGiaCongOffset = "";
            if (objModel.IdMayIn > 0)
           {
                
               //Lay chi tiết máy in
               var modelMayIn = new MayInOffsetContext().DocTheoId(objModel.IdMayIn);

               var line01 = modelMayIn.ChiTietMayIn + '\r' + '\n';
               var line02 = objModel.DoiMayIn + '\r' + '\n';
               var line03 = string.Format("{0:0,0.00} đ/bài" + '\r' + '\n', objModel.DonGiaBai);

               chiTietGiaInGiaCongOffset = line01 + line02 + line03;
           }
            objModel.ChiTietGiaInOffsetGiaCong = chiTietGiaInGiaCongOffset;

            //Trả về
            return objModel;
        }

        public void Sua(GiaInOffsetGiaCongModel giaInModel)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<GiaInOffsetGiaCongModel, GiaInOffsetGiaCongBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<GiaInOffsetGiaCongBDO>(giaInModel);
            logic.Sua(objBDO);
        }

        public void Them(GiaInOffsetGiaCongModel giaInModel)
        {

            var config = new MapperConfiguration(cfg => cfg.CreateMap<GiaInOffsetGiaCongModel, GiaInOffsetGiaCongBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<GiaInOffsetGiaCongBDO>(giaInModel);
            //Chuyển
            //ChuyenObjectDTOThanhObjectBDO(baiSP, objBDO);
            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
        }

        public void Xoa(int idGiaInOffsetGiaCong)
        {
            logic.Xoa(idGiaInOffsetGiaCong);
        }


    }
}
