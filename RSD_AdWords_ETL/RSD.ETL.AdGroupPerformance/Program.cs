using System;
using System.Configuration;
using Meridian.ETL.Configuration;

namespace RSD.ETL.AdGroupPerformance
{

    class Program
    {

        #region Private Members
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        static void Main(string[] args)
        {
            try
            {
                //Load configuration info
                EtlConfiguration config = new EtlConfiguration();
                config.ConnectionStrings = ConfigurationManager.ConnectionStrings;
                
                //Instantiate ETL Process
                using (var ETL_Job = new ETL_AdGroupPerformance(config))
                {
                    ETL_Job.Execute();
                }
            }
            catch (Exception ex)
            {
                log.Error(string.Format("**ERROR** - {0}", ex.Message), ex);
            }

        }
    }

}
