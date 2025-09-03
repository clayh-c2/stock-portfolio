using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CreateCommentRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters long.")]
        [MaxLength(50, ErrorMessage = "Title cannot be longer than 50 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(280, ErrorMessage = "Content cannot be longer than 280 characters.")]
        public string Content { get; set; } = string.Empty;
    }
}