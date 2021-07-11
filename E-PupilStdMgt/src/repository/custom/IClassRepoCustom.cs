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
        public bool DeleteSubjectMapping(ClassSubject classSubject);
        public bool AddStudentMapping(ClassStudent classStudent);
        public bool DeleteStudentMapping(ClassStudent classStudent);
        public Class FindClassByCode(string code);
        public ArrayList GetSubjectMapping();
        public ArrayList GetStudentMapping();
        public ArrayList FindSubjectMappingByStudentAndClass(int classId, int studentId);
        public ClassSubject FindClassSubjectByClassCodeAndSubjectCode(string classCode, string subjectCode);
        public ClassStudent FindClassStudentByClassCodeAndStudentRegNo(string classCode, string studentRegNo);
    }
}
