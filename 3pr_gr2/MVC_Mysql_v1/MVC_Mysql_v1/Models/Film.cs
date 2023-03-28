﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Mysql_v1.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać tytuł")]
        [Display(Name = "Tytuł filmu")]
        public string? Title { get; set; }

        [Range(minimum: 0, maximum: 1000)]
        [DisplayName("Długość filmu")]
        public int? Time { get; set; }

        [DisplayName("Data powstania filmu")]
        public DateTime? Date { get; set; }
    }
}