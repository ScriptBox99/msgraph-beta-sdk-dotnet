using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Windows 8.1+ Wi-Fi import configuration. By configuring this profile you can instruct Windows 8.1 (and later) devices to connect to desired Wi-Fi endpoint. Connect a Windows 8.1 device to the desired Wi-Fi network and extract the XML from that device to later embed into this Wi-Fi profile.
    /// </summary>
    public class Windows81WifiImportConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Payload. (UTF8 encoded byte array). This is the XML file saved on the device you used to connect to the Wi-Fi endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Payload {
            get { return BackingStore?.Get<byte[]?>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#nullable restore
#else
        public byte[] Payload {
            get { return BackingStore?.Get<byte[]>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#endif
        /// <summary>Payload file name (.xml).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayloadFileName {
            get { return BackingStore?.Get<string?>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
#nullable restore
#else
        public string PayloadFileName {
            get { return BackingStore?.Get<string>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
#endif
        /// <summary>Profile name displayed in the UI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileName {
            get { return BackingStore?.Get<string?>("profileName"); }
            set { BackingStore?.Set("profileName", value); }
        }
#nullable restore
#else
        public string ProfileName {
            get { return BackingStore?.Get<string>("profileName"); }
            set { BackingStore?.Set("profileName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new windows81WifiImportConfiguration and sets the default values.
        /// </summary>
        public Windows81WifiImportConfiguration() : base() {
            OdataType = "#microsoft.graph.windows81WifiImportConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows81WifiImportConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows81WifiImportConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"payload", n => { Payload = n.GetByteArrayValue(); } },
                {"payloadFileName", n => { PayloadFileName = n.GetStringValue(); } },
                {"profileName", n => { ProfileName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("payload", Payload);
            writer.WriteStringValue("payloadFileName", PayloadFileName);
            writer.WriteStringValue("profileName", ProfileName);
        }
    }
}
