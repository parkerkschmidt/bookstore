using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace bookstore.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a first name: ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name: ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please the first address line: ")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter the city: ")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the state: ")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter the zip: ")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter the country: ")]
        public string Country { get; set; }

    }
}
