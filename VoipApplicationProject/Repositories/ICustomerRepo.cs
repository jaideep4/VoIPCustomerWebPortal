﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoipApplicationProject.Models;

namespace VoipApplicationProject.Repositories
{
    public interface ICustomerRepo
    {
        //int GetEnumValue(string Type);
        CustomerModel IsAuthenticated(CustomerModel customer);
        List<CustomerModel> GetAllCustomers();
        string ValidateEmail(string Email);
        string Register(CustomerModel customer);
        CustomerModel GetCustomerById(string CustomerId);
        bool CreateMenuAccess(string CustomerId);
        void DeleteCustomer(string email);
    }
}
