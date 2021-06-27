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
        public int GenerateNextRegNo();
        public List<StudentDTO> FindStudents(StudentDTO studentDTO);
        public StudentDTO FindStudentByRegNo(string regNo);
        public StudentDTO FindStudentById(int id);
    }
}
