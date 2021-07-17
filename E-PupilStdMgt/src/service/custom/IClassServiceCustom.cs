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
        public bool UpdateClass(ClassDTO classDTO);
        public bool DeleteClass(int classId);
        public int AddSubjectMapping(ClassSubjectDTO classSubjectDTO);
        public bool DeleteSubjectMapping(ClassSubjectDTO classSubjectDTO);
        public int AddStudentMapping(ClassStudentDTO classStudentDTO);
        public bool DeleteStudentMapping(ClassStudentDTO classStudentDTO);
        public List<ClassSubjectDTO> FindSubjectMapping();
        public List<ClassSubjectDTO> FindSubjectMapping(string classCode);
        public List<ClassStudentDTO> FindStudentMapping();
        public List<ClassStudentDTO> FindStudentMapping(string classCode);
        public ClassDTO FindClassByCode(string classCode);
        public List<SubjectDTO> FindAllSubjectsByClassCodeAndStudentId(string classCode, int studentId);
        public List<ClassSubjectDTO> FindSubjectMappingByStudentAndClass(string classCode, int studentId);
        public ClassSubjectDTO FindClassSubjectByClassCodeAndSubjectCode(string classCode, string subjectCode);
        public ClassDTO FindClassById(int id);
        public int CountNumberOfClasses();
    }
}
