using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookChain.Models
{
    public class Book
    {
        // Unique Key
        [Key]
        public int Id { get; set; }

        // Book Details
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        // Store Classification
        [Range(0.0, 10.0, ErrorMessage = "Rating must be between 0 and 10")]
        public float Rating { get; set; } = 0;
        public string Genre { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Age can't be negative")]
        public int AgeRangeMin { get; set; } = 0;
        [Range(0, int.MaxValue, ErrorMessage = "Age can't be negative")]
        public int AgeRangeMax { get; set; } = 120;

        // Store Managment
        [Range(0, int.MaxValue, ErrorMessage = "Only positive price allowed")]
        public int Price { get; set; } = 0;
        [Range(0, int.MaxValue, ErrorMessage = "Only positive quantity allowed")]
        public int Quantity { get; set; } = 0;
    }
}
