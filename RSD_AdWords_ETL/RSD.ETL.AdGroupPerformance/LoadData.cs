using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rhino.Etl.Core.ConventionOperations;

namespace RSD.ETL.AdGroupPerformance
{
    class LoadData : ConventionOutputCommandOperation
    {
        public LoadData() : base("Interim")
        {
            Command = @"

INSERT INTO [Adwords].[tbl_AdGroupPerformance]
           ([ClientID]
           ,[AccountName]
           ,[AccountNameLong]
           ,[CampaignID]
           ,[CampaignName]
           ,[CampaignPrefix]
           ,[ClickType]
           ,[Device]
           ,[Date]
           ,[Clicks]
           ,[Impressions]
           ,[Conversions]
           ,[Cost]
           ,[TotalConvValue]
           ,[AdGroupId]
           ,[AdGroupName]
           ,[AdGroupPrefix]
           ,[Prefix])
     VALUES
           (@ClientID
           ,@AccountName
           ,@AccountNameLong
           ,@CampaignID
           ,@CampaignName
           ,@CampaignPrefix
           ,@ClickType
           ,@Device
           ,@Date
           ,@Clicks
           ,@Impressions
           ,@Conversions
           ,@Cost
           ,@TotalConvValue
           ,@AdGroupId
           ,@AdGroupName
           ,@AdGroupPrefix
           ,@Prefix) ";


        }
    }
}
