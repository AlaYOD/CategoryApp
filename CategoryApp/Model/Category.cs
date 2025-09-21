﻿using System.ComponentModel.DataAnnotations;

namespace CategoryApp.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int DisplayOrder { get; set; }


    }
}
