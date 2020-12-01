﻿using prosamiWeb.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prosamiWeb.ViewModels
{
    public class BasketViewModel
    {
        public List<BasketLine> BasketLines { get; set; }
        [Display(Name = "Basket Total:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal TotalCost { get; set; }
    }
}