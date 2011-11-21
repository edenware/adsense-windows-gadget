﻿/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Google.Apis.Adsense.v1.Data;

namespace Google.Adsense.Win.Logic.AdSenseApi
{
    public class AdSenseZeroClient : IAdSenseClient
    {
        public IList<string> FetchAdClients()
        {
            return new List<string>().AsReadOnly();
        }

        public OverviewReport FetchOverview()
        {
            AdsenseReportsGenerateResponse response = new AdsenseReportsGenerateResponse();
            response.Rows = new List<IList<string>>();
            response.Rows.Add(new List<string>{"1970-01-01", "0", "0", "0", "0", "0", "0"});
            response.Headers = new List<AdsenseReportsGenerateResponse.HeadersData>{null, new AdsenseReportsGenerateResponse.HeadersData{Currency = "GBP"}};
            return new OverviewReport(CultureInfo.CurrentCulture, ReportDates.Today, 
                ReportDates.Yesterday, ReportDates.FirstOfLastMonth, ReportDates.FirstOfThisMonth, response);
        }

        public ChannelSummary FetchCustomChannels()
        {
            throw new NotImplementedException();
        }

        public ChannelSummary FetchUrlChannels()
        {
            throw new NotImplementedException();
        }

        public AggregateRevenueSummary FetchYtdRevenue()
        {
            throw new NotImplementedException();
        }

        public AggregateRevenueSummary FetchLifetimeRevenue()
        {
            throw new NotImplementedException();
        }
    }
}
