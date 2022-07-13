using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcExternalPartnerSetting : Entity, IParsable {
        /// <summary>The enableConnection property</summary>
        public bool? EnableConnection {
            get { return BackingStore?.Get<bool?>("enableConnection"); }
            set { BackingStore?.Set("enableConnection", value); }
        }
        /// <summary>The lastSyncDateTime property</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The partnerId property</summary>
        public string PartnerId {
            get { return BackingStore?.Get<string>("partnerId"); }
            set { BackingStore?.Set("partnerId", value); }
        }
        /// <summary>The status property</summary>
        public CloudPcExternalPartnerStatus? Status {
            get { return BackingStore?.Get<CloudPcExternalPartnerStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The statusDetails property</summary>
        public string StatusDetails {
            get { return BackingStore?.Get<string>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcExternalPartnerSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcExternalPartnerSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enableConnection", n => { EnableConnection = n.GetBoolValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"partnerId", n => { PartnerId = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcExternalPartnerStatus>(); } },
                {"statusDetails", n => { StatusDetails = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enableConnection", EnableConnection);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("partnerId", PartnerId);
            writer.WriteEnumValue<CloudPcExternalPartnerStatus>("status", Status);
            writer.WriteStringValue("statusDetails", StatusDetails);
        }
    }
}
