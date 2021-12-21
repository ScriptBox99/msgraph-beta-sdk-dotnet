// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type RecurrencePattern.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RecurrencePattern>))]
    public partial class RecurrencePattern
    {

        /// <summary>
        /// Gets or sets dayOfMonth.
        /// The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
        /// </summary>
        [JsonPropertyName("dayOfMonth")]
        public Int32? DayOfMonth { get; set; }
    
        /// <summary>
        /// Gets or sets daysOfWeek.
        /// A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
        /// </summary>
        [JsonPropertyName("daysOfWeek")]
        public IEnumerable<DayOfWeek> DaysOfWeek { get; set; }
    
        /// <summary>
        /// Gets or sets firstDayOfWeek.
        /// The first day of the week. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. Default is sunday. Required if type is weekly.
        /// </summary>
        [JsonPropertyName("firstDayOfWeek")]
        public DayOfWeek? FirstDayOfWeek { get; set; }
    
        /// <summary>
        /// Gets or sets index.
        /// Specifies on which instance of the allowed days specified in daysOfWeek the event occurs, counted from the first instance in the month. The possible values are: first, second, third, fourth, last. Default is first. Optional and used if type is relativeMonthly or relativeYearly.
        /// </summary>
        [JsonPropertyName("index")]
        public WeekIndex? Index { get; set; }
    
        /// <summary>
        /// Gets or sets interval.
        /// The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
        /// </summary>
        [JsonPropertyName("interval")]
        public Int32? Interval { get; set; }
    
        /// <summary>
        /// Gets or sets month.
        /// The month in which the event occurs.  This is a number from 1 to 12.
        /// </summary>
        [JsonPropertyName("month")]
        public Int32? Month { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The recurrence pattern type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly. Required. For more information, see values of type property.
        /// </summary>
        [JsonPropertyName("type")]
        public RecurrencePatternType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
