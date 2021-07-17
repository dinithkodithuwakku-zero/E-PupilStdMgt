using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.payload;

namespace E_PupilStdMgt.src.service.custom
{
    interface IClassSubjectStudentMarkServiceCustom: ISuperService
    {
        public bool CreateStudentMark(ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO);
        public bool UpdateStudentMark(ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO);
        public bool DeleteStudentMark(int classSubjectStudentMarkId);
        public List<ClassSubjectStudentMarkDTO> FindClassSubjectStudentMarks();
        public List<ClassSubjectStudentMarkDTO> FindClassSubjectStudentMarks(string classCode, string subjectCode);
        public ArrayList CalculateStudentsGPA();
    }
}
