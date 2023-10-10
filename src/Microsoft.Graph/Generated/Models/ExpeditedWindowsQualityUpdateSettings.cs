// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A complex type to store the expedited quality update settings such as release date and days until forced reboot.
    /// </summary>
    public class ExpeditedWindowsQualityUpdateSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of days after installation that forced reboot will happen.</summary>
        public int? DaysUntilForcedReboot {
            get { return BackingStore?.Get<int?>("daysUntilForcedReboot"); }
            set { BackingStore?.Set("daysUntilForcedReboot", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The release date to identify a quality update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QualityUpdateRelease {
            get { return BackingStore?.Get<string?>("qualityUpdateRelease"); }
            set { BackingStore?.Set("qualityUpdateRelease", value); }
        }
#nullable restore
#else
        public string QualityUpdateRelease {
            get { return BackingStore?.Get<string>("qualityUpdateRelease"); }
            set { BackingStore?.Set("qualityUpdateRelease", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new expeditedWindowsQualityUpdateSettings and sets the default values.
        /// </summary>
        public ExpeditedWindowsQualityUpdateSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExpeditedWindowsQualityUpdateSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpeditedWindowsQualityUpdateSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"daysUntilForcedReboot", n => { DaysUntilForcedReboot = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"qualityUpdateRelease", n => { QualityUpdateRelease = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("daysUntilForcedReboot", DaysUntilForcedReboot);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("qualityUpdateRelease", QualityUpdateRelease);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
