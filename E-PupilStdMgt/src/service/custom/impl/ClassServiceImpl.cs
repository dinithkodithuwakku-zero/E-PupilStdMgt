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

        public int AddSubjectMapping(ClassSubjectDTO classSubjectDTO)
        {
            // FIRST CHECK ALREADY ADDED CLASS SUBJECT MAPPING
            // IF YES, WE SHOULD ASK TO DELETE MAPPING OR CREATE MAPPING
            ClassSubject classSubject = iClassRepoCustom.FindClassSubjectByClassCodeAndSubjectCode(classSubjectDTO.ClassDTO.ClassCode, classSubjectDTO.SubjectDTO.SubjectCode);
            if (classSubject != null)
            {
                // FOUND MAPPING
                return 9;
            }
            else
            {
                classSubject = new ClassSubject();
                classSubject.ClassEntity = iClassRepoCustom.FindClassByCode(classSubjectDTO.ClassDTO.ClassCode);
                SubjectDTO subjectDTO = iSubjectServiceCustom.FindSubjectByCode(classSubjectDTO.SubjectDTO.SubjectCode);
                classSubject.SubjectEntity = new Subject(subjectDTO.SubjectId, subjectDTO.SubjectName, subjectDTO.SubjectCode, subjectDTO.SubjectDuration, subjectDTO.SubjectTotalPoints);

                return iClassRepoCustom.AddSubjectMapping(classSubject) ? 1 : 0;
            }

            // RETURN 1 - CREATE NEW MAP, 0 - UNABLE TO CREATE MAP, 9 - ALREADY ADDED
        }

        public int AddStudentMapping(ClassStudentDTO classStudentDTO)
        {
            // FIRST CHECK ALREADY ADDED CLASS STUDENT MAPPING
            // IF YES, WE SHOULD ASK TO DELETE MAPPING OR CREATE MAPPING
            ClassStudent classStudent = iClassRepoCustom.FindClassStudentByClassCodeAndStudentRegNo(classStudentDTO.ClassDTO.ClassCode, classStudentDTO.StudentDTO.StudentRegNo);

            if (classStudent != null)
            {
                return 9;
            }
            else
            {
                classStudent = new ClassStudent();
                classStudent.ClassEntity = iClassRepoCustom.FindClassByCode(classStudentDTO.ClassDTO.ClassCode);
                StudentDTO studentDTO = iStudentServiceCustom.FindStudentByRegNo(classStudentDTO.StudentDTO.StudentRegNo);
                classStudent.StudentEntity = new Student(studentDTO.StudentId, studentDTO.StudentRegNo, studentDTO.StudentName, studentDTO.MobileNo, studentDTO.Gender, studentDTO.Email, studentDTO.PermanentAddress);

                return iClassRepoCustom.AddStudentMapping(classStudent) ? 1 : 0;
            }

            // RETURN 1 - CREATE NEW MAP, 0 - UNABLE TO CREATE MAP, 9 - ALREADY ADDED
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
            ClassDTO classDTO = this.FindClassByCode(classCode);
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

        public ClassDTO FindClassById(int id)
        {
            Class classEntity = iClassRepoCustom.Search(id);
            return new ClassDTO(classEntity.ClassId, classEntity.ClassName, classEntity.ClassCode, classEntity.IsActive);
        }

        public bool UpdateClass(ClassDTO classDTO)
        {
            Class classEntity = new Class();
            classEntity.ClassId = classDTO.ClassId;
            classEntity.ClassName = classDTO.ClassName;
            classEntity.ClassCode = classDTO.ClassCode;
            classEntity.IsActive = classDTO.IsActive;

            return iClassRepoCustom.Update(classEntity);
        }

        public bool DeleteClass(int classId)
        {
            return iClassRepoCustom.Delete(classId);
        }

        public bool DeleteSubjectMapping(ClassSubjectDTO classSubjectDTO)
        {
            ClassSubject classSubject = iClassRepoCustom.FindClassSubjectByClassCodeAndSubjectCode(classSubjectDTO.ClassDTO.ClassCode, classSubjectDTO.SubjectDTO.SubjectCode);

            return iClassRepoCustom.DeleteSubjectMapping(classSubject);
        }

        public bool DeleteStudentMapping(ClassStudentDTO classStudentDTO)
        {
            ClassStudent classStudent= iClassRepoCustom.FindClassStudentByClassCodeAndStudentRegNo(classStudentDTO.ClassDTO.ClassCode, classStudentDTO.StudentDTO.StudentRegNo);

            return iClassRepoCustom.DeleteStudentMapping(classStudent);
        }
    }
}
