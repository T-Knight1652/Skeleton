﻿using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool OverEighteen { get; set; }
        public DateTime CreationDate { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public int CustomerID { get; set; }
    }
}