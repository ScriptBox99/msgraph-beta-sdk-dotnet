using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Bandwidth limits specified as a percentage.
    /// </summary>
    public class DeliveryOptimizationBandwidthPercentage : DeliveryOptimizationBandwidth, IParsable {
        /// <summary>Specifies the maximum background download bandwidth that Delivery Optimization uses across all concurrent download activities as a percentage of available download bandwidth (0-100). Valid values 0 to 100</summary>
        public int? MaximumBackgroundBandwidthPercentage {
            get { return BackingStore?.Get<int?>("maximumBackgroundBandwidthPercentage"); }
            set { BackingStore?.Set("maximumBackgroundBandwidthPercentage", value); }
        }
        /// <summary>Specifies the maximum foreground download bandwidth that Delivery Optimization uses across all concurrent download activities as a percentage of available download bandwidth (0-100). Valid values 0 to 100</summary>
        public int? MaximumForegroundBandwidthPercentage {
            get { return BackingStore?.Get<int?>("maximumForegroundBandwidthPercentage"); }
            set { BackingStore?.Set("maximumForegroundBandwidthPercentage", value); }
        }
        /// <summary>
        /// Instantiates a new deliveryOptimizationBandwidthPercentage and sets the default values.
        /// </summary>
        public DeliveryOptimizationBandwidthPercentage() : base() {
            OdataType = "#microsoft.graph.deliveryOptimizationBandwidthPercentage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeliveryOptimizationBandwidthPercentage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationBandwidthPercentage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumBackgroundBandwidthPercentage", n => { MaximumBackgroundBandwidthPercentage = n.GetIntValue(); } },
                {"maximumForegroundBandwidthPercentage", n => { MaximumForegroundBandwidthPercentage = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("maximumBackgroundBandwidthPercentage", MaximumBackgroundBandwidthPercentage);
            writer.WriteIntValue("maximumForegroundBandwidthPercentage", MaximumForegroundBandwidthPercentage);
        }
    }
}
