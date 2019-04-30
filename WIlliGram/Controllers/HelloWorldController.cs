using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace WIlliGram.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

         

        public IActionResult Friends(string name = "Yer Twat", int numFriends = 0, int numTimes=0)
        {
            string numFriendsString = (numFriends > 0) ? numFriends.ToString() : "no";
            ViewData["Message"] = "Hello " + name;
            ViewData["NumFriends"] = numFriendsString;
            ViewData["NumTimes"] = numTimes;

           return View();
        }
    }
}