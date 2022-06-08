using Challenge.Models;
using System.Collections.Generic;


namespace Challenge.DataAccessLayer
{
    public class ContactInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContactContext>
    {
        protected override void Seed(ContactContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact{FirstName = "Lewis", LastName = "DeJesus", Address= 200},
                new Contact{FirstName = "Johnnie", LastName = "Smith", Address = 200}
            };

            contacts.ForEach(c => context.Contacts.Add(c));
            context.SaveChanges();


            var address = new List<Addresses>
            {
                new Addresses{ Address = 200, Street = "Merritts Rd", City = "Farmingdale", State = "New York", PostalCode = 11735},
                new Addresses{ Address = 200, Street = "Merritts Rd", City = "Massapequa", State = "New York", PostalCode = 11758}
            };

            address.ForEach(c => context.Addresses.Add(c));
            context.SaveChanges();

        }
    }
}