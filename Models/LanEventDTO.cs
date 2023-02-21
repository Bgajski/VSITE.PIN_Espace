﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class LanEventDTO
    {
        public int EventId { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti naziv turnira")]
        public string Name { get; set; }
        [Range(2, int.MaxValue, ErrorMessage = "Potrebno je unijeti broj timova te mimimalan broj dopušten može biti 2 tima")]
        public int Teams { get; set; }
        [Range(30, int.MaxValue, ErrorMessage = "Potrebno je unijeti iznos nagradnog fonda u Eurima te minimalan iznos može biti 20 Eura")]
        public int Reward { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti datum početka turnira")]
        public DateTime Starting { get; set; }
        [Required(ErrorMessage = "Potrebno je unijeti datum kraja turnira")]
        public DateTime Ending { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Potrebno je unijeti cijenu registracije po timu u Eurima te minimalan iznos može biti 20 Eura")]
        public int Price { get; set; }
        public int? LanGameId { get; set; }
        public LanGameDTO LanGameDTO { get; set; }
    }
}
