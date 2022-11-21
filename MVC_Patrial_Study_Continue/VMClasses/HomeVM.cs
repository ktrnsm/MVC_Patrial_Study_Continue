using MVC_Patrial_Study_Continue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Patrial_Study_Continue.VMClasses
{
    public class HomeVM
    {
        public List<Employee> Employees { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }


    }
}