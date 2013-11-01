using System;
using System.Configuration;
using Meridian.ETL;
using Meridian.ETL.Configuration;
using Rhino.Etl.Core.ConventionOperations;

namespace RSD.ETL.AdPerformance
{
    class GetAdPerformanceData : ConventionInputCommandOperation
    {
        public GetAdPerformanceData() : base("Interim")
        {
         //SELECT statement here can pull from sqlserver
         Command = @"
         SELECT [Id]
        ,[ClientID]
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
        ,[Url]
        FROM [Interim].[Adwords].[AdPerformance]";
        }
    }
}
