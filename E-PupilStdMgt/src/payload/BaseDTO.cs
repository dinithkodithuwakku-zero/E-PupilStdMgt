using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class BaseDTO
    {
        private int status; // 0 - deactive, 1 - active, 9 - delete

        public BaseDTO()
        {
        }

        public BaseDTO(int status)
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
