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
    class ClassSubjectStudentServiceImpl : IClassSubjectStudentMarkServiceCustom
    {
        private IClassSubjectStudentMarkRepoCustom iClassSubjectStudentMarkRepo;
        private IClassServiceCustom iClassServiceCustom;
        private ISubjectServiceCustom iSubjectServiceCustom;
        private IStudentServiceCustom iStudentServiceCustom;

        public ClassSubjectStudentServiceImpl()
        {
            iClassSubjectStudentMarkRepo = RepoFactory.GetInstance().GetRepo<ClassSubjectStudentMarkRepoImpl>(RepoFactory.RepoTypes.CLASS_SUBJECT_STUDENT_MARK);
            iClassServiceCustom = ServiceFactory.GetInstance().GetService<ClassServiceImpl>(ServiceFactory.ServiceTypes.CLASS);
            iSubjectServiceCustom = ServiceFactory.GetInstance().GetService<SubjectServiceImpl>(ServiceFactory.ServiceTypes.SUBJECT);
            iStudentServiceCustom = ServiceFactory.GetInstance().GetService<StudentServiceImpl>(ServiceFactory.ServiceTypes.STUDENT);
        }

        public ArrayList CalculateStudentsGPA()
        {

            Dictionary<string, double> studentDict = new Dictionary<string, double>();

            ArrayList list = iClassSubjectStudentMarkRepo.GetAll();

            foreach (ClassSubjectStudentMark classSubjectStudentMark in list)
            {
                // GET SUBJECT DETAILS
                SubjectDTO subjectDTO = iSubjectServiceCustom.FindSubjectById(classSubjectStudentMark.ClassSubject.SubjectEntity.SubjectId);

                // GET STUDENT DETAILS
                StudentDTO studentDTO = iStudentServiceCustom.FindStudentById(classSubjectStudentMark.Student.StudentId);

                if (studentDict.ContainsKey(studentDTO.StudentRegNo))
                {
                    double value = studentDict[studentDTO.StudentRegNo];
                    studentDict[studentDTO.StudentRegNo] =  (value + classSubjectStudentMark.StudentPoint) / subjectDTO.SubjectTotalPoints;
                }
                else
                {
                    studentDict.Add(studentDTO.StudentRegNo, classSubjectStudentMark.StudentPoint / subjectDTO.SubjectTotalPoints);
                }
            }

            ArrayList arrayList = new ArrayList();

            foreach (var item in studentDict)
            {
                StudentGPADTO studentGPADTO = new StudentGPADTO();
                studentGPADTO.StudentRegNo = item.Key;
                studentGPADTO.Gpa = item.Value;

                arrayList.Add(studentGPADTO);
            }

            return arrayList;
        }

        public bool CreateStudentMark(ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO)
        {

            ClassSubjectDTO classSubjectDTO = iClassServiceCustom.FindClassSubjectByClassCodeAndSubjectCode(classSubjectStudentMarkDTO.ClassSubjectDTO.ClassDTO.ClassCode, classSubjectStudentMarkDTO.ClassSubjectDTO.SubjectDTO.SubjectCode);

            return iClassSubjectStudentMarkRepo.Save(new ClassSubjectStudentMark(classSubjectStudentMarkDTO.ExamDate,
                classSubjectStudentMarkDTO.StudentPoint, new ClassSubject(classSubjectDTO.ClassSubjectId), new Student(classSubjectStudentMarkDTO.StudentDTO.StudentId)));
        }

        public bool DeleteStudentMark(int classSubjectStudentMarkId)
        {
            return iClassSubjectStudentMarkRepo.Delete(classSubjectStudentMarkId);
        }

        public List<ClassSubjectStudentMarkDTO> FindClassSubjectStudentMarks()
        {
            ArrayList list = iClassSubjectStudentMarkRepo.GetAll();
            List<ClassSubjectStudentMarkDTO> classSubjectStudentMarkDTOs = new List<ClassSubjectStudentMarkDTO>();

            foreach (ClassSubjectStudentMark classSubjectStudentMark in list)
            {
                // GET CLASS DETAILS
                ClassDTO classDTO = iClassServiceCustom.FindClassById(classSubjectStudentMark.ClassSubject.ClassEntity.ClassId);

                // GET SUBJECT DETAILS
                SubjectDTO subjectDTO = iSubjectServiceCustom.FindSubjectById(classSubjectStudentMark.ClassSubject.SubjectEntity.SubjectId);

                // GET STUDENT DETAILS
                StudentDTO studentDTO = iStudentServiceCustom.FindStudentById(classSubjectStudentMark.Student.StudentId);

                classSubjectStudentMarkDTOs.Add(new ClassSubjectStudentMarkDTO(classSubjectStudentMark.ClassSubjectStudentMarkId, new ClassSubjectDTO(classSubjectStudentMark.ClassSubject.ClassSubjectId, classDTO, subjectDTO), studentDTO, classSubjectStudentMark.ExamDate, classSubjectStudentMark.StudentPoint));
            }

            return classSubjectStudentMarkDTOs;
        }

        public List<ClassSubjectStudentMarkDTO> FindClassSubjectStudentMarks(string classCode, string subjectCode)
        {
            ArrayList list = iClassSubjectStudentMarkRepo.GetAll();
            List<ClassSubjectStudentMarkDTO> classSubjectStudentMarkDTOs = new List<ClassSubjectStudentMarkDTO>();

            foreach (ClassSubjectStudentMark classSubjectStudentMark in list)
            {
                // GET CLASS DETAILS
                ClassDTO classDTO = iClassServiceCustom.FindClassById(classSubjectStudentMark.ClassSubject.ClassEntity.ClassId);

                // GET SUBJECT DETAILS
                SubjectDTO subjectDTO = iSubjectServiceCustom.FindSubjectById(classSubjectStudentMark.ClassSubject.SubjectEntity.SubjectId);

                // GET STUDENT DETAILS
                StudentDTO studentDTO = iStudentServiceCustom.FindStudentById(classSubjectStudentMark.Student.StudentId);

                if (classCode != null && (!classCode.Equals("") && classDTO.ClassCode.Equals(classCode)) && subjectCode != null && (!subjectCode.Equals("") && subjectDTO.SubjectCode.Equals(subjectCode)))
                {
                    classSubjectStudentMarkDTOs.Add(new ClassSubjectStudentMarkDTO(classSubjectStudentMark.ClassSubjectStudentMarkId, new ClassSubjectDTO(classSubjectStudentMark.ClassSubject.ClassSubjectId, classDTO, subjectDTO), studentDTO, classSubjectStudentMark.ExamDate, classSubjectStudentMark.StudentPoint));
                }
                else if (classCode != null && (!classCode.Equals("") && classDTO.ClassCode.Equals(classCode)) && subjectCode == null)
                {
                    classSubjectStudentMarkDTOs.Add(new ClassSubjectStudentMarkDTO(classSubjectStudentMark.ClassSubjectStudentMarkId, new ClassSubjectDTO(classSubjectStudentMark.ClassSubject.ClassSubjectId, classDTO, subjectDTO), studentDTO, classSubjectStudentMark.ExamDate, classSubjectStudentMark.StudentPoint));
                }
            }

            return classSubjectStudentMarkDTOs;
        }

        public bool UpdateStudentMark(ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO)
        {
            return iClassSubjectStudentMarkRepo.Update(new ClassSubjectStudentMark(classSubjectStudentMarkDTO.ClassSubjectStudentMarkId, classSubjectStudentMarkDTO.ExamDate, classSubjectStudentMarkDTO.StudentPoint));
        }
    }
}
