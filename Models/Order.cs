using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace MyWebSiteMVC.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Must introduce the name")]
        [StringLength(30, ErrorMessage = "Too long name, max 30 characters")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Must introduce the surname")]
        [StringLength(50, ErrorMessage = "Too long surname, max 50 characters")]
        public string Surname { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Must introduce the address")]
        [StringLength(100, ErrorMessage = "Too long address, max 100 characters")]
        public string Address { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Must introduce the phone")]
        [StringLength(50, ErrorMessage = "Too long phone, max 50 characters")]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Must introduce the email")]
        [StringLength(50, ErrorMessage = "Too long name, max 50 characters")]
        [EmailAddress(ErrorMessage = "You must introduce a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Your cart is empty")]
        public string Cart { get; set; }
    }
}
