﻿using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class FeatureManager : GenericManager<Feature>, IFeatureService
    {
        public FeatureManager(IFeatureDal featureDal) : base(featureDal)
        {
        }

    }
}
