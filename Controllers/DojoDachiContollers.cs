using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DojoDachi.Controllers
{
    public class DojoDachiController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            TempData["gamestatus"] = "playing";
            int? fulness = HttpContext.Session.GetInt32("fulness");
            if ( fulness == null)
            {
                HttpContext.Session.SetInt32("happines" , 20);
                HttpContext.Session.SetInt32("fulness" , 20);
                HttpContext.Session.SetInt32("energy" , 50);
                HttpContext.Session.SetInt32("meals" , 3);
                TempData["message"] = "this is your new pet ,Let's start to play";

            }
            int? happines = HttpContext.Session.GetInt32("happines");
            int? energy = HttpContext.Session.GetInt32("energy");
            int? meals = HttpContext.Session.GetInt32("meals");

            if(fulness == 0 || happines == 0)
            {
              TempData["gamestatus"] = "over";
              TempData["message"] = "Game Over! your DojoDachi die(((";
            }
            if (fulness >= 100 && happines >= 100 && energy >=100)
            {
                TempData["gamestatus"] = "over";
                TempData["message"] = "Game Over! You win , you Dojodachi the happiest in the world!))";
            }

            TempData["happines"] = happines;
            TempData["fulness"] = fulness;
            TempData["energy"] = energy;
            TempData["meals"] = meals;
            return View();
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            if(HttpContext.Session.GetInt32("meals") == 0 )
            {
              TempData["message"] = "You don't have any meals to feed your pet";
              return RedirectToAction ("Index");
            }
            else
            {
                Random rand= new Random();
                int like = rand.Next(1,5);
                if(like ==1)
                {
                    int? meals =HttpContext.Session.GetInt32("meals") - 1;
                    HttpContext.Session.SetInt32("meals" , (int)meals);
                    TempData["message"] = "Your Pet doesn't like this food";
                }
                else
                {
                    int? meals =HttpContext.Session.GetInt32("meals") - 1;
                    HttpContext.Session.SetInt32("meals" , (int)meals);
                    Random plus = new Random();
                    int fill = rand.Next(5,11);
                    int? fulness = HttpContext.Session.GetInt32("fulness") + fill;
                    HttpContext.Session.SetInt32("fulness" , (int)fulness);
                    TempData["message"] = $"Yor Pet said that the food was Amazing! Fulness increase by {fill}";
                }
                return RedirectToAction ("Index");
            }
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            if(HttpContext.Session.GetInt32("energy") == 0 )
            {
              TempData["message"] = "You DojoDachi tired he cannot play anymore";
              return RedirectToAction ("Index");
            }
            else
            {
                Random rand= new Random();
                int like = rand.Next(1,5);
                if(like == 1)
                {
                    int? energy = HttpContext.Session.GetInt32("energy") - 5;
                    HttpContext.Session.SetInt32("energy" ,(int)energy);
                    TempData["message"] = "Your Pet doesn't like this game";
                }
                else
                {
                    Random plus = new Random();
                    int happy = rand.Next(5,11);
                    int? energy = HttpContext.Session.GetInt32("energy") - 5;
                    HttpContext.Session.SetInt32("energy" ,(int)energy);
                    int? happines = HttpContext.Session.GetInt32("happines") + happy;
                    HttpContext.Session.SetInt32("happines" , (int)happines);
                    TempData["message"] = $"Yor Pet said that this game was Awesome! Happiness increase by {happy}";
                }
                return RedirectToAction("Index");
            }

        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            if(HttpContext.Session.GetInt32("energy") == 0 )
            {
              TempData["message"] = "You DojoDachi tired he cannot work anymore";
              return RedirectToAction ("Index");
            }
            else
            {
                Random rand= new Random();
                int meal = rand.Next(1,4);
                int? energy = HttpContext.Session.GetInt32("energy") - 5;
                HttpContext.Session.SetInt32("energy" ,(int)energy);
                int? meals = HttpContext.Session.GetInt32("meals") + meal;
                HttpContext.Session.SetInt32("meals" , (int)meals);
                TempData["message"] = $"Pet was working hard  and earned {meal} meals for you";
                return RedirectToAction("Index");
            }
        }
    }
}