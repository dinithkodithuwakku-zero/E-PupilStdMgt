using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class StudentDTO: BaseDTO
    {
        private int studentId;
        private string studentRegNo;
        private string studentName;
        private string mobileNo;
        private string gender;
        private string email;
        private string permanentAddress;

        public StudentDTO() { }

        public StudentDTO(int studentId, string studentRegNo, string studentName, string mobileNo, string gender, string email, string permanentAddress)
        {
            this.studentId = studentId;
            this.studentRegNo = studentRegNo;
            this.studentName = studentName;
            this.mobileNo = mobileNo;
            this.gender = gender;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public StudentDTO(string studentRegNo, string studentName, string mobileNo, string gender, string email, string permanentAddress)
        {
            StudentRegNo = studentRegNo;
            StudentName = studentName;
            MobileNo = mobileNo;
            Gender = gender;
            Email = email;
            PermanentAddress = permanentAddress;
        }

        public int StudentId { get => studentId; set => studentId = value; }
        public string StudentRegNo { get => studentRegNo; set => studentRegNo = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string MobileNo { get => mobileNo; set => mobileNo = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string PermanentAddress { get => permanentAddress; set => permanentAddress = value; }

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
