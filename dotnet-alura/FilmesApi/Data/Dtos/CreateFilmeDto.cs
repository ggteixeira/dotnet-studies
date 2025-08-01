using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    // [Key] [Required] public int Id { get; set; }

    [Required(ErrorMessage = "O título do filme é obrigatório!")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório!")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres!")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatória!")]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70min e 600min")]
    public int Duracao { get; set; }
}