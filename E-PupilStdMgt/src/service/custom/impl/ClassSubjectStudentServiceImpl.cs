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
        private IClassServiceCustom iClassServiceCustom;

        public ClassSubjectStudentServiceImpl()
        {
            iClassSubjectStudentMarkRepo = RepoFactory.GetInstance().GetRepo<ClassSubjectStudentMarkRepoImpl>(RepoFactory.RepoTypes.CLASS_SUBJECT_STUDENT_MARK);
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);
        }

        public bool CreateStudentMark(ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO)
        {

            ClassSubjectDTO classSubjectDTO = iClassServiceCustom.FindClassSubjectByClassCodeAndSubjectCode(classSubjectStudentMarkDTO.ClassSubjectDTO.ClassDTO.ClassCode, classSubjectStudentMarkDTO.ClassSubjectDTO.SubjectDTO.SubjectCode);

            return iClassSubjectStudentMarkRepo.Save(new ClassSubjectStudentMark(classSubjectStudentMarkDTO.ExamDate,
                classSubjectStudentMarkDTO.StudentPoint, new ClassSubject(classSubjectDTO.ClassSubjectId), new Student(classSubjectStudentMarkDTO.StudentDTO.StudentId)));
        }
    }
}
