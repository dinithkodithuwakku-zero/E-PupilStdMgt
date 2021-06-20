using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.payload;

namespace E_PupilStdMgt.src.service.custom
{
    interface ISchoolServiceCustom: ISuperService
    {
        public SchoolDTO GetSchoolDetails();
        public Boolean UpdateSchool(SchoolDTO schoolDTO);
    }
}
