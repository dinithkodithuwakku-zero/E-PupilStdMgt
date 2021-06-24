using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.entity;

namespace E_PupilStdMgt.src.repository.custom
{
    interface IStudentRepoCustom : ICrudRepo<Student, int>
    {
        public int GenerateNextRegNo();
    }
}
