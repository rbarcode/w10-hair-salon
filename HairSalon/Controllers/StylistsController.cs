using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists
                                .Include(stylists => stylists.Clients)
                                .FirstOrDefault(stylists => stylists.StylistId == id);
      if (thisStylist.PhoneNumber == null)
      {
        ViewBag.FormattedPhoneNum = "No number on file";
      }
      else
      {
        string areaCode = thisStylist.PhoneNumber[..3];
        string telPrefix = thisStylist.PhoneNumber.Substring(3, 3);
        string lineNum = thisStylist.PhoneNumber[6..];
        ViewBag.FormattedPhoneNum = $"({areaCode}) {telPrefix}-{lineNum}";
      }
      return View(thisStylist);
    }
  }
}