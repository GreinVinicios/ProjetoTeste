using System.ComponentModel.DataAnnotations;

namespace ProjetoTeste.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}