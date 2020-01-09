using System;
using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
    public class PlacesController : Controller
    {
        //ListPlace list = new ListPlace();

        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> placesList = Place.getAllPlaces();
            return View(placesList);
            
            //return View(list.toStirng());
        }
        [HttpGet("/places/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Index(string cityname, string picturelink, string journal, int lengthofstay)
        {
            Place myplaces = new Place(cityname, 
             picturelink, journal, lengthofstay);
         

            return RedirectToAction("Index");
        }

        [HttpPost("/places/delete")]
        public ActionResult Delete()
        {
            Place.clearAllPlaces();
            return View();
        }

        [HttpGet("/places/show")]
        public ActionResult Show(int findId)
        {
            Place findPlace = Place.Find(findId);
            return View(findPlace);
        }

       
    }
}