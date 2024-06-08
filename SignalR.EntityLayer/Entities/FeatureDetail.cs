﻿using SignalR.EntityLayer.Concretes;

namespace SignalR.EntityLayer.Entities
{
    public class FeatureDetail : Entity<int>
    {
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
