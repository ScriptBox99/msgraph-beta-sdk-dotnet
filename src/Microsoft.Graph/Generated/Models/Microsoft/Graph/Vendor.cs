using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the financials singleton.</summary>
    public class Vendor : Entity, IParsable {
        public PostalAddressType Address { get; set; }
        public decimal? Balance { get; set; }
        public string Blocked { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Currency Currency { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Number { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentMethod PaymentMethod { get; set; }
        public string PaymentMethodId { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm PaymentTerm { get; set; }
        public string PaymentTermsId { get; set; }
        public string PhoneNumber { get; set; }
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.Picture> Picture { get; set; }
        public bool? TaxLiable { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public string Website { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Vendor CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Vendor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"address", (o,n) => { (o as Vendor).Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"balance", (o,n) => { (o as Vendor).Balance = n.GetDecimalValue(); } },
                {"blocked", (o,n) => { (o as Vendor).Blocked = n.GetStringValue(); } },
                {"currency", (o,n) => { (o as Vendor).Currency = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Currency>(MicrosoftGraphSdk.Models.Microsoft.Graph.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", (o,n) => { (o as Vendor).CurrencyCode = n.GetStringValue(); } },
                {"currencyId", (o,n) => { (o as Vendor).CurrencyId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Vendor).DisplayName = n.GetStringValue(); } },
                {"email", (o,n) => { (o as Vendor).Email = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Vendor).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", (o,n) => { (o as Vendor).Number = n.GetStringValue(); } },
                {"paymentMethod", (o,n) => { (o as Vendor).PaymentMethod = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentMethod>(MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentMethod.CreateFromDiscriminatorValue); } },
                {"paymentMethodId", (o,n) => { (o as Vendor).PaymentMethodId = n.GetStringValue(); } },
                {"paymentTerm", (o,n) => { (o as Vendor).PaymentTerm = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm>(MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", (o,n) => { (o as Vendor).PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as Vendor).PhoneNumber = n.GetStringValue(); } },
                {"picture", (o,n) => { (o as Vendor).Picture = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Picture>(MicrosoftGraphSdk.Models.Microsoft.Graph.Picture.CreateFromDiscriminatorValue).ToList(); } },
                {"taxLiable", (o,n) => { (o as Vendor).TaxLiable = n.GetBoolValue(); } },
                {"taxRegistrationNumber", (o,n) => { (o as Vendor).TaxRegistrationNumber = n.GetStringValue(); } },
                {"website", (o,n) => { (o as Vendor).Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PostalAddressType>("address", Address);
            writer.WriteDecimalValue("balance", Balance);
            writer.WriteStringValue("blocked", Blocked);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteStringValue("currencyId", CurrencyId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentMethod>("paymentMethod", PaymentMethod);
            writer.WriteStringValue("paymentMethodId", PaymentMethodId);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteStringValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.Picture>("picture", Picture);
            writer.WriteBoolValue("taxLiable", TaxLiable);
            writer.WriteStringValue("taxRegistrationNumber", TaxRegistrationNumber);
            writer.WriteStringValue("website", Website);
        }
    }
}
