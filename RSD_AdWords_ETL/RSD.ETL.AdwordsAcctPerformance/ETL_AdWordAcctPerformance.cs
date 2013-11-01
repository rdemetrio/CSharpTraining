using Meridian.ETL;
using Meridian.ETL.Configuration;


namespace RSD.ETL.AdwordsAcctPerformance
{
    class ETL_AdWordAcctPerformance : MeridianEtlProcess
    {
        public ETL_AdWordAcctPerformance(EtlConfiguration config) : base(config)
        {

        }

        protected override void Initialize()
        {
            Register(new RetrieveData());
            Register(new LoadData());
        }
    }
}
