using System;
using System.Configuration;
using Meridian.ETL.Configuration;

namespace RSD.ETL.AdWordsCampaign
{
    class Program
    {
        //copy and paste this. 
        #region Private Members
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion 

        static void Main(string[] args)
        {
            //exception handling here
            try
            {
                //Load configuration info
                EtlConfiguration config = new EtlConfiguration();
                config.ConnectionStrings = ConfigurationManager.ConnectionStrings;

                //Instantiate ETL Process
                using (var ETL_Job = new ETL_AdWordCampaignPerformance(config)) //can auto generate class "ctrl + '.'"
                {
                    //Execute ETL_AdWordCampaignPerformance
                    ETL_Job.Execute();
                }
            }
            catch(Exception ex)
            {
                //This will log any error that happens
                log.Error(string.Format("**ERROR** - {0}", ex.Message), ex);
            }
           
        }
    }
}
