// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type IdentityUserFlowAttributeAssignmentSetOrderRequest.
    /// </summary>
    public partial class IdentityUserFlowAttributeAssignmentSetOrderRequest : BaseRequest, IIdentityUserFlowAttributeAssignmentSetOrderRequest
    {
        /// <summary>
        /// Constructs a new IdentityUserFlowAttributeAssignmentSetOrderRequest.
        /// </summary>
        public IdentityUserFlowAttributeAssignmentSetOrderRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.ContentType = "application/json";
            this.RequestBody = new IdentityUserFlowAttributeAssignmentSetOrderRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public IdentityUserFlowAttributeAssignmentSetOrderRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public System.Threading.Tasks.Task PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task PostAsync(
            CancellationToken cancellationToken)
        {
            this.Method = "POST";
            return this.SendAsync(this.RequestBody, cancellationToken);
        }




        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityUserFlowAttributeAssignmentSetOrderRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityUserFlowAttributeAssignmentSetOrderRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
