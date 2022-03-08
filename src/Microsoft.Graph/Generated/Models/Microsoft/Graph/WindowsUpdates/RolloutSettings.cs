using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public class RolloutSettings : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the number of devices that are offered at the same time. Has no effect when endDateTime is set. When endDateTime and devicesPerOffer are both not set, all devices in the deployment are offered content at the same time.</summary>
        public int? DevicesPerOffer { get; set; }
        /// <summary>Specifies duration between each set of devices being offered the update. Has an effect when endDateTime or devicesPerOffer are defined. Default value is P1D (1 day).</summary>
        public string DurationBetweenOffers { get; set; }
        /// <summary>Specifies the date before which all devices currently in the deployment are offered the update. Devices added after this date are offered immediately. When endDateTime and devicesPerOffer are both not set, all devices in the deployment are offered content at the same time.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Date on which devices in the deployment start receiving the update. When not set, the deployment starts as soon as devices are assigned.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new rolloutSettings and sets the default values.
        /// </summary>
        public RolloutSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RolloutSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RolloutSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"devicesPerOffer", (o,n) => { (o as RolloutSettings).DevicesPerOffer = n.GetIntValue(); } },
                {"durationBetweenOffers", (o,n) => { (o as RolloutSettings).DurationBetweenOffers = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as RolloutSettings).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"startDateTime", (o,n) => { (o as RolloutSettings).StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("devicesPerOffer", DevicesPerOffer);
            writer.WriteStringValue("durationBetweenOffers", DurationBetweenOffers);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
