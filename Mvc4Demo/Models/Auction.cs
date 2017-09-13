using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc4Demo.Models
{
    public class Auction
    {
        public Guid Id { get; set; }

        [Required, Display(Name = "标题")]
        public string Title { get; set; }


        [Required,Display(Name="描述"), StringLength(50, ErrorMessage = "cannot be longer than 50")]
        public string Description { get; set; }


        [Required, Range(0, 200, ErrorMessage = "startprice must between 0 and  200")]
        public decimal StartPrice { get; set; }

        public decimal CurrentPrice { get; set; }
        public DateTime EndTime { get; set; }
    }
}