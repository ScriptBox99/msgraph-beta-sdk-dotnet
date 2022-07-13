using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A complex type to store the windows update rollout settings including offer start date time, offer end date time, and days between each set of offers.</summary>
    public class WindowsUpdateRolloutSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The feature update&apos;s ending  of release date and time to be set, update, and displayed for a feature Update profile for example: 2020-06-09T10:00:00Z.</summary>
        public DateTimeOffset? OfferEndDateTimeInUTC {
            get { return BackingStore?.Get<DateTimeOffset?>("offerEndDateTimeInUTC"); }
            set { BackingStore?.Set("offerEndDateTimeInUTC", value); }
        }
        /// <summary>The number of day(s) between each set of offers to be set, updated, and displayed for a feature update profile, for example: if OfferStartDateTimeInUTC is 2020-06-09T10:00:00Z, and OfferIntervalInDays is 1, then the next two sets of offers will be made consecutively on 2020-06-10T10:00:00Z (next day at the same specified time) and 2020-06-11T10:00:00Z (next next day at the same specified time) with 1 day in between each set of offers.</summary>
        public int? OfferIntervalInDays {
            get { return BackingStore?.Get<int?>("offerIntervalInDays"); }
            set { BackingStore?.Set("offerIntervalInDays", value); }
        }
        /// <summary>The feature update&apos;s starting date and time to be set, update, and displayed for a feature Update profile for example: 2020-06-09T10:00:00Z.</summary>
        public DateTimeOffset? OfferStartDateTimeInUTC {
            get { return BackingStore?.Get<DateTimeOffset?>("offerStartDateTimeInUTC"); }
            set { BackingStore?.Set("offerStartDateTimeInUTC", value); }
        }
        /// <summary>
        /// Instantiates a new windowsUpdateRolloutSettings and sets the default values.
        /// </summary>
        public WindowsUpdateRolloutSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsUpdateRolloutSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUpdateRolloutSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"offerEndDateTimeInUTC", n => { OfferEndDateTimeInUTC = n.GetDateTimeOffsetValue(); } },
                {"offerIntervalInDays", n => { OfferIntervalInDays = n.GetIntValue(); } },
                {"offerStartDateTimeInUTC", n => { OfferStartDateTimeInUTC = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("offerEndDateTimeInUTC", OfferEndDateTimeInUTC);
            writer.WriteIntValue("offerIntervalInDays", OfferIntervalInDays);
            writer.WriteDateTimeOffsetValue("offerStartDateTimeInUTC", OfferStartDateTimeInUTC);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
