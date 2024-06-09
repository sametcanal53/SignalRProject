﻿using SignalR.Core.Concretes;

namespace SignalR.DtoLayer.Concretes.Dtos.Baskets
{
    public class BasketDto : Dto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
