﻿using Calendar.DataLayer;
using Calendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.BusinessLayer
{
    public class BusinessDash : IBusinessDash
    {

        IRepositoryDash _irep = null;

        public BusinessDash() : this(new Repository())
        {

        }
         
        public BusinessDash(IRepositoryDash irep)
        {
            _irep = irep;
        }

        public List<Employee> employees()
        {
            List<Employee> e = new List<Employee>();
            e = _irep.GetEmployees();

            return e;
        }
    }
}