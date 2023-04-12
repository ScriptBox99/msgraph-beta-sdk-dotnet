using Microsoft.Graph.Beta.Models.CallRecords;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudCommunications : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The callRecords property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CallRecord>? CallRecords {
            get { return BackingStore?.Get<List<CallRecord>?>("callRecords"); }
            set { BackingStore?.Set("callRecords", value); }
        }
#nullable restore
#else
        public List<CallRecord> CallRecords {
            get { return BackingStore?.Get<List<CallRecord>>("callRecords"); }
            set { BackingStore?.Set("callRecords", value); }
        }
#endif
        /// <summary>The calls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Call>? Calls {
            get { return BackingStore?.Get<List<Call>?>("calls"); }
            set { BackingStore?.Set("calls", value); }
        }
#nullable restore
#else
        public List<Call> Calls {
            get { return BackingStore?.Get<List<Call>>("calls"); }
            set { BackingStore?.Set("calls", value); }
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
        /// <summary>The onlineMeetings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnlineMeeting>? OnlineMeetings {
            get { return BackingStore?.Get<List<OnlineMeeting>?>("onlineMeetings"); }
            set { BackingStore?.Set("onlineMeetings", value); }
        }
#nullable restore
#else
        public List<OnlineMeeting> OnlineMeetings {
            get { return BackingStore?.Get<List<OnlineMeeting>>("onlineMeetings"); }
            set { BackingStore?.Set("onlineMeetings", value); }
        }
#endif
        /// <summary>The presences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Presence>? Presences {
            get { return BackingStore?.Get<List<Presence>?>("presences"); }
            set { BackingStore?.Set("presences", value); }
        }
#nullable restore
#else
        public List<Presence> Presences {
            get { return BackingStore?.Get<List<Presence>>("presences"); }
            set { BackingStore?.Set("presences", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new CloudCommunications and sets the default values.
        /// </summary>
        public CloudCommunications() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CloudCommunications CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudCommunications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"callRecords", n => { CallRecords = n.GetCollectionOfObjectValues<CallRecord>(CallRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"calls", n => { Calls = n.GetCollectionOfObjectValues<Call>(Call.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onlineMeetings", n => { OnlineMeetings = n.GetCollectionOfObjectValues<OnlineMeeting>(OnlineMeeting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"presences", n => { Presences = n.GetCollectionOfObjectValues<Presence>(Presence.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CallRecord>("callRecords", CallRecords);
            writer.WriteCollectionOfObjectValues<Call>("calls", Calls);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<OnlineMeeting>("onlineMeetings", OnlineMeetings);
            writer.WriteCollectionOfObjectValues<Presence>("presences", Presences);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
