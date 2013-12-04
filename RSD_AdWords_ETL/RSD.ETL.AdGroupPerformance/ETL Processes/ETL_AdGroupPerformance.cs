using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meridian.ETL;
using Meridian.ETL.Configuration;

namespace RSD.ETL.AdGroupPerformance
{
    class ETL_AdGroupPerformance : MeridianEtlProcess
    {

        public ETL_AdGroupPerformance(EtlConfiguration config) : base(config)
        {

        }


        protected override void Initialize()
        {
            Register(new GetAdGroupData());
            Register(new LoadData());
        }

    }
}
