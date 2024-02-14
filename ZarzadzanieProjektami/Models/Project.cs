using System.ComponentModel.DataAnnotations;
using ZarzadzanieProjektami.Validators;

namespace ZarzadzanieProjektami.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        [StringLength(20, ErrorMessage = "Długość tytułu musi być krótsza lub równa {0} znaków.")]
        [Display(Name = "Tytuł")]
        public string Name { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        [StringLength(100, ErrorMessage = "Długość opisu musi być krótsza lub równa {0} znaków.")]
        [Display(Name = "Opis")]
        public string Description { get; set; }
        [Date]
        [Display(Name = "Termin ostateczny")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime Deadline { get; set; }
    }
}
