using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TwitterClone10.Data.TwitterClone_Elin.Data;
using TwitterClone10.Models.TwitterClone_Elin.Models;

namespace TwitterClone10.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BloggingContext _db;
        [BindProperty]

        public Post Post { get; set; }
        public DbSet<Post> Posts { get; private set; }

        public IndexModel(BloggingContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Posts = _db.Post;
        }

        public async Task<IActionResult> OnPost(Post post)
        {
            _db.Post.AddAsync(post);
            await _db.SaveChangesAsync();
            return RedirectToAction("Posts");
        }


    }
}
