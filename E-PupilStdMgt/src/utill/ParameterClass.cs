using System;
using System.Collections.Generic;
using System.Text;

namespace E_PupilStdMgt.src.utill
{
    class ParameterClass
    {
        private String parameterKey;
        private String parameterValue;

        public ParameterClass(String parameterKey,String parameterValue)
        {
            this.parameterKey = parameterKey;
            this.parameterValue = parameterValue;
        }

        public String getParameterKey()
        {
            return this.parameterKey;
        }

        public String getParameterValue()
        {
            return this.parameterValue;
        }
    }
}
