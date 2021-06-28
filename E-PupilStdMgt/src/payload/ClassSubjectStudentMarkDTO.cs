using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class ClassSubjectStudentMarkDTO
    {
        private int classSubjectStudentMarkId;
        private ClassSubjectDTO classSubjectDTO;
        private StudentDTO studentDTO;
        private DateTime examDate;
        private double studentPoint;

        public ClassSubjectStudentMarkDTO()
        {
        }

        public ClassSubjectStudentMarkDTO(int classSubjectStudentMarkId, ClassSubjectDTO classSubjectDTO, StudentDTO studentDTO, DateTime examDate, double studentPoint)
        {
            this.classSubjectStudentMarkId = classSubjectStudentMarkId;
            this.classSubjectDTO = classSubjectDTO;
            this.studentDTO = studentDTO;
            this.examDate = examDate;
            this.studentPoint = studentPoint;
        }

        public int ClassSubjectStudentMarkId { get => classSubjectStudentMarkId; set => classSubjectStudentMarkId = value; }
        public DateTime ExamDate { get => examDate; set => examDate = value; }
        public double StudentPoint { get => studentPoint; set => studentPoint = value; }
        internal ClassSubjectDTO ClassSubjectDTO { get => classSubjectDTO; set => classSubjectDTO = value; }
        internal StudentDTO StudentDTO { get => studentDTO; set => studentDTO = value; }

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
