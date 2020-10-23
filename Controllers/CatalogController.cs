
using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;
using System.Linq;

namespace PropertyRental.Controllers
{
    public class CatalogController : Controller
    {

        private DataContext dbContext;
        public CatalogController(DataContext db)
        {
            dbContext = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetProperties()
        {
            var data = dbContext.Properties.ToList(); //read records from table
            return Json(data); //return the array
        }

        [HttpDelete]

        [HttpPost]
        public IActionResult SaveProperty([FromBody] Property theProperty)
        {
            //store the property into the Db
            dbContext.Properties.Add(theProperty);
            dbContext.SaveChanges();


            theProperty.Id = 1;
            return Json(theProperty);
        }

    }
}
