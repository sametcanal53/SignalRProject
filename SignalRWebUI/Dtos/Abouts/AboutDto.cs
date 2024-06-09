﻿using SignalR.Core.Concretes;

namespace SignalRWebUI.Dtos.Abouts
{
    public class AboutDto : Dto
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
