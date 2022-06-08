using Challenge.DataAccessLayer;
using Challenge.Models;
using Challenge.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Challenge.Controllers
{
    public class ContactInfoController : Controller
    {
        private readonly ContactContext db = new ContactContext();

        // GET: ContactInfo
        public ActionResult Index(/*string option, string search*/)
        {
           
            List<Contact> contacts1 = db.Contacts.ToList();
            List<Addresses> addresses1 = db.Addresses.ToList();

            var multitable = from c in contacts1
                             join ad in addresses1 on c.Address equals ad.Address into table1
                             from ad in table1.DefaultIfEmpty()
                             select new ContactInfo { Contacts = c, Addresses = ad };


           return View(multitable);
        }

    }
}