﻿using System;
using System.Collections.Generic;
using System.Text;
using E_PupilStdMgt.src.payload;

namespace E_PupilStdMgt.src.service.custom
{
    interface IClassServiceCustom: ISuperService
    {
        public List<ClassDTO> FindAllClasses();

        public bool CreateClass(ClassDTO classDTO);
    }
}
