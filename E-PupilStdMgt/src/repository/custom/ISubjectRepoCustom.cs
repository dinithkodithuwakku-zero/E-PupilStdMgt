using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.entity;

namespace E_PupilStdMgt.src.repository.custom
{
    interface ISubjectRepoCustom : ICrudRepo<Subject, int>
    {
        public Subject FindSubjectByCode(string code);
        public Subject FindSubjectById(int id);
    }
}
