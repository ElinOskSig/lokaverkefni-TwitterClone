using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TwitterClone10.Data.TwitterClone_Elin.Data;
using TwitterClone10.Models.TwitterClone_Elin.Models;

namespace TwitterClone10.Pages.Posts
{
    public class CreateModel : PageModel
    {
        private readonly BloggingContext _db;
        [BindProperty]
        public Post Post { get; set; }

        public CreateModel(BloggingContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost(Post post)
        {
            _db.Post.AddAsync(post);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
