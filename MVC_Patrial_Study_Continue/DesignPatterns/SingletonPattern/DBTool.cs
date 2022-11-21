using MVC_Patrial_Study_Continue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Patrial_Study_Continue.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }
        static NorthwindEntities _dbInstance;
        public static NorthwindEntities DBInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new NorthwindEntities();
                return _dbInstance;
            }
        }

    }




}