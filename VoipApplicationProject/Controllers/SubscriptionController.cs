﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoipApplicationProject.Models;
using VoipApplicationProject.Repositories;

namespace VoipApplicationProject.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionRepo repo;
        public SubscriptionController(ISubscriptionRepo _repo)
        {
            repo = _repo;
        }
        [HttpGet]
        public IActionResult Payment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Payment(PaymentModel paymentModel)
        {
            string customerId = GetCookie("CustomerId");

            if (ModelState.IsValid)
            {
                return RedirectToAction("Billing", "Customer");
            }
            return View(paymentModel);
        }

        #region "Get Cookies"
        public string GetCookie(string Value)
        {
            var decodedValue = WebEncoders.Base64UrlDecode(Request.Cookies[Value]);
            string normalValue = Encoding.UTF8.GetString(decodedValue);

            return normalValue;
        }
        #endregion
    }
}