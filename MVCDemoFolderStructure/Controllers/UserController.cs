using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemoFolderStructure.Models;
namespace MVCDemoFolderStructure.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult List()
        {
            List<UserModel> userList= new List<UserModel>();
            var user = new UserModel(1, "kishore", "@yash", "123", "hello", "male", "a1.png", 1);
            userList.Add(user);


            user = new UserModel(1, "ram", "kishore@", "123", "hello", "male", "a2.png", 1);
            userList.Add(user);





            return View(userList);
        }


        [HttpGet]
        public ActionResult SignUp()
        {
            UserModel userModel = new UserModel();
            userModel.StateId = new StateModel();
            SelectList countryList = new SelectList(userModel.StateId.GetCountries, "CountryId", "CountryName");
           
            SelectList stateList = new SelectList(userModel.GetStates, "StateId", "StateName");

            ViewBag.CountryDataSource = countryList;
            ViewBag.StateDataSource = stateList;
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserModel userModel)
        {
            userModel.StateId = new StateModel();
            SelectList countryList = new SelectList(userModel.StateId.GetCountries, "CountryId", "CountryName");
            SelectList stateList = new SelectList(userModel.GetStates, "StateId", "StateName");
            ViewBag.CountryId = countryList;
            ViewBag.StateId = stateList;
            return View();
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(UserModel userModel)
        {
           TempData["message"] = "sign done !";
            return RedirectToAction("SignUp");
        }
     
    }
}