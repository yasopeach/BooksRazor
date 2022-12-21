using BooksDemoRazor.Data.Acces;
using BooksDemoRazor.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksDemoRazor.Pages.Books
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Book? Book { get; set; }
        private AppDbContext _db;


        public CreateModel(AppDbContext db)
        {
            _db = db;

        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

            //veritaban� insert
            _db.Books.Add(Book);
            _db.SaveChanges();

            TempData["basariliKayitGiris"] = "Kitap kay�t giri�i yap�ld�!";
             return RedirectToPage("index");
            }

            return Page();
        }
    }
}
