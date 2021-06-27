using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.entity
{
    class BaseEntity
    {
        private int status; // 0 - deactive, 1 - active, 9 - delete

        public BaseEntity()
        {
        }

        public BaseEntity(int status)
        {
            this.status = status;
        }

        public int Status { get => status; set => status = value; }

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
