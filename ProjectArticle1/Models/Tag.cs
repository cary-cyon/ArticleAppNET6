namespace ProjectArticle1.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public LinkedList<Article> Articles { get; set; }
    }
}
