using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.entity
{
    class ClassSubjectStudentMark
    {
        private int classSubjectStudentMarkId;
        private ClassSubject classSubject;
        private Student student;
        private DateTime examDate;
        private double studentPoint;

        public ClassSubjectStudentMark()
        {
        }

        public ClassSubjectStudentMark(DateTime examDate, double studentPoint, ClassSubject classSubject, Student student)
        {
            ExamDate = examDate;
            StudentPoint = studentPoint;
            ClassSubject = classSubject;
            Student = student;
        }

        public ClassSubjectStudentMark(int classSubjectStudentMarkId, ClassSubject classSubject, Student student, DateTime examDate, double studentPoint)
        {
            this.classSubjectStudentMarkId = classSubjectStudentMarkId;
            this.classSubject = classSubject;
            this.student = student;
            this.examDate = examDate;
            this.studentPoint = studentPoint;
        }

        public int ClassSubjectStudentMarkId { get => classSubjectStudentMarkId; set => classSubjectStudentMarkId = value; }
        public DateTime ExamDate { get => examDate; set => examDate = value; }
        public double StudentPoint { get => studentPoint; set => studentPoint = value; }
        internal ClassSubject ClassSubject { get => classSubject; set => classSubject = value; }
        internal Student Student { get => student; set => student = value; }

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
