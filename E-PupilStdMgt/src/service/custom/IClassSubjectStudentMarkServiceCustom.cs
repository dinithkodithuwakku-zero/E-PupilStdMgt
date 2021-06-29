using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.payload;

namespace E_PupilStdMgt.src.service.custom
{
    interface IClassSubjectStudentMarkServiceCustom: ISuperService
    {
        public bool CreateStudentMark(ClassSubjectStudentMarkDTO classSubjectStudentMarkDTO);
    }
}
