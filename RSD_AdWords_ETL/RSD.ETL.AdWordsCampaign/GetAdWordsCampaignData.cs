using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rhino.Etl.Core.ConventionOperations;

namespace RSD.ETL.AdWordsCampaign
{
    class GetAdWordsCampaignData : ConventionInputCommandOperation
    {
        public GetAdWordsCampaignData()
            : base("Interim")
        {
            Command = @"SELECT [Id]
                    ,[ClientID]
                    ,[AccountID]
                    ,[AccountName]
                    ,[CampaignID]
                    ,[CampaignName]
                    ,[Network]
                    ,[ClickType]
                    ,[Device]
                    ,[Date]
                    ,[Clicks]
                    ,[Impressions]
                    ,[Conversions]
                    ,[Cost]
                    ,[TotalConvValue]
                    FROM [Interim].[Adwords].[CampaignPerformance]";
        }
    }
}
