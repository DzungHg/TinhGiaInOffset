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
    public class HangLoiNhuanOffsetGiaCongContext
    {
        HangLoiNhuanOffsetGiaCongLogic logic = new HangLoiNhuanOffsetGiaCongLogic();


        public List<HangLoiNhuanOffsetGiaCongModel> DocTatCa()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<HangLoiNhuanOffsetGiaCongBDO, HangLoiNhuanOffsetGiaCongModel>());
            var mapper = config.CreateMapper();
            List<HangLoiNhuanOffsetGiaCongModel> output = mapper.Map<List<HangLoiNhuanOffsetGiaCongBDO>, List<HangLoiNhuanOffsetGiaCongModel>>(logic.DocTatCa());
            return output;
        }
        public HangLoiNhuanOffsetGiaCongModel LayTheoMa(string ma)
        {
            var output = this.DocTatCa().Where(x => x.Ma.Trim() == ma).SingleOrDefault();
            return output;
        }

    }
}
