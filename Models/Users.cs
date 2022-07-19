using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_AJAX_Form.Models
{
    public class Users
    {
        public class Form1
        {
            public int UserID1 { get; set; }

            [Required(ErrorMessage = "Please enter user name!")]
            [Display(Name = "User Name :")]
            public string UserName1 { get; set; }

            [Required(ErrorMessage = "Please enter mobile number!")]
            [Display(Name = "Mobile Number :")]
            public string UserMobile1 { get; set; }

            [Required(ErrorMessage = "Please enter Email ID!")]
            [Display(Name = "Email ID :")]
            public string UserEmail1 { get; set; }
        }

        public class Form2
        {
            public int UserID2 { get; set; }

            [Required(ErrorMessage = "Please enter user name!")]
            [Display(Name = "User Name :")]
            public string UserName2 { get; set; }

            [Required(ErrorMessage = "Please enter mobile number!")]
            [Display(Name = "Mobile Number :")]
            public string UserMobile2 { get; set; }

            [Required(ErrorMessage = "Please enter Email ID!")]
            [Display(Name = "Email ID :")]
            public string UserEmail2 { get; set; }
        }


        public Form1 form1 { get; set; }
        public Form2 form2 { get; set; }
    }
}