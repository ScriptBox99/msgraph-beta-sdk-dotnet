using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeliveryOptimizationBandwidthAbsolute : DeliveryOptimizationBandwidth, IParsable {
        /// <summary>Specifies the maximum download bandwidth in KiloBytes/second that the device can use across all concurrent download activities using Delivery Optimization. Valid values 0 to 4294967295</summary>
        public long? MaximumDownloadBandwidthInKilobytesPerSecond {
            get { return BackingStore?.Get<long?>("maximumDownloadBandwidthInKilobytesPerSecond"); }
            set { BackingStore?.Set("maximumDownloadBandwidthInKilobytesPerSecond", value); }
        }
        /// <summary>Specifies the maximum upload bandwidth in KiloBytes/second that a device will use across all concurrent upload activity using Delivery Optimization (0-4000000). Valid values 0 to 4000000</summary>
        public long? MaximumUploadBandwidthInKilobytesPerSecond {
            get { return BackingStore?.Get<long?>("maximumUploadBandwidthInKilobytesPerSecond"); }
            set { BackingStore?.Set("maximumUploadBandwidthInKilobytesPerSecond", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeliveryOptimizationBandwidthAbsolute CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationBandwidthAbsolute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumDownloadBandwidthInKilobytesPerSecond", n => { MaximumDownloadBandwidthInKilobytesPerSecond = n.GetLongValue(); } },
                {"maximumUploadBandwidthInKilobytesPerSecond", n => { MaximumUploadBandwidthInKilobytesPerSecond = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("maximumDownloadBandwidthInKilobytesPerSecond", MaximumDownloadBandwidthInKilobytesPerSecond);
            writer.WriteLongValue("maximumUploadBandwidthInKilobytesPerSecond", MaximumUploadBandwidthInKilobytesPerSecond);
        }
    }
}
