﻿using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class AppUser: IdentityUser<Guid>
    {
        public String FisrtName { get; set; }

        public String LastName { get; set; }

        public DateTime Dob { get; set; }   

        public List<Cart> Carts { get; set; }

        public List<Order> Oders { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
