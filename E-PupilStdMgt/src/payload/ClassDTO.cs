using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class ClassDTO
    {
        private int classId;
        private string className;
        private string classCode;
        private int isActive;

        public ClassDTO() { }

        public ClassDTO(string classCode)
        {
            this.classCode = classCode;
        }

        public ClassDTO(int classId, string className, string classCode, int isActive)
        {
            this.classId = classId;
            this.className = className;
            this.classCode = classCode;
            this.isActive = isActive;
        }

        public int ClassId { get => classId; set => classId = value; }
        public string ClassName { get => className; set => className = value; }
        public string ClassCode { get => classCode; set => classCode = value; }
        public int IsActive { get => isActive; set => isActive = value; }

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
