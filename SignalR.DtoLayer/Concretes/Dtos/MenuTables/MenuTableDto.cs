﻿using SignalR.Core.Concretes;
using SignalR.Core.Enums;

namespace SignalR.DtoLayer.Concretes.Dtos.MenuTables
{
    public class MenuTableDto : Dto
    {
        public string Name { get; set; }
        public EnumMenuTableStatus Status { get; set; }
    }
}
