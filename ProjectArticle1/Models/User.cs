using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectArticle1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAuthor { get; set; }
        public int? AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author? Author { get; set; }


    }
}
