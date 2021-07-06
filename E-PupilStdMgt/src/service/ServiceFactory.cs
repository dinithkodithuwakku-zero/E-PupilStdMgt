using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.service.custom.impl;

namespace E_PupilStdMgt.src.service
{
    class ServiceFactory
    {
        private static ServiceFactory serviceFactory;

        public enum ServiceTypes
        {
            SCHOOL, CLASS, SUBJECT, STUDENT, STUFF, ClASS_SUBJECT_STUDENT_MARK
        }
        public ServiceFactory()
        {
        }

        public static ServiceFactory GetInstance()
        {
            if (serviceFactory == null)
            {
                serviceFactory = new ServiceFactory();
            }
            return serviceFactory;
        }

        public T GetService<T>(ServiceTypes serviceTypes) where T : ISuperService
        {
            switch (serviceTypes)
            {
                case ServiceTypes.SCHOOL:
                    return (T)Convert.ChangeType(new SchoolServiceImpl(), typeof(T));
                case ServiceTypes.CLASS:
                    return (T)Convert.ChangeType(new ClassServiceImpl(), typeof(T));
                case ServiceTypes.SUBJECT:
                    return (T)Convert.ChangeType(new SubjectServiceImpl(), typeof(T));
                case ServiceTypes.STUDENT:
                    return (T)Convert.ChangeType(new StudentServiceImpl(), typeof(T));
                case ServiceTypes.STUFF:
                    return (T)Convert.ChangeType(new StuffServiceImpl(), typeof(T));
                case ServiceTypes.ClASS_SUBJECT_STUDENT_MARK:
                    return (T)Convert.ChangeType(new ClassSubjectStudentServiceImpl(), typeof(T));
                default:
                    return default;
            }

        }
    }
}
