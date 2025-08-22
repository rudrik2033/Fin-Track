﻿using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expences
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0.01,double.MaxValue,ErrorMessage ="Amount Can Not In Negative")]
        public double Amount {  get; set; }
        [Required]
        public string Category {  get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
