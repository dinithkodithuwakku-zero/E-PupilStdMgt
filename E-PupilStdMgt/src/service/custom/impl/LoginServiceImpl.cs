using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.payload;
using E_PupilStdMgt.src.utill;
using System.Diagnostics;

namespace E_PupilStdMgt.src.service.custom.impl
{
    class LoginServiceImpl : ILoginServiceCustom
    {
        private IStuffServiceCustom iStuffServiceCustom;
        EncryptDecrypt encryptDecrypt = new EncryptDecrypt();

        public LoginServiceImpl()
        {
            iStuffServiceCustom = ServiceFactory.GetInstance().GetService<StuffServiceImpl>(ServiceFactory.ServiceTypes.STUFF);
        }

        public bool CheckLoginCredientials(LoginDTO loginDTO)
        {
           if(loginDTO.UserType == 1) // admin
            {
                return loginDTO.UserName.Equals("admin") && loginDTO.Password.Equals("admin@123");
            }
            else
            {
                StuffDTO stuffDTO = iStuffServiceCustom.FindStuffByUserName(loginDTO.UserName);
                string encryptPassword = encryptDecrypt.Encrypt(loginDTO.Password);
                Debug.WriteLine(encryptPassword);
                return stuffDTO != null && stuffDTO.Password.Equals(encryptPassword);
            }
        }
    }
}
