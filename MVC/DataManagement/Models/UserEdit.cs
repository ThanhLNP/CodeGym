using System.ComponentModel.DataAnnotations;

namespace DataManagement.Models
{
    public class UserEdit
    {
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Phone(ErrorMessage = "Invalid Phone number")]
        public string UserMobile { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string UserEmail { get; set; }

        [Url(ErrorMessage = "Invalid url")]
        public string FaceBookUrl { get; set; }

        [Url(ErrorMessage = "Invalid url")]
        public string LinkedInUrl { get; set; }

        [Url(ErrorMessage = "Invalid url")]
        public string TwitterUrl { get; set; }

        [Url(ErrorMessage = "Invalid url")]
        public string PersonalWebUrl { get; set; }
    }
}
