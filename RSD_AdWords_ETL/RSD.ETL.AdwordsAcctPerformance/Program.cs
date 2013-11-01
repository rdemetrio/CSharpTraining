using System;
using System.Configuration;
using Meridian.ETL.Configuration;

namespace RSD.ETL.AdwordsAcctPerformance
{
    class Program
    {
        #region Private Members
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        static void Main(string[] args)
        {
            try
            {
                //Load configuration file
                EtlConfiguration config = new EtlConfiguration();
                config.ConnectionStrings = ConfigurationManager.ConnectionStrings;

                //Create job to execute
                using (var ETL_Job = new ETL_AdWordAcctPerformance(config))
                {
                    ETL_Job.Execute();
                }
                
            }
            catch (Exception ex)
            {
                //Log error
                log.Error(string.Format("**ERROR** - {0}", ex.Message), ex);
            }
            
        }
    }
}
