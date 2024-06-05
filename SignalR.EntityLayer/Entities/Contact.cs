﻿using SignalR.EntityLayer.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class Contact : Entity<int>
    {
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FooterDescription { get; set; }
    }
}
