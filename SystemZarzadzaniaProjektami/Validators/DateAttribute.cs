using System.ComponentModel.DataAnnotations;
using SystemZarzadzaniaProjektami.Data;
using SystemZarzadzaniaProjektami.Models;

namespace SystemZarzadzaniaProjektami.Validators
{
    public class DateAttribute(string ErrorMessage = "Data zadania nie może być późniejsza niż data projektu.") : ValidationAttribute
    {
        public new string ErrorMessage { get; } = ErrorMessage;
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Wartość nie może być null.");

            var task = (ProjectTask)validationContext.ObjectInstance;

            if (validationContext.GetService(typeof(ApplicationDbContext)) is not ApplicationDbContext dbContext)
                throw new InvalidOperationException("Nie można uzyskać dostępu do DbContext.");

            var project = dbContext.Project.Find(task.ProjectId);

            if (project == null)
                return new ValidationResult("Nieprawidłowy identyfikator projektu.");

            DateTime tDeadline = (DateTime)value;
            DateTime projectDeadline = project.Deadline;

            if (tDeadline > projectDeadline)
                return new ValidationResult(ErrorMessage);

            return ValidationResult.Success;
        }

    }
}
