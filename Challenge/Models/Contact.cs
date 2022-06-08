using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.Models
{
    [Table("Contact")]
    public class Contact
    {
        public int ContactID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int Address { get; set; }

        //navigation property
        public virtual Addresses Addresses{ get; set; }
    }

    [Table("Address")]
    public class Addresses
    {
        [Key]
        public int AddressID { get; set; } 
        public int Address { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Postal Code")]
        public int PostalCode { get; set; }

        //navigation property
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}