using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormWithADO.Model
{
    public class RegistrationModel
    {

        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB  { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public  string courseID { get; set; }
    }
}