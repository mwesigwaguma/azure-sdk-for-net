// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement
{
    /// <summary>
    /// A class representing the CostManagementView data model.
    /// States and configurations of Cost Analysis.
    /// </summary>
    public partial class CostManagementViewData : ResourceData
    {
        /// <summary> Initializes a new instance of CostManagementViewData. </summary>
        public CostManagementViewData()
        {
            Kpis = new ChangeTrackingList<KpiProperties>();
            Pivots = new ChangeTrackingList<ViewPivotProperties>();
        }

        /// <summary> Initializes a new instance of CostManagementViewData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> User input name of the view. Required. </param>
        /// <param name="scope"> Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope. </param>
        /// <param name="createdOn"> Date the user created this view. </param>
        /// <param name="modifiedOn"> Date when the user last modified this view. </param>
        /// <param name="dateRange"> Date range of the current view. </param>
        /// <param name="currency"> Currency of the current view. </param>
        /// <param name="chart"> Chart type of the main view in Cost Analysis. Required. </param>
        /// <param name="accumulated"> Show costs accumulated over time. </param>
        /// <param name="metric"> Metric to use when displaying costs. </param>
        /// <param name="kpis"> List of KPIs to show in Cost Analysis UI. </param>
        /// <param name="pivots"> Configuration of 3 sub-views in the Cost Analysis UI. </param>
        /// <param name="typePropertiesQueryType"> The type of the report. Usage represents actual usage, forecast represents forecasted data and UsageAndForecast represents both usage and forecasted data. Actual usage and forecasted data can be differentiated based on dates. </param>
        /// <param name="timeframe"> The time frame for pulling data for the report. If custom, then a specific time period must be provided. </param>
        /// <param name="timePeriod"> Has time period for pulling data for the report. </param>
        /// <param name="dataSet"> Has definition for data in this report config. </param>
        /// <param name="includeMonetaryCommitment"> If true, report includes monetary commitment. </param>
        /// <param name="eTag"> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </param>
        internal CostManagementViewData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string scope, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, string dateRange, string currency, ViewChartType? chart, AccumulatedType? accumulated, ViewMetricType? metric, IList<KpiProperties> kpis, IList<ViewPivotProperties> pivots, ViewReportType? typePropertiesQueryType, ReportTimeframeType? timeframe, ReportConfigTimePeriod timePeriod, ReportConfigDataset dataSet, bool? includeMonetaryCommitment, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Scope = scope;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            DateRange = dateRange;
            Currency = currency;
            Chart = chart;
            Accumulated = accumulated;
            Metric = metric;
            Kpis = kpis;
            Pivots = pivots;
            TypePropertiesQueryType = typePropertiesQueryType;
            Timeframe = timeframe;
            TimePeriod = timePeriod;
            DataSet = dataSet;
            IncludeMonetaryCommitment = includeMonetaryCommitment;
            ETag = eTag;
        }

        /// <summary> User input name of the view. Required. </summary>
        public string DisplayName { get; set; }
        /// <summary> Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope. </summary>
        public string Scope { get; set; }
        /// <summary> Date the user created this view. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Date when the user last modified this view. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Date range of the current view. </summary>
        public string DateRange { get; }
        /// <summary> Currency of the current view. </summary>
        public string Currency { get; }
        /// <summary> Chart type of the main view in Cost Analysis. Required. </summary>
        public ViewChartType? Chart { get; set; }
        /// <summary> Show costs accumulated over time. </summary>
        public AccumulatedType? Accumulated { get; set; }
        /// <summary> Metric to use when displaying costs. </summary>
        public ViewMetricType? Metric { get; set; }
        /// <summary> List of KPIs to show in Cost Analysis UI. </summary>
        public IList<KpiProperties> Kpis { get; }
        /// <summary> Configuration of 3 sub-views in the Cost Analysis UI. </summary>
        public IList<ViewPivotProperties> Pivots { get; }
        /// <summary> The type of the report. Usage represents actual usage, forecast represents forecasted data and UsageAndForecast represents both usage and forecasted data. Actual usage and forecasted data can be differentiated based on dates. </summary>
        public ViewReportType? TypePropertiesQueryType { get; set; }
        /// <summary> The time frame for pulling data for the report. If custom, then a specific time period must be provided. </summary>
        public ReportTimeframeType? Timeframe { get; set; }
        /// <summary> Has time period for pulling data for the report. </summary>
        public ReportConfigTimePeriod TimePeriod { get; set; }
        /// <summary> Has definition for data in this report config. </summary>
        public ReportConfigDataset DataSet { get; set; }
        /// <summary> If true, report includes monetary commitment. </summary>
        public bool? IncludeMonetaryCommitment { get; set; }
        /// <summary> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </summary>
        public ETag? ETag { get; set; }
    }
}
