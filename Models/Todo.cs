using System.ComponentModel.DataAnnotations;
using TwTodos.Validators;

namespace TwTodos.Models
{
    public class Todo
    {
        public int Id { get; set; }
        //O título não pode ser nulo
        [Display(Name = "Título")]
        //nada intuitivo entender os valores entre {}. Para saber mais, consulte a documentação
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Data de entrega")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [FutureOrPresent]
        public DateOnly Deadline { get; set; }
        //O campo FinishedAt pode ser nulo
        public DateOnly? FinishedAt { get; set; }

        public void Finish()
        {
            FinishedAt = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}