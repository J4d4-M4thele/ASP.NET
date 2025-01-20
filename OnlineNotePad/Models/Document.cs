using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineNotePad.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //user must be authenticated to create a document
        [Required]
        public string? UserId { get; set; }
        //links user to documents they create
        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }
    }
}
