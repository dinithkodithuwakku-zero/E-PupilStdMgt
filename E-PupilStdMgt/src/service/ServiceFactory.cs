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
            SCHOOL
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

        public T GetRepo<T>(ServiceTypes serviceTypes) where T : ISuperService
        {
            switch (serviceTypes)
            {
                case ServiceTypes.SCHOOL:
                    return (T)Convert.ChangeType(new SchoolServiceImpl(), typeof(T));
                default:
                    return default;
            }

        }
    }
}
