using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class KeyCredentialConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The maxLifetime property</summary>
        public TimeSpan? MaxLifetime {
            get { return BackingStore?.Get<TimeSpan?>("maxLifetime"); }
            set { BackingStore?.Set("maxLifetime", value); }
        }
        /// <summary>Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.</summary>
        public DateTimeOffset? RestrictForAppsCreatedAfterDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("restrictForAppsCreatedAfterDateTime"); }
            set { BackingStore?.Set("restrictForAppsCreatedAfterDateTime", value); }
        }
        /// <summary>The type of restriction being applied. Possible values are asymmetricKeyLifetime, unknownFutureValue. Each value of restrictionType can be used only once per policy.</summary>
        public AppKeyCredentialRestrictionType? RestrictionType {
            get { return BackingStore?.Get<AppKeyCredentialRestrictionType?>("restrictionType"); }
            set { BackingStore?.Set("restrictionType", value); }
        }
        /// <summary>
        /// Instantiates a new keyCredentialConfiguration and sets the default values.
        /// </summary>
        public KeyCredentialConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static KeyCredentialConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KeyCredentialConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"maxLifetime", n => { MaxLifetime = n.GetTimeSpanValue(); } },
                {"restrictForAppsCreatedAfterDateTime", n => { RestrictForAppsCreatedAfterDateTime = n.GetDateTimeOffsetValue(); } },
                {"restrictionType", n => { RestrictionType = n.GetEnumValue<AppKeyCredentialRestrictionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("maxLifetime", MaxLifetime);
            writer.WriteDateTimeOffsetValue("restrictForAppsCreatedAfterDateTime", RestrictForAppsCreatedAfterDateTime);
            writer.WriteEnumValue<AppKeyCredentialRestrictionType>("restrictionType", RestrictionType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
