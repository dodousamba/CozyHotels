﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CozyHotels.Models
{
    public class OrderRoom
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public string RoomType { get; set; }

        [Required(ErrorMessage = "Date of Arrival is required")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfArrival { get; set; }

        public Boolean TermsAndConditions { get; set; }

        public Customer Customer { get; set; }
        public Room Room { get; set; }
    }
}