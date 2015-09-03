using PhotoFundao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoFundao.Controllers
{
    public class PhotoController : Controller
    {
        //private PhotoFundaoContext context;

        // GET: Photo
        public ActionResult Index()
        {
            var photos = new Photo();

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Photo photo, HttpPostedFileBase uploadedFile)
        {
            return View();
        }
    }
}