﻿using System;
using System.Collections.Generic;
using System.Text;
using MilkManagement.Domain.Entities;
using MilkManagement.Domain.Entities.Customer;

namespace MilkManagement.Domain.Dto
{
   public class CustomerRatesResponseDto:BaseEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int CustomerTypeId { get; set; }
        public string Type { get; set; }
        public int CurrentRate { get; set; }
        public int PreviousRate { get; set; }



    }
}
