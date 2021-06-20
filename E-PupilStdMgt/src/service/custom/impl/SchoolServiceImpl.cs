using E_PupilStdMgt.src.payload;
using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.entity;
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

        public SchoolDTO GetSchoolDetails()
        {
            School school = iSchoolRepoCustom.GetOne();
            return new SchoolDTO(school.SchoolId, school.SchoolName, school.SchoolDescription, school.SchoolContactNo, school.SchoolAddress, school.SchoolBadgeImagePath);
        }

        public bool UpdateSchool(SchoolDTO schoolDTO)
        {
            return iSchoolRepoCustom.Update(new School(schoolDTO.SchoolId, schoolDTO.SchoolName, schoolDTO.SchoolDescription, schoolDTO.SchoolContactNo, schoolDTO.SchoolAddress, schoolDTO.SchoolBadgeImagePath));
        }
    }
}
