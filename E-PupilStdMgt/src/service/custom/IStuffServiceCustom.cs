using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.payload;

namespace E_PupilStdMgt.src.service.custom
{
    interface IStuffServiceCustom: ISuperService
    {
        public List<StuffDTO> FindAllStuff();
        public bool CreateNewStuff(StuffDTO stuffDTO);
        public bool UpdateStuff(StuffDTO stuffDTO);
        public bool DeleteStuff(int stuffId);
        public StuffDTO FindStuffByUserName(string userName);
    }
}
