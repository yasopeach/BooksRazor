using BooksDemoRazor.Data.Acces;
using BooksDemoRazor.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksDemoRazor.Pages.Books
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Book? Book { get; set; }

        private AppDbContext _db;
        public EditModel(AppDbContext db)
        {
            _db = db;

        }
        public void OnGet(int id)
        {
            Book = _db.Books.Find(id);
            //Book = _db.Books.FirstOrDefault(b => b.Id == id);
            //Book = _db.Books.SingleOrDefault(b => b.Id == id);
            //Book = _db.Books.Where(b => b.Id == id).FirstOrDefault();
        }

        public IActionResult OnPost(Book book)
        {
            //
            _db.Books.Update(book);
            _db.SaveChanges();
            TempData["basariliKayitGuncelleme"] = "Kayýt Güncellendi!";

            return RedirectToPage("Index");
        }
    }
}
