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
    /// The type Microsoft Account User Conversation Member.
    /// </summary>
    public partial class MicrosoftAccountUserConversationMember : ConversationMember
    {
    
        ///<summary>
        /// The MicrosoftAccountUserConversationMember constructor
        ///</summary>
        public MicrosoftAccountUserConversationMember()
        {
            this.ODataType = "microsoft.graph.microsoftAccountUserConversationMember";
        }

        /// <summary>
        /// Gets or sets user id.
        /// Microsoft Account ID of the user.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
    }
}

