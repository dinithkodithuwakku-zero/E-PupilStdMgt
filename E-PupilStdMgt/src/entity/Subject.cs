using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.entity
{
    class Subject
    {
        private int subjectId;
        private string subjectName;
        private string subjectCode;
        private int subjectDuration;
        private double subjectTotalPoints;

        public Subject() { }

        public Subject(int subjectId, string subjectName, string subjectCode, int subjectDuration, double subjectTotalPoints)
        {
            this.subjectId = subjectId;
            this.subjectName = subjectName;
            this.subjectCode = subjectCode;
            this.subjectDuration = subjectDuration;
            this.subjectTotalPoints = subjectTotalPoints;
        }

        public Subject(string subjectName, string subjectCode, int subjectDuration, double subjectTotalPoints)
        {
            SubjectName = subjectName;
            SubjectCode = subjectCode;
            SubjectDuration = subjectDuration;
            SubjectTotalPoints = subjectTotalPoints;
        }

        public int SubjectId { get => subjectId; set => subjectId = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public string SubjectCode { get => subjectCode; set => subjectCode = value; }
        public int SubjectDuration { get => subjectDuration; set => subjectDuration = value; }
        public double SubjectTotalPoints { get => subjectTotalPoints; set => subjectTotalPoints = value; }

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
