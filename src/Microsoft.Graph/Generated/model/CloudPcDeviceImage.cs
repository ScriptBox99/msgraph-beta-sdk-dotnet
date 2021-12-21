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
    /// The type Cloud Pc Device Image.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CloudPcDeviceImage>))]
    public partial class CloudPcDeviceImage : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The image's display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date.
        /// The date the image became unavailable.
        /// </summary>
        [JsonPropertyName("expirationDate")]
        public Date ExpirationDate { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The data and time that the image was last modified. The time is shown in ISO 8601 format and  Coordinated Universal Time (UTC) time. For example, midnight UTC on Jan 1, 2014 appears as '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets operating system.
        /// The image's operating system. For example: Windows 10 Enterprise.
        /// </summary>
        [JsonPropertyName("operatingSystem")]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets os build number.
        /// The image's OS build version. For example: 1909.
        /// </summary>
        [JsonPropertyName("osBuildNumber")]
        public string OsBuildNumber { get; set; }
    
        /// <summary>
        /// Gets or sets os status.
        /// The OS status of this image. Possible values are: supported, supportedWithWarning, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("osStatus")]
        public CloudPcDeviceImageOsStatus? OsStatus { get; set; }
    
        /// <summary>
        /// Gets or sets source image resource id.
        /// The ID of the source image resource on Azure. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}'.
        /// </summary>
        [JsonPropertyName("sourceImageResourceId")]
        public string SourceImageResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the image on Cloud PC. Possible values are: pending, ready, failed.
        /// </summary>
        [JsonPropertyName("status")]
        public CloudPcDeviceImageStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets status details.
        /// The details of the image's status, which indicates why the upload failed, if applicable. Possible values are: internalServerError, sourceImageNotFound, osVersionNotSupported, sourceImageInvalid, and sourceImageNotGeneralized.
        /// </summary>
        [JsonPropertyName("statusDetails")]
        public CloudPcDeviceImageStatusDetails? StatusDetails { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// The image version. For example: 0.0.1, 1.5.13.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
    }
}

