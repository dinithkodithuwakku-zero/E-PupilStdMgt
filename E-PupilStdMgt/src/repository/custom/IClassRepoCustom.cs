using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.entity;
using System.Collections;

namespace E_PupilStdMgt.src.repository.custom
{
    interface IClassRepoCustom : ICrudRepo<Class, int>
    {
        public bool AddSubjectMapping(ClassSubject classSubject);
        public bool AddStudentMapping(ClassStudent classStudent);

        public Class FindClassByCode(string code);
    }
}
