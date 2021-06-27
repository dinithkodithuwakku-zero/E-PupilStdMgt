﻿using E_PupilStdMgt.src.payload;
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
    class ClassServiceImpl : IClassServiceCustom
    {
        private IClassRepoCustom iClassRepoCustom;
        private ISubjectServiceCustom iSubjectServiceCustom;

        public ClassServiceImpl()
        {
            iClassRepoCustom = RepoFactory.GetInstance().GetRepo<ClassRepoImpl>(RepoFactory.RepoTypes.CLASS);
            iSubjectServiceCustom = ServiceFactory.GetInstance().GetService<SubjectServiceImpl>(ServiceFactory.ServiceTypes.SUBJECT);
        }

        public bool AddSubjectMapping(ClassSubjectDTO classSubjectDTO)
        {
            ClassSubject classSubject = new ClassSubject();
            classSubject.ClassEntity = iClassRepoCustom.FindClassByCode(classSubjectDTO.ClassDTO.ClassCode);
            SubjectDTO subjectDTO = iSubjectServiceCustom.FindSubjectByCode(classSubjectDTO.SubjectDTO.SubjectCode);
            classSubject.SubjectEntity = new Subject(subjectDTO.SubjectId, subjectDTO.SubjectName, subjectDTO.SubjectCode, subjectDTO.SubjectDuration, subjectDTO.SubjectTotalPoints); ;

            return iClassRepoCustom.AddSubjectMapping(classSubject);
        }

        public bool CreateClass(ClassDTO classDTO)
        {
            Class classEntity = new Class();
            classEntity.ClassName = classDTO.ClassName;
            classEntity.ClassCode = classDTO.ClassCode;
            classEntity.IsActive = classDTO.IsActive;

            return iClassRepoCustom.Save(classEntity);
        }

        public List<ClassDTO> FindAllClasses()
        {
            ArrayList classList = iClassRepoCustom.GetAll();
            List<ClassDTO> list = new List<ClassDTO>();

            foreach (Class c in classList)
            {
                list.Add(new ClassDTO(c.ClassId, c.ClassName, c.ClassCode, c.IsActive));
            }

            return list;
        }
    }
}
