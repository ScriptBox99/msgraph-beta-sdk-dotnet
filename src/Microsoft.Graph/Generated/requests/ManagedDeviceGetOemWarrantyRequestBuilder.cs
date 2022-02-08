// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagedDeviceGetOemWarrantyRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceGetOemWarrantyRequestBuilder : BaseFunctionMethodRequestBuilder<IManagedDeviceGetOemWarrantyRequest>, IManagedDeviceGetOemWarrantyRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ManagedDeviceGetOemWarrantyRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedDeviceGetOemWarrantyRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IManagedDeviceGetOemWarrantyRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ManagedDeviceGetOemWarrantyRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
