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
    class SubjectServiceImpl : ISubjectServiceCustom
    {
        private ISubjectRepoCustom iSubjectRepoCustom;

        public SubjectServiceImpl()
        {
            iSubjectRepoCustom = RepoFactory.GetInstance().GetRepo<SubjectRepoImpl>(RepoFactory.RepoTypes.SUBJECT);
        }

        public bool CreateNewSubject(SubjectDTO subjectDTO)
        {
            return iSubjectRepoCustom.Save(new Subject(subjectDTO.SubjectName, subjectDTO.SubjectCode, subjectDTO.SubjectDuration, subjectDTO.SubjectTotalPoints));
        }

        public List<SubjectDTO> FindAllSubjects()
        {
            ArrayList subjectList = iSubjectRepoCustom.GetAll();
            List<SubjectDTO> list = new List<SubjectDTO>();

            foreach (Subject s in subjectList)
            {
                list.Add(new SubjectDTO(s.SubjectId, s.SubjectName, s.SubjectCode, s.SubjectDuration, s.SubjectTotalPoints));
            }

            return list;
        }

        public SubjectDTO FindSubjectByCode(string code)
        {
            Subject subject = iSubjectRepoCustom.FindSubjectByCode(code);
            return new SubjectDTO(subject.SubjectId, subject.SubjectName, subject.SubjectCode, subject.SubjectDuration, subject.SubjectTotalPoints);
        }

        public SubjectDTO FindSubjectById(int id)
        {
            Subject subject = iSubjectRepoCustom.FindSubjectById(id);
            if (subject != null)
                return new SubjectDTO(subject.SubjectId, subject.SubjectName, subject.SubjectCode, subject.SubjectDuration, subject.SubjectTotalPoints);
            return null;
        }
    }
}
