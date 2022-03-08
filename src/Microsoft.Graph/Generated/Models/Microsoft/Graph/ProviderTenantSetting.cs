using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the providerTenantSettings property of the microsoft.graph.security entity.</summary>
    public class ProviderTenantSetting : Entity, IParsable {
        public string AzureTenantId { get; set; }
        public bool? Enabled { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string Provider { get; set; }
        public string Vendor { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProviderTenantSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProviderTenantSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"azureTenantId", (o,n) => { (o as ProviderTenantSetting).AzureTenantId = n.GetStringValue(); } },
                {"enabled", (o,n) => { (o as ProviderTenantSetting).Enabled = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ProviderTenantSetting).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"provider", (o,n) => { (o as ProviderTenantSetting).Provider = n.GetStringValue(); } },
                {"vendor", (o,n) => { (o as ProviderTenantSetting).Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("vendor", Vendor);
        }
    }
}
