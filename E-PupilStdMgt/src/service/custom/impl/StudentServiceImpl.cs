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

        public List<StudentDTO> FindStudents(StudentDTO studentDTO)
        {
            Student student = new Student();
            student.StudentRegNo = studentDTO.StudentRegNo;
            student.Status = studentDTO.Status;

            ArrayList studentList = iStudentRepoCustom.FindStudents(student);
            List<StudentDTO> list = new List<StudentDTO>();

            foreach (Student s in studentList)
            {
                list.Add(new StudentDTO(s.StudentId, s.StudentRegNo, s.StudentName, s.MobileNo, s.Gender, s.Email, s.PermanentAddress));
            }

            return list;
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

        public StudentDTO FindStudentByRegNo(string regNo)
        {
            Student student = iStudentRepoCustom.FindStudentByRegNo(regNo);
            return new StudentDTO(student.StudentId, student.StudentRegNo, student.StudentName, student.MobileNo, student.Gender, student.Email, student.PermanentAddress);
        }

        public StudentDTO FindStudentById(int id)
        {
            Student student = iStudentRepoCustom.FindStudentById(id);
            return new StudentDTO(student.StudentId, student.StudentRegNo, student.StudentName, student.MobileNo, student.Gender, student.Email, student.PermanentAddress);
        }

        public bool UpdateStudent(StudentDTO studentDTO)
        {
            return iStudentRepoCustom.Update(new Student(studentDTO.StudentId, studentDTO.StudentRegNo, studentDTO.StudentName, studentDTO.MobileNo, studentDTO.Gender, studentDTO.Email, studentDTO.PermanentAddress));
        }

        public bool DeleteStudent(int studentId)
        {
            return iStudentRepoCustom.Delete(studentId);
        }

        public List<StudentDTO> FindAllStudentsByClassCode(string classCode)
        {
            ArrayList studentList = iStudentRepoCustom.FindAllStudentsByClassCode(classCode);
            List<StudentDTO> list = new List<StudentDTO>();

            foreach (Student s in studentList)
            {
                list.Add(new StudentDTO(s.StudentId, s.StudentRegNo, s.StudentName, s.MobileNo, s.Gender, s.Email, s.PermanentAddress));
            }

            return list;
        }

        public int CountNumberOfStudents()
        {
            ArrayList studentList = iStudentRepoCustom.GetAll();
            return studentList.Count;
        }
    }
}
