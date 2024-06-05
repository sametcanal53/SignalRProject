﻿using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.FeatureDto
{
    public class GetFeatureDto : BaseFeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
