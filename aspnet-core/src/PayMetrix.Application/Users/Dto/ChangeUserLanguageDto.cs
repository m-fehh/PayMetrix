using System.ComponentModel.DataAnnotations;

namespace PayMetrix.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}