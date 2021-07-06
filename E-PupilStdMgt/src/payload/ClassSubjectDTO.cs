using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class ClassSubjectDTO
    {
        private int classSubjectId;
        private ClassDTO classDTO;
        private SubjectDTO subjectDTO;

        public ClassSubjectDTO()
        {
        }

        public ClassSubjectDTO(int classSubjectId)
        {
            this.classSubjectId = classSubjectId;
        }

        public ClassSubjectDTO(ClassDTO classDTO, SubjectDTO subjectDTO)
        {
            this.classDTO = classDTO;
            this.subjectDTO = subjectDTO;
        }

        public ClassSubjectDTO(int classSubjectId, ClassDTO classDTO, SubjectDTO subjectDTO)
        {
            this.classSubjectId = classSubjectId;
            this.classDTO = classDTO;
            this.subjectDTO = subjectDTO;
        }

        public int ClassSubjectId { get => classSubjectId; set => classSubjectId = value; }
        internal ClassDTO ClassDTO { get => classDTO; set => classDTO = value; }
        internal SubjectDTO SubjectDTO { get => subjectDTO; set => subjectDTO = value; }

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
