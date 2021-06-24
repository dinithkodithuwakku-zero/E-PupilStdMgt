using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.repository.custom.impl;

namespace E_PupilStdMgt.src.repository
{
    class RepoFactory
    {
        private static RepoFactory repoFactory;
        public enum RepoTypes
        {
            SCHOOL, CLASS, SUBJECT, STUDENT, STUFF
        }

        public RepoFactory()
        {
        }

        public static RepoFactory GetInstance()
        {
            if (repoFactory == null)
            {
                repoFactory = new RepoFactory();
            }
            return repoFactory;
        }

        public T GetRepo<T>(RepoTypes repoTypes) where T : ISuperRepo
        {
            switch (repoTypes)
            {
                case RepoTypes.SCHOOL:
                    return (T)Convert.ChangeType(new SchoolRepoImpl(), typeof(T));
                case RepoTypes.CLASS:
                    return (T)Convert.ChangeType(new ClassRepoImpl(), typeof(T));
                case RepoTypes.SUBJECT:
                    return (T)Convert.ChangeType(new SubjectRepoImpl(), typeof(T));
                case RepoTypes.STUDENT:
                    return (T)Convert.ChangeType(new StudentRepoImpl(), typeof(T));
                case RepoTypes.STUFF:
                    return (T)Convert.ChangeType(new StuffRepoImpl(), typeof(T));
                default:
                    return default;
            }

        }
    }
}
