using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class SchoolDTO
    {
        private int schoolId;
        private string schoolName;
        private string schoolDescription;
        private string schoolContactNo;
        private string schoolAddress;
        private string schoolBadgeImagePath;

        public SchoolDTO()
        {
        }

        public SchoolDTO(int schoolId, string schoolName, string schoolDescription, string schoolContactNo, string schoolAddress, string schoolBadgeImagePath)
        {
            this.schoolId = schoolId;
            this.schoolName = schoolName;
            this.schoolDescription = schoolDescription;
            this.schoolContactNo = schoolContactNo;
            this.schoolAddress = schoolAddress;
            this.schoolBadgeImagePath = schoolBadgeImagePath;
        }

        public int SchoolId { get => schoolId; set => schoolId = value; }
        public string SchoolName { get => schoolName; set => schoolName = value; }
        public string SchoolDescription { get => schoolDescription; set => schoolDescription = value; }
        public string SchoolContactNo { get => schoolContactNo; set => schoolContactNo = value; }
        public string SchoolAddress { get => schoolAddress; set => schoolAddress = value; }
        public string SchoolBadgeImagePath { get => schoolBadgeImagePath; set => schoolBadgeImagePath = value; }

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
