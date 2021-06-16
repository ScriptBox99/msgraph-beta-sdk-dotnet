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
    /// The type AccessReviewNotificationRecipientQueryScope.
    /// </summary>
    public partial class AccessReviewNotificationRecipientQueryScope : AccessReviewNotificationRecipientScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessReviewNotificationRecipientQueryScope"/> class.
        /// </summary>
        public AccessReviewNotificationRecipientQueryScope()
        {
            this.ODataType = "microsoft.graph.accessReviewNotificationRecipientQueryScope";
        }

        /// <summary>
        /// Gets or sets query.
        /// This represents the query for who the recipients are. For example, /groups/{group id}/members for group members and /users/{user id} for a specific user.
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }
    
        /// <summary>
        /// Gets or sets queryRoot.
        /// In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query that is, ./manager) is specified.
        /// </summary>
        [JsonPropertyName("queryRoot")]
        public string QueryRoot { get; set; }
    
        /// <summary>
        /// Gets or sets queryType.
        /// Indicates the type of query. Allowed value is MicrosoftGraph.
        /// </summary>
        [JsonPropertyName("queryType")]
        public string QueryType { get; set; }
    
    }
}
