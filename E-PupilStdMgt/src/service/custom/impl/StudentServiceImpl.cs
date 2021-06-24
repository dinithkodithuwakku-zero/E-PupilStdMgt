using E_PupilStdMgt.src.payload;
using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.entity;
using E_PupilStdMgt.src.repository;
using E_PupilStdMgt.src.repository.custom;
using E_PupilStdMgt.src.repository.custom.impl;
using System.Collections;

namespace E_PupilStdMgt.src.service.custom.impl
{
    class StudentServiceImpl : IStudentServiceCustom
    {
        private IStudentRepoCustom iStudentRepoCustom;

        public StudentServiceImpl()
        {
            iStudentRepoCustom = RepoFactory.GetInstance().GetRepo<StudentRepoImpl>(RepoFactory.RepoTypes.STUDENT);
        }
        public bool CreateNewStudent(StudentDTO studentDTO)
        {
            return iStudentRepoCustom.Save(new Student(studentDTO.StudentRegNo, studentDTO.StudentName, studentDTO.MobileNo, studentDTO.Gender, studentDTO.Email, studentDTO.PermanentAddress));
        }

        public List<StudentDTO> FindAllStudents()
        {
            ArrayList studentList = iStudentRepoCustom.GetAll();
            List<StudentDTO> list = new List<StudentDTO>();

            foreach (Student s in studentList)
            {
                list.Add(new StudentDTO(s.StudentId, s.StudentRegNo, s.StudentName, s.MobileNo, s.Gender, s.Email, s.PermanentAddress));
            }

            return list;
        }

        public int GenerateNextRegNo()
        {
            return iStudentRepoCustom.GenerateNextRegNo() + 1;
        }
    }
}
