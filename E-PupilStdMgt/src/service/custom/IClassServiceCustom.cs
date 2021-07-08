using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.payload;

namespace E_PupilStdMgt.src.service.custom
{
    interface IClassServiceCustom: ISuperService
    {
        public List<ClassDTO> FindAllClasses();
        public bool CreateClass(ClassDTO classDTO);
        public bool AddSubjectMapping(ClassSubjectDTO classSubjectDTO);
        public bool AddStudentMapping(ClassStudentDTO classStudentDTO);
        public List<ClassSubjectDTO> FindSubjectMapping();
        public List<ClassStudentDTO> FindStudentMapping();
        public ClassDTO FindClassByCode(string classCode);
        public List<SubjectDTO> FindAllSubjectsByClassCodeAndStudentId(string classCode, int studentId);
        public List<ClassSubjectDTO> FindSubjectMappingByStudentAndClass(string classCode, int studentId);
        public ClassSubjectDTO FindClassSubjectByClassCodeAndSubjectCode(string classCode, string subjectCode);
        public ClassDTO FindClassById(int id);
    }
}
