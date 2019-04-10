using System.ComponentModel.DataAnnotations;

namespace YunTu.Lpw.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}