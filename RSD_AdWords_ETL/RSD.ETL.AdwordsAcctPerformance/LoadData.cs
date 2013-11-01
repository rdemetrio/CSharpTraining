using Rhino.Etl.Core.ConventionOperations;

namespace RSD.ETL.AdwordsAcctPerformance
{
    class LoadData : ConventionOutputCommandOperation
    {
        public LoadData() : base("Interim")
        {
            //TODO: INSERT INTO statement here
            Command = @""; 
        }


    }
}
