﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MilkManagement.Domain.Entities.Supplier
{
    public class SupplierRate:BaseEntity
    {

        [Required]
        public int SupplierId { get; set; }
        [Required]
        public int CurrentRate { get; set; }
        [Required]
        public int PreviousRate { get; set; }
        public virtual  Supplier Supplier { get; set; }
    }
}
