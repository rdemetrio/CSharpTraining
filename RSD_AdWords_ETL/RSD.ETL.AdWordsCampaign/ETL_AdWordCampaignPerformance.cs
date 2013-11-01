using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Meridian.ETL.Configuration;
using Meridian.ETL;

namespace RSD.ETL.AdWordsCampaign
{
    //Implement MeridianETLProcess which is an abstract class
    //generates the protected override void Initialize method below
    class ETL_AdWordCampaignPerformance : MeridianEtlProcess
    {
        //Constructor inherits base with config parameter
        public ETL_AdWordCampaignPerformance(EtlConfiguration config) : base(config)
        {
            
        }

        protected override void Initialize()
        {
            //Register methods
            Register(new GetAdWordsCampaignData());
            Register(new LoadData());
        }
    }
}
