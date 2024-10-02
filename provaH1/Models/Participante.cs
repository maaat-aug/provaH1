using provaH1.Validation;
using System.ComponentModel.DataAnnotations;

namespace provaH1.Models
{
    public class Participante
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O Nome deve ter no mínimo 3 caracteres")]
        [MaxLength(255, ErrorMessage = "O Nome deve ter no máximo 255 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Descrição de o que você irá levar de carne é obrigatória")]
        public string descricaoCarne { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Idade é obrigatória")]
        [IdadeValidation(ErrorMessage = "A idade não pode ser menor que 18")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "A Descrição de o que você irá levar de bebida é obrigatória")]
        public string descricaoBebida { get; set; } = string.Empty;
    }
}
