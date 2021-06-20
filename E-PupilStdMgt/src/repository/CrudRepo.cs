using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace E_PupilStdMgt.src.repository
{
    interface ICrudRepo<T,ID> : ISuperRepo
    {
        public Boolean Save(T entity);

        public Boolean Update(T entity);

        public Boolean Delete(ID id);

        public T Search(ID id);

        public T GetOne();

        public ArrayList GetAll();
    }
}
