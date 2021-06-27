using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class ClassStudentDTO
    {
        private int classStudentId;
        private ClassDTO classDTO;
        private StudentDTO studentDTO;

        public ClassStudentDTO()
        {
        }

        public ClassStudentDTO(int classStudentId, ClassDTO classDTO, StudentDTO studentDTO)
        {
            this.classStudentId = classStudentId;
            this.classDTO = classDTO;
            this.studentDTO = studentDTO;
        }

        public int ClassStudentId { get => classStudentId; set => classStudentId = value; }
        internal ClassDTO ClassDTO { get => classDTO; set => classDTO = value; }
        internal StudentDTO StudentDTO { get => studentDTO; set => studentDTO = value; }

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
