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
    public class PhiMayInKyThuatSoContext
    {
        PhiMayInKyThuatSoLogic logic = new PhiMayInKyThuatSoLogic();


        public List<PhiMayInKyThuatSoModel> DocTatCa()
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PhiMayInKyThuatSoBDO, PhiMayInKyThuatSoModel>());
            var mapper = config.CreateMapper();
            List<PhiMayInKyThuatSoModel> nguon = mapper.Map<List<PhiMayInKyThuatSoBDO>, List<PhiMayInKyThuatSoModel>>(logic.DocTatCa());
            return nguon;
        }


        public PhiMayInKyThuatSoModel DocTheoId(int idPhiMayInKyThuatSo)
        {
            var objBDO = logic.DocTheoId(idPhiMayInKyThuatSo);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<PhiMayInKyThuatSoBDO, PhiMayInKyThuatSoModel>());
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<PhiMayInKyThuatSoModel>(objBDO);

            //Trả về
            return objModel;
        }

       
    }
}
