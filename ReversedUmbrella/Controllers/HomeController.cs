using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace ReversedUmbrella.Controllers
{
    
    public class HomeController : Controller
    {
        SqlConnection db = new SqlConnection("");
       
        public ActionResult Index()
        {
            ;
            return View();
        }
        

    }
}