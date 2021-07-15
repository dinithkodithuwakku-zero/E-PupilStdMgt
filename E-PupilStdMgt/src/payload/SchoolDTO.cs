using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class SchoolDTO
    {
        private int schoolId;
        private string schoolName;
        private string schoolDescription;
        private string schoolContactNo;
        private string schoolAddress;
        private string schoolBadgeImagePath;

        public SchoolDTO()
        {
        }

        public SchoolDTO(int schoolId, string schoolName, string schoolDescription, string schoolContactNo, string schoolAddress, string schoolBadgeImagePath)
        {
            this.schoolId = schoolId;
            this.schoolName = schoolName;
            this.schoolDescription = schoolDescription;
            this.schoolContactNo = schoolContactNo;
            this.schoolAddress = schoolAddress;
            this.schoolBadgeImagePath = schoolBadgeImagePath;
        }

        public int SchoolId { get => schoolId; set => schoolId = value; }

        [Required(ErrorMessage = "School name is a required field.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "School name input allow only english letters!")]
        public string SchoolName { get => schoolName; set => schoolName = value; }

        [Required(ErrorMessage = "School description is a required field.")]
        [RegularExpression(@"^[a-zA-Z0-9\s.]+$", ErrorMessage = "School description input no special characters allowed!")]
        public string SchoolDescription { get => schoolDescription; set => schoolDescription = value; }

        [Required(ErrorMessage = "School contact no is a required field.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "School contact no input allow only numbers!")]
        public string SchoolContactNo { get => schoolContactNo; set => schoolContactNo = value; }

        [Required(ErrorMessage = "School address is a required field.")]
        [RegularExpression(@"^[a-zA-Z0-9\s,.]+$", ErrorMessage = "School address input no special characters allowed!")]
        public string SchoolAddress { get => schoolAddress; set => schoolAddress = value; }

        [Required(ErrorMessage = "School badge is a required.")]
        public string SchoolBadgeImagePath { get => schoolBadgeImagePath; set => schoolBadgeImagePath = value; }

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
