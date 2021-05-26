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
    /// The type Enrollment Restrictions Configuration Policy Set Item.
    /// </summary>
    public partial class EnrollmentRestrictionsConfigurationPolicySetItem : PolicySetItem
    {
    
        ///<summary>
        /// The EnrollmentRestrictionsConfigurationPolicySetItem constructor
        ///</summary>
        public EnrollmentRestrictionsConfigurationPolicySetItem()
        {
            this.ODataType = "microsoft.graph.enrollmentRestrictionsConfigurationPolicySetItem";
        }
    
        /// <summary>
        /// Gets or sets limit.
        /// Limit of the EnrollmentRestrictionsConfigurationPolicySetItem.
        /// </summary>
        [JsonPropertyName("limit")]
        public Int32? Limit { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// Priority of the EnrollmentRestrictionsConfigurationPolicySetItem.
        /// </summary>
        [JsonPropertyName("priority")]
        public Int32? Priority { get; set; }
    
    }
}

