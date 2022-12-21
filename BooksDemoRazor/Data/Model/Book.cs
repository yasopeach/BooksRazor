using System.ComponentModel.DataAnnotations;

namespace BooksDemoRazor.Data.Model
{
    public class Book
    {
        [Key]  
        public int Id { get; set; }
        [Required]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; }

        [Required]
        [Range(2000, 2022, ErrorMessage ="2000-2022 Arasında bir değer giriniz")]
        [Display(Name = "Yayınlanma Tarihi")]
        public int PublishedYear { get; set; }
    }
}
