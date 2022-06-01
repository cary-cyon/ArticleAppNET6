using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectArticle1.Models;

namespace ProjectArticle1.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ArticleAppContext _context;
        public CommentsController(ArticleAppContext context)
        {
            _context = context;
        }


        // POST: CommentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Comment comment)
        {
            _context.Add(comment);
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}
