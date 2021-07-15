using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Class name is a required field.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage ="Class name input no special characters allowed!")]
        public string ClassName { get => className; set => className = value; }

        [Required(ErrorMessage = "Class code is a required field.")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Class code input no special characters allowed!")]
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

        public void Validate()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
        }
    }
}
