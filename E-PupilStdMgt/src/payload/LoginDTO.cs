using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class LoginDTO
    {
        private string userName;
        private string password;
        private int userType;

        public LoginDTO()
        {
        }

        public LoginDTO(string userName, string password, int userType)
        {
            this.userName = userName;
            this.password = password;
            this.userType = userType;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int UserType { get => userType; set => userType = value; }
    }
}
