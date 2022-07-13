using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDisplayScreenConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The brightness level on the device (0-100). Not applicable for Microsoft Teams Rooms devices.</summary>
        public int? BacklightBrightness {
            get { return BackingStore?.Get<int?>("backlightBrightness"); }
            set { BackingStore?.Set("backlightBrightness", value); }
        }
        /// <summary>Timeout for backlight (30-3600 secs). Not applicable for Teams Rooms devices.</summary>
        public TimeSpan? BacklightTimeout {
            get { return BackingStore?.Get<TimeSpan?>("backlightTimeout"); }
            set { BackingStore?.Set("backlightTimeout", value); }
        }
        /// <summary>True if high contrast mode is enabled. Not applicable for Teams Rooms devices.</summary>
        public bool? IsHighContrastEnabled {
            get { return BackingStore?.Get<bool?>("isHighContrastEnabled"); }
            set { BackingStore?.Set("isHighContrastEnabled", value); }
        }
        /// <summary>True if screensaver is enabled. Not applicable for Teams Rooms devices.</summary>
        public bool? IsScreensaverEnabled {
            get { return BackingStore?.Get<bool?>("isScreensaverEnabled"); }
            set { BackingStore?.Set("isScreensaverEnabled", value); }
        }
        /// <summary>Screensaver timeout from 30 to 3600 secs. Not applicable for Teams Rooms devices.</summary>
        public TimeSpan? ScreensaverTimeout {
            get { return BackingStore?.Get<TimeSpan?>("screensaverTimeout"); }
            set { BackingStore?.Set("screensaverTimeout", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkDisplayScreenConfiguration and sets the default values.
        /// </summary>
        public TeamworkDisplayScreenConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkDisplayScreenConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDisplayScreenConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"backlightBrightness", n => { BacklightBrightness = n.GetIntValue(); } },
                {"backlightTimeout", n => { BacklightTimeout = n.GetTimeSpanValue(); } },
                {"isHighContrastEnabled", n => { IsHighContrastEnabled = n.GetBoolValue(); } },
                {"isScreensaverEnabled", n => { IsScreensaverEnabled = n.GetBoolValue(); } },
                {"screensaverTimeout", n => { ScreensaverTimeout = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("backlightBrightness", BacklightBrightness);
            writer.WriteTimeSpanValue("backlightTimeout", BacklightTimeout);
            writer.WriteBoolValue("isHighContrastEnabled", IsHighContrastEnabled);
            writer.WriteBoolValue("isScreensaverEnabled", IsScreensaverEnabled);
            writer.WriteTimeSpanValue("screensaverTimeout", ScreensaverTimeout);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
