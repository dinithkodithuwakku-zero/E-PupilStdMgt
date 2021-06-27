using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.entity
{
    class ClassSubject
    {
        private int classSubjectId;
        private Class classEntity;
        private Subject subjectEntity;

        public ClassSubject()
        {
        }

        public ClassSubject(int classSubjectId, Class classEntity, Subject subjectEntity)
        {
            this.classSubjectId = classSubjectId;
            this.classEntity = classEntity;
            this.subjectEntity = subjectEntity;
        }

        public int ClassSubjectId { get => classSubjectId; set => classSubjectId = value; }
        internal Class ClassEntity { get => classEntity; set => classEntity = value; }
        internal Subject SubjectEntity { get => subjectEntity; set => subjectEntity = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
