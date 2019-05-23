using System.ComponentModel.DataAnnotations;

namespace supplyc.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}