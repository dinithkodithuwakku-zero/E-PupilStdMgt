using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.entity
{
    class ClassStudent
    {
        private int classStudentId;
        private Class classEntity;
        private Student studentEntity;

        public ClassStudent()
        {
        }

        public ClassStudent(int classStudentId, Class classEntity, Student studentEntity)
        {
            this.classStudentId = classStudentId;
            this.classEntity = classEntity;
            this.studentEntity = studentEntity;
        }

        public int ClassStudentId { get => classStudentId; set => classStudentId = value; }
        internal Class ClassEntity { get => classEntity; set => classEntity = value; }
        internal Student StudentEntity { get => studentEntity; set => studentEntity = value; }

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
