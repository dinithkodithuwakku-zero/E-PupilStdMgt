using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.payload;

namespace E_PupilStdMgt.src.service.custom
{
    interface IStudentServiceCustom: ISuperService
    {
        public List<StudentDTO> FindAllStudents();
        public bool CreateNewStudent(StudentDTO studentDTO);
        public bool UpdateStudent(StudentDTO studentDTO);
        public bool DeleteStudent(int studentId);
        public int GenerateNextRegNo();
        public List<StudentDTO> FindStudents(StudentDTO studentDTO);
        public StudentDTO FindStudentByRegNo(string regNo);
        public StudentDTO FindStudentById(int id);
        public List<StudentDTO> FindAllStudentsByClassCode(string classCode);
    }
}
