using System;
using System.ComponentModel.DataAnnotations;
using ZarzadzanieProjektami.Data;
using ZarzadzanieProjektami.Models;

namespace ZarzadzanieProjektami.Validators
{
    public class DateAttribute : ValidationAttribute
    {
        private readonly string _errorMessage;

        public DateAttribute(string errorMessage = "Data zadania nie może być późniejsza niż data projektu.")
        {
            _errorMessage = errorMessage;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Wartość nie może być null.");

            if (validationContext.ObjectInstance is ProjectTask task)
            {
                if (validationContext.GetService(typeof(ApplicationDbContext)) is not ApplicationDbContext dbContext)
                    throw new InvalidOperationException("Nie można uzyskać dostępu do DbContext.");

                var project = dbContext.Project.Find(task.ProjectId);

                if (project == null)
                    return new ValidationResult("Nieprawidłowy identyfikator projektu.");

                DateTime taskDeadline = (DateTime)value;
                DateTime projectDeadline = project.Deadline;

                if (taskDeadline > projectDeadline)
                    return new ValidationResult(_errorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
