﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MilkManagement.Domain.Entities.Customer
{
   public class Customer:BaseEntity
    {
        public Customer()
        {
            CustomerRates = new HashSet<CustomerRates>();
            CustomerSupplied = new HashSet<CustomerSupplied>();
        }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(1025)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Contact { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd-MM-yyyy}")]
        public DateTime CreatedOn { get; set; }

        public int CreatedById { get; set; }
        
        public DateTime LastUpdatedOn { get; set; }
        
        public int LastUpdatedById { get; set; }

       [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<CustomerRates> CustomerRates { get; set; }
        public virtual ICollection<CustomerSupplied> CustomerSupplied { get; set; }
    }
}