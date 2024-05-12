using System.ComponentModel.DataAnnotations;

namespace OpdrachtASP.NETCore.Models
{
    public class Info
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Message is too long.")]
        public string Message { get; set; }
    }
}
