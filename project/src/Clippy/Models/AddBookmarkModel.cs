using System.ComponentModel.DataAnnotations;

namespace Clippy.Models
{
    public class AddBookmarkModel
    {
        [Required]
        public string Location { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Tags { get; set; }
        
        public int UserId { get; set; }
    }
}