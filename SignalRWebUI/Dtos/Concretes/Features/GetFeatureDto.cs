﻿using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Features
{
    public class GetFeatureDto : BaseFeatureDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
