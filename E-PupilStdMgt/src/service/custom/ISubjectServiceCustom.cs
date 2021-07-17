﻿using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.payload;

namespace E_PupilStdMgt.src.service.custom
{
    interface ISubjectServiceCustom: ISuperService
    {
        public List<SubjectDTO> FindAllSubjects();
        public bool CreateNewSubject(SubjectDTO subjectDTO);
        public bool UpdateSubject(SubjectDTO subjectDTO);
        public bool DeleteSubject(int subjectId);
        public SubjectDTO FindSubjectByCode(string code);
        public SubjectDTO FindSubjectById(int id);
        public List<SubjectDTO> FindAllSubjectsByClassCode(string classCode);
        public int CountNumberOfSubjects();
    }
}
