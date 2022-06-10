﻿using eShopSolution.ViewModel.Sale;
using System.Collections.Generic;

namespace eShopSolution.WebApp.Models
{
    public class CheckoutViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }

        public CheckoutRequest CheckoutModel { get; set; }
    }
}