using System;
using System.Configuration;
using Meridian.ETL;
using Meridian.ETL.Configuration;
using Rhino.Etl.Core.ConventionOperations;

namespace RSD.ETL.AdPerformance
{
    class LoadAdPerformanceData : ConventionOutputCommandOperation
    {
        public LoadAdPerformanceData() : base("Interim")
        {
            //INSERT INTO statement here
            Command = @"
            INSERT INTO [Adwords].[AdPerformance]
           ([ClientID]
           ,[AccountName]
           ,[CampaignID]
           ,[CampaignName]
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
           ,[AdId]
           ,[Url])
     VALUES
           (@ClientID
           ,@AccountName
           ,@CampaignID
           ,@CampaignName
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
           ,@AdId
           ,@Url)";
        }
    }
}
