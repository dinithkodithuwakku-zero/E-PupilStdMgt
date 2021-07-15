using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class SubjectDTO
    {
        private int subjectId;
        private string subjectName;
        private string subjectCode;
        private int subjectDuration;
        private double subjectTotalPoints;

        public SubjectDTO() { }

        public SubjectDTO(string subjectCode)
        {
            this.subjectCode = subjectCode;
        }


        public SubjectDTO(int subjectId, string subjectName, string subjectCode, int subjectDuration, double subjectTotalPoints)
        {
            this.subjectId = subjectId;
            this.subjectName = subjectName;
            this.subjectCode = subjectCode;
            this.subjectDuration = subjectDuration;
            this.subjectTotalPoints = subjectTotalPoints;
        }

        public SubjectDTO(string subjectName, string subjectCode, int subjectDuration, double subjectTotalPoints)
        {
            SubjectName = subjectName;
            SubjectCode = subjectCode;
            SubjectDuration = subjectDuration;
            SubjectTotalPoints = subjectTotalPoints;
        }

        public int SubjectId { get => subjectId; set => subjectId = value; }

        [Required(ErrorMessage = "Subject name is a required field.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Subject name input no special characters allowed!")]
        public string SubjectName { get => subjectName; set => subjectName = value; }

        [Required(ErrorMessage = "Subject code is a required field.")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Subject code input no special characters allowed!")]
        public string SubjectCode { get => subjectCode; set => subjectCode = value; }

        [Required(ErrorMessage = "Subject duration is a required field.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Subject duration input allow only numbers!")]
        public int SubjectDuration { get => subjectDuration; set => subjectDuration = value; }

        [Required(ErrorMessage = "Subject points is a required field.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Subject points input allow only numbers!")]
        public double SubjectTotalPoints { get => subjectTotalPoints; set => subjectTotalPoints = value; }

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
