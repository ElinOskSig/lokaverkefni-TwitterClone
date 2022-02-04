namespace TwitterClone10.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace TwitterClone_Elin.Models
    {
        public class Post
        {
            [Key]

            public int? Id { get; set; }
            [Required]
            public string? Content { get; set; }


        }
    }
}