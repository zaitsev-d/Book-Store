using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order
    {
        [BindNever]
        public int ID { get; set; }
        
        [Display(Name = "Name:")]
        [StringLength(15)]
        [Required(ErrorMessage = "Name length not less 15 symbols.")]
        public string Name { get; set; }

        [Display(Name = "Surname:")]
        [StringLength(15)]
        [Required(ErrorMessage = "Surname length not less 15 symbols.")]
        public string Surname { get; set; }

        [Display(Name = "Adress:")]
        [StringLength(30)]
        [Required(ErrorMessage = "Adress length not less 30 symbols.")]
        public string Adress { get; set; }

        [Display(Name = "Phone:")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Phone length not less 10 symbols.")]
        public string Phone { get; set; }

        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress)]
        [StringLength(15)]
        [Required(ErrorMessage = "Email length not less 15 symbols.")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
