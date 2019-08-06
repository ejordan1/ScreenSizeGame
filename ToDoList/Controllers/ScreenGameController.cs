using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ScreenGameController : Controller{

    private readonly ToDoListContext _db;

    public ScreenGameController(ToDoListContext db)
    {
      _db = db;
    }
    
    public ActionResult Create(){
        return View();
    }

    [HttpPost("Screengame/Create")]
    public ActionResult Create(Item item){
        Console.WriteLine("GOT TO CREATE");
        Console.WriteLine(item.Width);
        item.CategoryId = (14);
        _db.Items.Add(item);
        _db.SaveChanges();
        return View();
    }
}