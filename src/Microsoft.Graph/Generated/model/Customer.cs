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
    /// The type Customer.
    /// </summary>
    public partial class Customer : Entity
    {
    
        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [JsonPropertyName("address")]
        public PostalAddressType Address { get; set; }
    
        /// <summary>
        /// Gets or sets blocked.
        /// </summary>
        [JsonPropertyName("blocked")]
        public string Blocked { get; set; }
    
        /// <summary>
        /// Gets or sets currency code.
        /// </summary>
        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Gets or sets currency id.
        /// </summary>
        [JsonPropertyName("currencyId")]
        public Guid? CurrencyId { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    
        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        [JsonPropertyName("paymentMethodId")]
        public Guid? PaymentMethodId { get; set; }
    
        /// <summary>
        /// Gets or sets payment terms id.
        /// </summary>
        [JsonPropertyName("paymentTermsId")]
        public Guid? PaymentTermsId { get; set; }
    
        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets shipment method id.
        /// </summary>
        [JsonPropertyName("shipmentMethodId")]
        public Guid? ShipmentMethodId { get; set; }
    
        /// <summary>
        /// Gets or sets tax area display name.
        /// </summary>
        [JsonPropertyName("taxAreaDisplayName")]
        public string TaxAreaDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets tax area id.
        /// </summary>
        [JsonPropertyName("taxAreaId")]
        public Guid? TaxAreaId { get; set; }
    
        /// <summary>
        /// Gets or sets tax liable.
        /// </summary>
        [JsonPropertyName("taxLiable")]
        public bool? TaxLiable { get; set; }
    
        /// <summary>
        /// Gets or sets tax registration number.
        /// </summary>
        [JsonPropertyName("taxRegistrationNumber")]
        public string TaxRegistrationNumber { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets website.
        /// </summary>
        [JsonPropertyName("website")]
        public string Website { get; set; }
    
        /// <summary>
        /// Gets or sets currency.
        /// </summary>
        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }
    
        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        [JsonPropertyName("paymentMethod")]
        public PaymentMethod PaymentMethod { get; set; }
    
        /// <summary>
        /// Gets or sets payment term.
        /// </summary>
        [JsonPropertyName("paymentTerm")]
        public PaymentTerm PaymentTerm { get; set; }
    
        /// <summary>
        /// Gets or sets picture.
        /// </summary>
        [JsonPropertyName("picture")]
        public ICustomerPictureCollectionPage Picture { get; set; }

        /// <summary>
        /// Gets or sets pictureNextLink.
        /// </summary>
        [JsonPropertyName("picture@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PictureNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets shipment method.
        /// </summary>
        [JsonPropertyName("shipmentMethod")]
        public ShipmentMethod ShipmentMethod { get; set; }
    
    }
}

