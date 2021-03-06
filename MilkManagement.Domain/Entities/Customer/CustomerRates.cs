﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MilkManagement.Core.Validator;

namespace MilkManagement.Domain.Entities.Customer
{
   public class CustomerRates:BaseEntity
    {
        public int CustomerId { get; set; }
        public int CurrentRate { get; set; }
        public int PreviousRate { get; set; }
       
        public Customer Customer { get; set; }
    }
}
