using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Inventory.Models;

namespace Inventory.Controllers
{
  public class CollectionsController : Controller
  {
    private readonly InventoryContext _db;

    public CollectionsController (InventoryContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
      List<Collection> model = _db.Collections.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Collection collection)
    {
        _db.Collections.Add(collection);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        Collection thisCollection = _db.Collections.FirstOrDefault(collections => collections.Id == id);
        return View(thisCollection);
    }

    public ActionResult Delete(int id)
    {
        var thisCollection = _db.Collections.FirstOrDefault(collections => collections.Id == id);
        return View(thisCollection);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisCollection = _db.Collections.FirstOrDefault(collections => collections.Id == id);
        _db.Collections.Remove(thisCollection);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}