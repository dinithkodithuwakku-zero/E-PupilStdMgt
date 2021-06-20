using E_PupilStdMgt.src.payload;
using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.repository;
using E_PupilStdMgt.src.repository.custom;
using E_PupilStdMgt.src.repository.custom.impl;

namespace E_PupilStdMgt.src.service.custom.impl
{
    class SchoolServiceImpl : ISchoolServiceCustom
    {
        private ISchoolRepoCustom iSchoolRepoCustom;

        public SchoolServiceImpl()
        {
            iSchoolRepoCustom = RepoFactory.GetInstance().GetRepo<SchoolRepoImpl>(RepoFactory.RepoTypes.SCHOOL);
        }
        public bool UpdateSchool(SchoolDTO schoolDTO)
        {
            throw new NotImplementedException();
        }
    }
}
