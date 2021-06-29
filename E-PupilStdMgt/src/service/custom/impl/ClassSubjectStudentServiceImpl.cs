using E_PupilStdMgt.src.payload;
using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.entity;
using E_PupilStdMgt.src.repository;
using E_PupilStdMgt.src.repository.custom;
using E_PupilStdMgt.src.repository.custom.impl;

namespace E_PupilStdMgt.src.service.custom.impl
{
    class ClassSubjectStudentServiceImpl : IClassSubjectStudentMarkServiceCustom
    {
        private IClassSubjectStudentMarkRepoCustom iClassSubjectStudentMarkRepo;

        public ClassSubjectStudentServiceImpl()
        {
            iClassSubjectStudentMarkRepo = RepoFactory.GetInstance().GetRepo<ClassSubjectStudentMarkRepoImpl>(RepoFactory.RepoTypes.CLASS_SUBJECT_STUDENT_MARK);
        }

        public bool CreateStudentMark(ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO)
        {
            return iClassSubjectStudentMarkRepo.Save(new ClassSubjectStudentMark(classSubjectStudentMarkDTO.ExamDate,
                classSubjectStudentMarkDTO.StudentPoint, new ClassSubject(classSubjectStudentMarkDTO.ClassSubjectDTO.ClassSubjectId), new Student(classSubjectStudentMarkDTO.StudentDTO.StudentId));
        }
    }
}
