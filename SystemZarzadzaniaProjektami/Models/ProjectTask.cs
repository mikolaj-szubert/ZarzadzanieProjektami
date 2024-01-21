using System.ComponentModel.DataAnnotations;
using SystemZarzadzaniaProjektami.Validators;

namespace SystemZarzadzaniaProjektami.Models
{
    public class ProjectTask
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Tytuł")]
        [StringLength(20, ErrorMessage = "Długość tytułu musi być krótsza lub równa {0} znaków.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Projekt")]
        public int ProjectId { get; set; }
        [Display(Name = "Projekt")]
        public virtual Project? Project { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        [Display(Name = "Postęp")]
        public string Progress { get; set; }
        [Date]
        [Display(Name = "Termin ostateczny")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime Deadline { get; set; }
    }
}
