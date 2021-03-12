using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _db;

    public HomeController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Search()
    {
      ViewBag.Category = new SelectList(new List<SelectListItem>
          {
            new SelectListItem {Text = "Stylist", Value = "Stylist"},
            new SelectListItem {Text = "Client", Value = "Client"}
          }, "Stylist or Client?");
      return View();
    }

    [HttpPost]
    public ActionResult Search(Stylist temp)
    {
      if(temp.Specialty == "Stylist")
      {
        List<Stylist> searchResults = _db.Stylists.Where(Stylist => Stylist.Name == temp.Name);
      }
      else
      {
        List<Client> searchResults = _db.Clients.Where(Stylist => Stylist.Name == temp.Name);
      }
      
      return RedirectToAction("Results", searchResults);
      // List<Stylist> searchResults = new List<Stylist>{};
      // foreach(Stylist stylist in _db.Stylists)
      // {
      //   if(stylist.Name == name)
      //   {
      //     searchResults.Add(stylist);
      //   }
      // }
    }
  }
}