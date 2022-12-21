using BooksDemoRazor.Data.Acces;
using BooksDemoRazor.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksDemoRazor.Pages.Books
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Book> Books { get; set; }
        private AppDbContext _context;

        public IndexModel(AppDbContext db)
        {
            _context = db;
            Books = _context.Books;
        }

        public void OnGet()
        {
            
        }
    }
}
