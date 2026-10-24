using System.ComponentModel.DataAnnotations;

namespace FeedbackManagement.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter student name.")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please enter enrollment number.")]
        public string EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a rating.")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "Please enter comments.")]
        [StringLength(500, MinimumLength = 10,
            ErrorMessage = "Comments must be 10 to 500 characters.")]
        public string Comments { get; set; }
    }
}

