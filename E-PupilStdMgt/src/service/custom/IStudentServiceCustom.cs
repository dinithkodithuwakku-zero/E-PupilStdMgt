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
    }
}
