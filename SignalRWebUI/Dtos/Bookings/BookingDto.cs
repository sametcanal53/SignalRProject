﻿using SignalR.Core.Concretes;

namespace SignalRWebUI.Dtos.Bookings
{
    public class BookingDto : Dto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}