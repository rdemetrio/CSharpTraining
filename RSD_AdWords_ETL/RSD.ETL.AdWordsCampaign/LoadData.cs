using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rhino.Etl.Core.ConventionOperations;

namespace RSD.ETL.AdWordsCampaign
{
    class LoadData : ConventionOutputCommandOperation
    {
        public LoadData() : base("Interim")
        {
            Command = @"

            INSERT INTO [Adwords].[tbl_CampaignPerformance]
           ([ClientID]
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
           ,[TotalConvValue])

            VALUES
           (@ClientID
           ,@AccountID
           ,@AccountName
           ,@CampaignID
           ,@CampaignName
           ,@Network
           ,@ClickType
           ,@Device
           ,@Date
           ,@Clicks
           ,@Impressions
           ,@Conversions
           ,@Cost
           ,@TotalConvValue)";
        }
    }
}
