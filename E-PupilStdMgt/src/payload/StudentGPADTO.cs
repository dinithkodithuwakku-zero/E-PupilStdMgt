using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class StudentGPADTO
    {
        private string studentRegNo;
        private double gpa;

        public StudentGPADTO()
        {
        }

        public StudentGPADTO(string studentRegNo, double gpa)
        {
            this.studentRegNo = studentRegNo;
            this.gpa = gpa;
        }

        public string StudentRegNo { get => studentRegNo; set => studentRegNo = value; }
        public double Gpa { get => gpa; set => gpa = value; }
    }
}
