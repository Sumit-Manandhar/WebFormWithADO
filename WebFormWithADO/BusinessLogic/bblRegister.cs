using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormWithADO.Model;

namespace WebFormWithADO.BusinessLogic
{
    public class bblRegister
    {
        public static List<RegistrationModel> register = new List<RegistrationModel>()
        {
            new RegistrationModel()
            {
                id=1,
                FirstName="john ",
                LastName="terry",
                DOB=DateTime.Now,
                Email="test@gmail.com",
                password="test123"

                
            } };
    }
}