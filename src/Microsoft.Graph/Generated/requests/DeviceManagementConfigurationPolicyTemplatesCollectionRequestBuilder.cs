// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementConfigurationPolicyTemplatesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementConfigurationPolicyTemplatesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementConfigurationPolicyTemplatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementConfigurationPolicyTemplatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementConfigurationPolicyTemplatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementConfigurationPolicyTemplatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementConfigurationPolicyTemplatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementConfigurationPolicyTemplatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceManagementConfigurationPolicyTemplateRequestBuilder"/> for the specified DeviceManagementDeviceManagementConfigurationPolicyTemplate.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceManagementConfigurationPolicyTemplate.</param>
        /// <returns>The <see cref="IDeviceManagementConfigurationPolicyTemplateRequestBuilder"/>.</returns>
        public IDeviceManagementConfigurationPolicyTemplateRequestBuilder this[string id]
        {
            get
            {
                return new DeviceManagementConfigurationPolicyTemplateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
