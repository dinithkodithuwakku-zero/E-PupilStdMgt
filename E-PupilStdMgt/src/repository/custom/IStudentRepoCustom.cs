﻿using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.entity;
using System.Collections;

namespace E_PupilStdMgt.src.repository.custom
{
    interface IStudentRepoCustom : ICrudRepo<Student, int>
    {
        public int GenerateNextRegNo();
        public ArrayList FindStudents(Student student);
        public Student FindStudentByRegNo(string regNo); 
        public Student FindStudentById(int id);

        public ArrayList FindAllStudentsByClassCode(string classCode);
    }
}
