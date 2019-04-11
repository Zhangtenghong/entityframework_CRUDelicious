using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using delicious.Models;

namespace delicious.Controllers
{
    public class HomeController : Controller
    {
        private DeliciousContext dbContext;
        public HomeController(DeliciousContext context){
            dbContext=context;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            return View("index", AllDishes);
        }

        [Route("new")]
        [HttpGet]
        public IActionResult Add()
        {
            return View("add");
        }

        [Route("new/create")]
        [HttpPost]
        public IActionResult Create(Dish newDish)
        {
            dbContext.Add(newDish);
            dbContext.SaveChanges();
            return RedirectToAction("index");
        } 
        
        [Route("{Id}")]
        [HttpGet]
        public IActionResult Show(int Id)
        {
            Dish oneDish = dbContext.Dishes.FirstOrDefault(d => d.DishId==Id);
            return View("show", oneDish);
        }

        [Route("delete/{Id}")]
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Dish deleteDish = dbContext.Dishes.FirstOrDefault(d => d.DishId==Id);
            System.Console.WriteLine("Delete");
            dbContext.Dishes.Remove(deleteDish);
            dbContext.SaveChanges();
            return RedirectToAction("index");
        }

        [Route("edit/{Id}")]
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Dish editDish = dbContext.Dishes.FirstOrDefault(d => d.DishId==Id);
            System.Console.WriteLine(editDish.Description);
            return View("Edit", editDish);
        }

        [Route("/update/{Id}")]
        [HttpPost]
        public IActionResult Update(Dish editedDish, int Id)
        {
            Dish toEdit = dbContext.Dishes.FirstOrDefault(d => d.DishId==Id);
            toEdit.Name = editedDish.Name;
            toEdit.Chef = editedDish.Chef;
            toEdit.Tastiness = editedDish.Tastiness;
            toEdit.Calories = editedDish.Calories;
            toEdit.Description = editedDish.Description;
            toEdit.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();
            return RedirectToAction("Show",Id);
        }
    }
}
