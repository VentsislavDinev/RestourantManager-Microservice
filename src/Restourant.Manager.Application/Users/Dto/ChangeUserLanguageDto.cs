using System.ComponentModel.DataAnnotations;

namespace Restourant.Manager.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}