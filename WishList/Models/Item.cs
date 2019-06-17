using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class Item
    {
        public int id { get; set; }
        [Required]
        [MaxLength(5)]
        public string description { get; set; }

    }
}
