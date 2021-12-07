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
        List<CallRecordingModel> GetAllCallRecordings(string CustomerId);
        CustomerModel Register(CustomerModel customer);
        bool CreateMenuAccess(string CustomerId, string CustomerType);
        void DeleteCustomer(string CustomerId);
        bool ForgotPassword(string Email);
        bool ResetPassword(CustomerModel customer);
        bool CreateTrialBalanceCustomers(string CustomerId);
        List<SubscriptionModel> GetSubscriptionList(string CustomerId);
        
    }
}
