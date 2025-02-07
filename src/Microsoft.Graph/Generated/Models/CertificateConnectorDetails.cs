// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity used to retrieve information about Intune Certificate Connectors.
    /// </summary>
    public class CertificateConnectorDetails : Entity, IParsable {
        /// <summary>Connector name (set during enrollment).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorName {
            get { return BackingStore?.Get<string?>("connectorName"); }
            set { BackingStore?.Set("connectorName", value); }
        }
#nullable restore
#else
        public string ConnectorName {
            get { return BackingStore?.Get<string>("connectorName"); }
            set { BackingStore?.Set("connectorName", value); }
        }
#endif
        /// <summary>Version of the connector installed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorVersion {
            get { return BackingStore?.Get<string?>("connectorVersion"); }
            set { BackingStore?.Set("connectorVersion", value); }
        }
#nullable restore
#else
        public string ConnectorVersion {
            get { return BackingStore?.Get<string>("connectorVersion"); }
            set { BackingStore?.Set("connectorVersion", value); }
        }
#endif
        /// <summary>Date/time when this connector was enrolled.</summary>
        public DateTimeOffset? EnrollmentDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("enrollmentDateTime"); }
            set { BackingStore?.Set("enrollmentDateTime", value); }
        }
        /// <summary>Date/time when this connector last connected to the service.</summary>
        public DateTimeOffset? LastCheckinDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCheckinDateTime"); }
            set { BackingStore?.Set("lastCheckinDateTime", value); }
        }
        /// <summary>Name of the machine hosting this connector service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MachineName {
            get { return BackingStore?.Get<string?>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
#nullable restore
#else
        public string MachineName {
            get { return BackingStore?.Get<string>("machineName"); }
            set { BackingStore?.Set("machineName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CertificateConnectorDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateConnectorDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectorName", n => { ConnectorName = n.GetStringValue(); } },
                {"connectorVersion", n => { ConnectorVersion = n.GetStringValue(); } },
                {"enrollmentDateTime", n => { EnrollmentDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastCheckinDateTime", n => { LastCheckinDateTime = n.GetDateTimeOffsetValue(); } },
                {"machineName", n => { MachineName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("connectorName", ConnectorName);
            writer.WriteStringValue("connectorVersion", ConnectorVersion);
            writer.WriteDateTimeOffsetValue("enrollmentDateTime", EnrollmentDateTime);
            writer.WriteDateTimeOffsetValue("lastCheckinDateTime", LastCheckinDateTime);
            writer.WriteStringValue("machineName", MachineName);
        }
    }
}
