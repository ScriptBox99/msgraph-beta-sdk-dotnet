// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Aged Accounts Receivable.
    /// </summary>
    public partial class AgedAccountsReceivable : Entity
    {
    
        /// <summary>
        /// Gets or sets aged as of date.
        /// </summary>
        [JsonPropertyName("agedAsOfDate")]
        public Date AgedAsOfDate { get; set; }
    
        /// <summary>
        /// Gets or sets balance due.
        /// </summary>
        [JsonPropertyName("balanceDue")]
        public Decimal? BalanceDue { get; set; }
    
        /// <summary>
        /// Gets or sets currency code.
        /// </summary>
        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Gets or sets current amount.
        /// </summary>
        [JsonPropertyName("currentAmount")]
        public Decimal? CurrentAmount { get; set; }
    
        /// <summary>
        /// Gets or sets customer number.
        /// </summary>
        [JsonPropertyName("customerNumber")]
        public string CustomerNumber { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets period1amount.
        /// </summary>
        [JsonPropertyName("period1Amount")]
        public Decimal? Period1Amount { get; set; }
    
        /// <summary>
        /// Gets or sets period2amount.
        /// </summary>
        [JsonPropertyName("period2Amount")]
        public Decimal? Period2Amount { get; set; }
    
        /// <summary>
        /// Gets or sets period3amount.
        /// </summary>
        [JsonPropertyName("period3Amount")]
        public Decimal? Period3Amount { get; set; }
    
        /// <summary>
        /// Gets or sets period length filter.
        /// </summary>
        [JsonPropertyName("periodLengthFilter")]
        public string PeriodLengthFilter { get; set; }
    
    }
}

