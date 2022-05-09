using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectArticle1.Models;

namespace ProjectArticle1.Controllers
{
    public class CommentsController : Controller
    {


        // POST: CommentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comment comment)
        {
            return Ok();
        }


    }
}
