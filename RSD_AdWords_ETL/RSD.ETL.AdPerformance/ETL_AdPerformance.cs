﻿using System;
using System.Configuration;
using Meridian.ETL.Configuration;
using Meridian.ETL;

namespace RSD.ETL.AdPerformance
{
    class ETL_AdPerformance : MeridianEtlProcess
    {
        //class constructor takes EtlConfiguration type config & inherits
        //base class with config parameter
        public ETL_AdPerformance(EtlConfiguration config) : base(config)
        {

        }

        //auto generated by implementing meridianetlprocess
        protected override void Initialize()
        {
            //Registers go here retrieve and load data methods
            Register(new GetAdPerformanceData());
            Register(new LoadAdPerformanceData());
        }             
    }
}
