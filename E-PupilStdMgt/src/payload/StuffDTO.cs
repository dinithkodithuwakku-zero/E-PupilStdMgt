using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_PupilStdMgt.src.payload
{
    class StuffDTO
    {
        private int stuffId;
        private string userName;
        private string password;
        private string fullName;
        private string nic;
        private string jobTitle;
        private string mobileNo;
        private string email;
        private string permanentAddress;

        public StuffDTO() { }
        public StuffDTO(int stuffId, string userName, string password, string fullName, string nic, string jobTitle, string mobileNo, string email, string permanentAddress)
        {
            this.stuffId = stuffId;
            this.userName = userName;
            this.password = password;
            this.fullName = fullName;
            this.nic = nic;
            this.jobTitle = jobTitle;
            this.mobileNo = mobileNo;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public StuffDTO(int stuffId, string fullName, string nic, string jobTitle, string mobileNo, string email, string permanentAddress)
        {
            this.stuffId = stuffId;
            this.fullName = fullName;
            this.nic = nic;
            this.jobTitle = jobTitle;
            this.mobileNo = mobileNo;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public StuffDTO(int stuffId, string userName, string fullName, string nic, string jobTitle, string mobileNo, string email, string permanentAddress)
        {
            this.stuffId = stuffId;
            this.userName = userName;
            this.fullName = fullName;
            this.nic = nic;
            this.jobTitle = jobTitle;
            this.mobileNo = mobileNo;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public StuffDTO(string userName, string password, string fullName, string nic, string jobTitle, string mobileNo, string email, string permanentAddress)
        {
            this.userName = userName;
            this.password = password;
            this.fullName = fullName;
            this.nic = nic;
            this.jobTitle = jobTitle;
            this.mobileNo = mobileNo;
            this.email = email;
            this.permanentAddress = permanentAddress;
        }

        public int StuffId { get => stuffId; set => stuffId = value; }

        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "User name input no special characters allowed!")]
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        [Required(ErrorMessage = "Full name is a required field.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Full name input no special characters allowed!")]
        public string FullName { get => fullName; set => fullName = value; }

        [Required(ErrorMessage = "NIC is a required field.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "NIC input allow only numbers!")]
        public string Nic { get => nic; set => nic = value; }

        [Required(ErrorMessage = "Job type is a required.")]
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        [Required(ErrorMessage = "Mobile no is a required field.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Mobile no input allow only numbers!")]
        public string MobileNo { get => mobileNo; set => mobileNo = value; }

        [Required(ErrorMessage = "Email is a required field.")]
        [RegularExpression(@"^[a-zA-Z0-9@.]+$", ErrorMessage = "Email input allow only numbers!")]
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
