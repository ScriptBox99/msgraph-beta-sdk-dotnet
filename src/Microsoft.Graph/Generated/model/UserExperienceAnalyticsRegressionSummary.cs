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
    /// The type User Experience Analytics Regression Summary.
    /// </summary>
    public partial class UserExperienceAnalyticsRegressionSummary : Entity
    {
    
		///<summary>
		/// The UserExperienceAnalyticsRegressionSummary constructor
		///</summary>
        public UserExperienceAnalyticsRegressionSummary()
        {
            this.ODataType = "microsoft.graph.userExperienceAnalyticsRegressionSummary";
        }
	
        /// <summary>
        /// Gets or sets manufacturer regression.
        /// The metric values for the user experience analytics Manufacturer regression.
        /// </summary>
        [JsonPropertyName("manufacturerRegression")]
        public IUserExperienceAnalyticsRegressionSummaryManufacturerRegressionCollectionPage ManufacturerRegression { get; set; }

        /// <summary>
        /// Gets or sets manufacturerRegressionNextLink.
        /// </summary>
        [JsonPropertyName("manufacturerRegression@odata.nextLink")]
        public string ManufacturerRegressionNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets model regression.
        /// The metric values for the user experience analytics model regression.
        /// </summary>
        [JsonPropertyName("modelRegression")]
        public IUserExperienceAnalyticsRegressionSummaryModelRegressionCollectionPage ModelRegression { get; set; }

        /// <summary>
        /// Gets or sets modelRegressionNextLink.
        /// </summary>
        [JsonPropertyName("modelRegression@odata.nextLink")]
        public string ModelRegressionNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets operating system regression.
        /// The metric values for the user experience analytics operating system regression.
        /// </summary>
        [JsonPropertyName("operatingSystemRegression")]
        public IUserExperienceAnalyticsRegressionSummaryOperatingSystemRegressionCollectionPage OperatingSystemRegression { get; set; }

        /// <summary>
        /// Gets or sets operatingSystemRegressionNextLink.
        /// </summary>
        [JsonPropertyName("operatingSystemRegression@odata.nextLink")]
        public string OperatingSystemRegressionNextLink { get; set; }
    
    }
}

