using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PayloadCoachmark : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The coachmark location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.CoachmarkLocation? CoachmarkLocation {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CoachmarkLocation?>("coachmarkLocation"); }
            set { BackingStore?.Set("coachmarkLocation", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.CoachmarkLocation CoachmarkLocation {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CoachmarkLocation>("coachmarkLocation"); }
            set { BackingStore?.Set("coachmarkLocation", value); }
        }
#endif
        /// <summary>The description about the coachmark.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The coachmark indicator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Indicator {
            get { return BackingStore?.Get<string?>("indicator"); }
            set { BackingStore?.Set("indicator", value); }
        }
#nullable restore
#else
        public string Indicator {
            get { return BackingStore?.Get<string>("indicator"); }
            set { BackingStore?.Set("indicator", value); }
        }
#endif
        /// <summary>Indicates whether the coachmark is valid or not.</summary>
        public bool? IsValid {
            get { return BackingStore?.Get<bool?>("isValid"); }
            set { BackingStore?.Set("isValid", value); }
        }
        /// <summary>The coachmark language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language {
            get { return BackingStore?.Get<string?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public string Language {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
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
        /// <summary>The coachmark order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Order {
            get { return BackingStore?.Get<string?>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#nullable restore
#else
        public string Order {
            get { return BackingStore?.Get<string>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new payloadCoachmark and sets the default values.
        /// </summary>
        public PayloadCoachmark() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PayloadCoachmark CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayloadCoachmark();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"coachmarkLocation", n => { CoachmarkLocation = n.GetObjectValue<Microsoft.Graph.Beta.Models.CoachmarkLocation>(Microsoft.Graph.Beta.Models.CoachmarkLocation.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"indicator", n => { Indicator = n.GetStringValue(); } },
                {"isValid", n => { IsValid = n.GetBoolValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"order", n => { Order = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CoachmarkLocation>("coachmarkLocation", CoachmarkLocation);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("indicator", Indicator);
            writer.WriteBoolValue("isValid", IsValid);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("order", Order);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
