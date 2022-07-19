using MVC_AJAX_Form.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static MVC_AJAX_Form.Models.Users;

namespace MVC_AJAX_Form.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }





        public ActionResult AJAX_Form()
        {
            return View();
        }

        public ActionResult Form1(Form1 form)
        {
            if (ModelState.IsValid)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
                string sql = "insert into UserDetails(UserName, UserMobile, UserEmail, FormName) values('" + form.UserName1 + "', '" + form.UserMobile1 + "', '" + form.UserEmail1 + "', 'Form1'); select scope_identity();";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                form.UserID1 = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return Json(form);
            }
            return View("AJAX_Form");
        }

        public JsonResult Form2(Form2 form)
        {
            if (ModelState.IsValid)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
                string sql = "insert into UserDetails(UserName, UserMobile, UserEmail, FormName) values('" + form.UserName2 + "', '" + form.UserMobile2 + "', '" + form.UserEmail2 + "', 'Form2'), select scope_identity();";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                form.UserID2 = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return Json(form);
            }
            return Json("Error");
        }
    }
}