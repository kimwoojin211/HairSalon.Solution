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
    private List<SelectListItem> _selectList;

    public HomeController(HairSalonContext db)
    {
      _db = db;
      _selectList = new List<SelectListItem>()
      { 
        new SelectListItem {Text = "All", Value = "All"},
        new SelectListItem {Text = "Stylist", Value = "Stylist"},
        new SelectListItem {Text = "Client", Value = "Client"}
      };
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    
    public ActionResult Search()
    {
      ViewBag.Category = _selectList;
      return View();
    }

    [HttpPost]
    public ActionResult Search(string category, string name)
    {
      System.Console.WriteLine(category + " " + name);
      ViewBag.Category = _selectList;
      List<Stylist> stylistSearch = new List<Stylist>{};
      List<Client> clientSearch = new List<Client> {};
      if(category != "Client")
      {
        stylistSearch = _db.Stylists.Where(Stylist => Stylist.Name.Contains(name)).ToList();
      }
      if(category != "Stylist")
      {
        clientSearch = _db.Clients.Where(Client => Client.Name.Contains(name)).ToList();
      }
      Dictionary<string,List<object>> model = new Dictionary(){StylistResults = stylistSearch, ClientResults = clientSearch};
      model.Add("StylistResults",stylistSearch);
      System.Console.WriteLine(model.StylistResults.Count);
      return View(model); //model gets lost between here and View. or. something. idk. 
    }

  }
}

// version 1: have homecontroller have post to its own search page
// version 2: redirect to client or stylist search page based on choice.