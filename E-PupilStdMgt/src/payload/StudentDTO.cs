using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace E_PupilStdMgt.src.payload
{
    class StudentDTO: BaseDTO
    {
        private int studentId;
        private string studentRegNo;
        private string studentName;
        private string mobileNo;
        private string gender;
        private string email;
        private string permanentAddress;

        public StudentDTO() { }

        public StudentDTO(int studentId)
        {
            this.studentId = studentId;
        }

        public StudentDTO(int studentId, string studentRegNo, string studentName, string mobileNo, string gender, string email, string permanentAddress)
        {
            this.studentId = studentId;
            this.studentRegNo = studentRegNo;
            this.studentName = studentName;
            this.mobileNo = mobileNo;
            this.gender = gender;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public StudentDTO(string studentRegNo, string studentName, string mobileNo, string gender, string email, string permanentAddress)
        {
            StudentRegNo = studentRegNo;
            StudentName = studentName;
            MobileNo = mobileNo;
            Gender = gender;
            Email = email;
            PermanentAddress = permanentAddress;
        }

        public int StudentId { get => studentId; set => studentId = value; }
        [Required(ErrorMessage = "Student Reg no is a required field.")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Student Reg no input no special characters allowed!")]
        public string StudentRegNo { get => studentRegNo; set => studentRegNo = value; }

        [Required(ErrorMessage = "Student name is a required field.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Student name input no special characters allowed!")]
        public string StudentName { get => studentName; set => studentName = value; }

        [Required(ErrorMessage = "Student mobile no is a required field.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Student mobile no input allow only numbers!")]
        public string MobileNo { get => mobileNo; set => mobileNo = value; }

        [Required(ErrorMessage = "Student gender is a required field.")]
        public string Gender { get => gender; set => gender = value; }

        [Required(ErrorMessage = "Student email is a required field.")]
        [RegularExpression(@"^[a-zA-Z0-9@.]+$", ErrorMessage = "Student email input allow only numbers!")]
        public string Email { get => email; set => email = value; }

        [Required(ErrorMessage = "Student address is a required field.")]
        [RegularExpression(@"^[a-zA-Z0-9\s,.]+$", ErrorMessage = "Student address input no special characters allowed!")]
        public string PermanentAddress { get => permanentAddress; set => permanentAddress = value; }

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
