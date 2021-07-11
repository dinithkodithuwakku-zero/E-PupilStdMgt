using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.entity;
using E_PupilStdMgt.src.repository;
using E_PupilStdMgt.src.repository.custom;
using E_PupilStdMgt.src.repository.custom.impl;
using System.Collections;
using E_PupilStdMgt.src.payload;

namespace E_PupilStdMgt.src.service.custom.impl
{
    class StuffServiceImpl : IStuffServiceCustom
    {
        private IStuffRepoCustom iStuffRepoCustom;

        public StuffServiceImpl()
        {
            iStuffRepoCustom = RepoFactory.GetInstance().GetRepo<StuffRepoImpl>(RepoFactory.RepoTypes.STUFF);
        }
        public bool CreateNewStuff(StuffDTO stuffDTO)
        {
            return iStuffRepoCustom.Save(new Stuff(stuffDTO.UserName, stuffDTO.Password, stuffDTO.FullName, stuffDTO.Nic, stuffDTO.JobTitle, stuffDTO.MobileNo, stuffDTO.Email, stuffDTO.PermanentAddress));
        }

        public bool DeleteStuff(int stuffId)
        {
            return iStuffRepoCustom.Delete(stuffId);
        }

        public List<StuffDTO> FindAllStuff()
        {
            ArrayList stuffList = iStuffRepoCustom.GetAll();
            List<StuffDTO> list = new List<StuffDTO>();

            foreach (Stuff s in stuffList)
            {
                list.Add(new StuffDTO(s.StuffId, s.UserName, s.FullName, s.Nic, s.JobTitle, s.MobileNo, s.Email, s.PermanentAddress));
            }

            return list;
        }

        public bool UpdateStuff(StuffDTO stuffDTO)
        {
            return iStuffRepoCustom.Update(new Stuff(stuffDTO.StuffId, stuffDTO.FullName, stuffDTO.Nic, stuffDTO.JobTitle, stuffDTO.MobileNo, stuffDTO.Email, stuffDTO.PermanentAddress));
        }
    }
}
