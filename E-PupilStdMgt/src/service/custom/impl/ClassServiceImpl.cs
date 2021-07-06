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
    class ClassServiceImpl : IClassServiceCustom
    {
        private IClassRepoCustom iClassRepoCustom;
        private ISubjectServiceCustom iSubjectServiceCustom;
        private IStudentServiceCustom iStudentServiceCustom;

        public ClassServiceImpl()
        {
            iClassRepoCustom = new ClassRepoImpl();
            iSubjectServiceCustom = ServiceFactory.GetInstance().GetService<SubjectServiceImpl>(ServiceFactory.ServiceTypes.SUBJECT);
            iStudentServiceCustom = ServiceFactory.GetInstance().GetService<StudentServiceImpl>(ServiceFactory.ServiceTypes.STUDENT);
        }

        public bool AddSubjectMapping(ClassSubjectDTO classSubjectDTO)
        {
            ClassSubject classSubject = new ClassSubject();
            classSubject.ClassEntity = iClassRepoCustom.FindClassByCode(classSubjectDTO.ClassDTO.ClassCode);
            SubjectDTO subjectDTO = iSubjectServiceCustom.FindSubjectByCode(classSubjectDTO.SubjectDTO.SubjectCode);
            classSubject.SubjectEntity = new Subject(subjectDTO.SubjectId, subjectDTO.SubjectName, subjectDTO.SubjectCode, subjectDTO.SubjectDuration, subjectDTO.SubjectTotalPoints); ;

            return iClassRepoCustom.AddSubjectMapping(classSubject);
        }

        public bool AddStudentMapping(ClassStudentDTO classStudentDTO)
        {
            ClassStudent classStudent = new ClassStudent();
            classStudent.ClassEntity = iClassRepoCustom.FindClassByCode(classStudentDTO.ClassDTO.ClassCode);
            StudentDTO studentDTO = iStudentServiceCustom.FindStudentByRegNo(classStudentDTO.StudentDTO.StudentRegNo);
            classStudent.StudentEntity = new Student(studentDTO.StudentId, studentDTO.StudentRegNo, studentDTO.StudentName, studentDTO.MobileNo, studentDTO.Gender, studentDTO.Email, studentDTO.PermanentAddress);

            return iClassRepoCustom.AddStudentMapping(classStudent);
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

        public List<ClassSubjectDTO> FindSubjectMapping()
        {
            ArrayList classSubjectList = iClassRepoCustom.GetSubjectMapping();
            List<ClassSubjectDTO> list = new List<ClassSubjectDTO>();
            foreach (ClassSubject cs in classSubjectList)
            {
                SubjectDTO subjectDTO = iSubjectServiceCustom.FindSubjectById(cs.SubjectEntity.SubjectId);
                list.Add(new ClassSubjectDTO(cs.ClassSubjectId, new ClassDTO(cs.ClassEntity.ClassId, cs.ClassEntity.ClassName, cs.ClassEntity.ClassCode, cs.ClassEntity.IsActive), subjectDTO));
            }

            return list;
        }

        public List<ClassStudentDTO> FindStudentMapping()
        {
            ArrayList classStudentList = iClassRepoCustom.GetStudentMapping();
            List<ClassStudentDTO> list = new List<ClassStudentDTO>();
            foreach (ClassStudent cs in classStudentList)
            {
                StudentDTO studentDTO = iStudentServiceCustom.FindStudentById(cs.StudentEntity.StudentId);
                list.Add(new ClassStudentDTO(cs.ClassStudentId, new ClassDTO(cs.ClassEntity.ClassId, cs.ClassEntity.ClassName, cs.ClassEntity.ClassCode, cs.ClassEntity.IsActive), studentDTO));
            }

            return list;
        }

        public ClassDTO FindClassByCode(string classCode)
        {
            Class classEntity = iClassRepoCustom.FindClassByCode(classCode);
            return new ClassDTO(classEntity.ClassId, classEntity.ClassName, classEntity.ClassCode, classEntity.IsActive);
        }

        public List<SubjectDTO> FindAllSubjectsByClassCodeAndStudentId(string classCode, int studentId)
        {
            //ClassDTO classDTO = iClassServiceCustom.FindClassByCode(classCode);
            List<ClassSubjectDTO> classSubjectDTOs = this.FindSubjectMappingByStudentAndClass(classCode, studentId);

            List<SubjectDTO> subjectDTOs = new List<SubjectDTO>();
            foreach (ClassSubjectDTO csDTO in classSubjectDTOs)
            {
                subjectDTOs.Add(iSubjectServiceCustom.FindSubjectById(csDTO.SubjectDTO.SubjectId));
            }

            return subjectDTOs;
        }

        public List<ClassSubjectDTO> FindSubjectMappingByStudentAndClass(string classCode, int studentId)
        {
            ClassDTO  classDTO = this.FindClassByCode(classCode);
            ArrayList classSubjectList = iClassRepoCustom.FindSubjectMappingByStudentAndClass(classDTO.ClassId, studentId);
            List<ClassSubjectDTO> list = new List<ClassSubjectDTO>();
            foreach (ClassSubject cs in classSubjectList)
            {
                SubjectDTO subjectDTO = iSubjectServiceCustom.FindSubjectById(cs.SubjectEntity.SubjectId);
                list.Add(new ClassSubjectDTO(cs.ClassSubjectId, new ClassDTO(cs.ClassEntity.ClassId, cs.ClassEntity.ClassName, cs.ClassEntity.ClassCode, cs.ClassEntity.IsActive), subjectDTO));
            }

            return list;
        }

        public ClassSubjectDTO FindClassSubjectByClassCodeAndSubjectCode(string classCode, string subjectCode)
        {
            ClassSubject classSubject = iClassRepoCustom.FindClassSubjectByClassCodeAndSubjectCode(classCode, subjectCode);
            return new ClassSubjectDTO(classSubject.ClassSubjectId);
        }
    }
}
