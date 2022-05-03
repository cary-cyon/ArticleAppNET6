namespace ProjectArticle1.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Article> Articles { get; set; }


    }
}
