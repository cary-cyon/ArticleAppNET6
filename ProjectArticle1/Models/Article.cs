using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectArticle1.Models
{
    public class Article
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        public string Text { get; set; }
        public int? AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        
    }
}
