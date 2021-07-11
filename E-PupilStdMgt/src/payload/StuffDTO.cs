using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class StuffDTO
    {
        private int stuffId;
        private string userName;
        private string password;
        private string fullName;
        private string nic;
        private string jobTitle;
        private string mobileNo;
        private string email;
        private string permanentAddress;

        public StuffDTO() { }
        public StuffDTO(int stuffId, string userName, string password, string fullName, string nic, string jobTitle, string mobileNo, string email, string permanentAddress)
        {
            this.stuffId = stuffId;
            this.userName = userName;
            this.password = password;
            this.fullName = fullName;
            this.nic = nic;
            this.jobTitle = jobTitle;
            this.mobileNo = mobileNo;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public StuffDTO(int stuffId, string fullName, string nic, string jobTitle, string mobileNo, string email, string permanentAddress)
        {
            this.stuffId = stuffId;
            this.fullName = fullName;
            this.nic = nic;
            this.jobTitle = jobTitle;
            this.mobileNo = mobileNo;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public StuffDTO(int stuffId, string userName, string fullName, string nic, string jobTitle, string mobileNo, string email, string permanentAddress)
        {
            this.stuffId = stuffId;
            this.userName = userName;
            this.fullName = fullName;
            this.nic = nic;
            this.jobTitle = jobTitle;
            this.mobileNo = mobileNo;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public StuffDTO(string userName, string password, string fullName, string nic, string jobTitle, string mobileNo, string email, string permanentAddress)
        {
            this.userName = userName;
            this.password = password;
            this.fullName = fullName;
            this.nic = nic;
            this.jobTitle = jobTitle;
            this.mobileNo = mobileNo;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public int StuffId { get => stuffId; set => stuffId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Nic { get => nic; set => nic = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string MobileNo { get => mobileNo; set => mobileNo = value; }
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
