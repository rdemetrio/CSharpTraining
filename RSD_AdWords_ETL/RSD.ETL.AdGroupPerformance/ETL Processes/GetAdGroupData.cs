using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rhino.Etl.Core.ConventionOperations;

namespace RSD.ETL.AdGroupPerformance
{
    class GetAdGroupData : ConventionInputCommandOperation
    {
        public GetAdGroupData() : base("Interim")
        {

            Command = @"SELECT [Id]
      ,[ClientID]
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
      ,[Prefix]
  FROM [Report].[vw_AdwordsAdGroupPerformance]";

        }
    }
}
