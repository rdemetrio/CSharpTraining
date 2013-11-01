using System;
using System.Configuration;
using Meridian.ETL.Configuration;


namespace RSD.ETL.AdPerformance
{
    class Program
    {
        #region Private Members
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        static void Main(string[] args)
        {
            //Load Configuration file
            try
            {
                //Instantiate EtlConfiguration object
                EtlConfiguration config = new EtlConfiguration();
                config.ConnectionStrings = ConfigurationManager.ConnectionStrings;

                //Instantiate object of new class you will auto gen and pass config in parameters
                //then execute
                using (var ETL_Job = new ETL_AdPerformance(config))
                {
                    ETL_Job.Execute();
                }
            }
            catch(Exception ex)
            {
                //log any error 
                log.Error(string.Format("**ERROR** - {0}", ex.Message), ex);
            }
        }
    }
}
