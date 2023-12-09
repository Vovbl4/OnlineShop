using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace MyWebSiteMVC.Models
{
    public class Blog
    {
        [Key]
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Must introduce the title")]
        [StringLength(30, ErrorMessage = "Too long title, max 30 characters")]
        public string Title { get; set; }

        [Display(Name = "Anons")]
        [Required(ErrorMessage = "Must introduce the anons")]
        [StringLength(100, ErrorMessage = "Too long anons, max 100 characters")]
        public string Anons { get; set; }

        [Display(Name = "Anons full text")]
        [Required(ErrorMessage = "Must introduce the Anons full text")]
        [StringLength(1000, ErrorMessage = "Too long anons text, max 1000 characters")]
        public string FullText { get; set; }
    }
}
