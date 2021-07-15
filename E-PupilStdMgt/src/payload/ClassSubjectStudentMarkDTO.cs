using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace E_PupilStdMgt.src.payload
{
    class ClassSubjectStudentMarkDTO
    {
        private int classSubjectStudentMarkId;
        private ClassSubjectDTO classSubjectDTO;
        private StudentDTO studentDTO;
        private DateTime examDate;
        private double studentPoint;

        public ClassSubjectStudentMarkDTO()
        {
        }

        public ClassSubjectStudentMarkDTO(int classSubjectStudentMarkId, ClassSubjectDTO classSubjectDTO, StudentDTO studentDTO, DateTime examDate, double studentPoint)
        {
            this.classSubjectStudentMarkId = classSubjectStudentMarkId;
            this.classSubjectDTO = classSubjectDTO;
            this.studentDTO = studentDTO;
            this.examDate = examDate;
            this.studentPoint = studentPoint;
        }

        public int ClassSubjectStudentMarkId { get => classSubjectStudentMarkId; set => classSubjectStudentMarkId = value; }
        public DateTime ExamDate { get => examDate; set => examDate = value; }

        [Required(ErrorMessage = "Student point is a required field.")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Student mobile no input allow only numbers!")]
        public double StudentPoint { get => studentPoint; set => studentPoint = value; }
        internal ClassSubjectDTO ClassSubjectDTO { get => classSubjectDTO; set => classSubjectDTO = value; }
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
