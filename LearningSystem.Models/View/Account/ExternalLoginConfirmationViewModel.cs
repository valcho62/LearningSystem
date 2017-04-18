using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Web.Models.View.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}