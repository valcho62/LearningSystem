using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Models.View.Account
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}