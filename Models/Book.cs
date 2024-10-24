using System.ComponentModel.DataAnnotations;

namespace Boekenbibliotheek.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ISBN is required.")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "ISBN must be between 10 and 13 characters.")]
        public string ISBN { get; set; } = string.Empty; // Ensure it has a default value

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; } = string.Empty; // Ensure it has a default value

        [Required(ErrorMessage = "Author is required.")]
        public string Author { get; set; } = string.Empty; // Ensure it has a default value

        [Required(ErrorMessage = "Publication year is required.")]
        [Range(1000, 9999, ErrorMessage = "Please enter a valid year between 1000 and 9999.")]
        public int PublicationYear { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; } = string.Empty; // Ensure it has a default value

        [Range(0, int.MaxValue, ErrorMessage = "Available copies must be a non-negative integer.")]
        public int AvailableCopies { get; set; }
    }
}
