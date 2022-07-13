using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Communications.Calls.Item.Redirect {
    /// <summary>Provides operations to call the redirect method.</summary>
    public class RedirectPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The callbackUri property</summary>
        public string CallbackUri {
            get { return BackingStore?.Get<string>("callbackUri"); }
            set { BackingStore?.Set("callbackUri", value); }
        }
        /// <summary>The maskCallee property</summary>
        public bool? MaskCallee {
            get { return BackingStore?.Get<bool?>("maskCallee"); }
            set { BackingStore?.Set("maskCallee", value); }
        }
        /// <summary>The maskCaller property</summary>
        public bool? MaskCaller {
            get { return BackingStore?.Get<bool?>("maskCaller"); }
            set { BackingStore?.Set("maskCaller", value); }
        }
        /// <summary>The targetDisposition property</summary>
        public CallDisposition? TargetDisposition {
            get { return BackingStore?.Get<CallDisposition?>("targetDisposition"); }
            set { BackingStore?.Set("targetDisposition", value); }
        }
        /// <summary>The targets property</summary>
        public List<InvitationParticipantInfo> Targets {
            get { return BackingStore?.Get<List<InvitationParticipantInfo>>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
        /// <summary>The timeout property</summary>
        public int? Timeout {
            get { return BackingStore?.Get<int?>("timeout"); }
            set { BackingStore?.Set("timeout", value); }
        }
        /// <summary>
        /// Instantiates a new redirectPostRequestBody and sets the default values.
        /// </summary>
        public RedirectPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RedirectPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RedirectPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                {"maskCallee", n => { MaskCallee = n.GetBoolValue(); } },
                {"maskCaller", n => { MaskCaller = n.GetBoolValue(); } },
                {"targetDisposition", n => { TargetDisposition = n.GetEnumValue<CallDisposition>(); } },
                {"targets", n => { Targets = n.GetCollectionOfObjectValues<InvitationParticipantInfo>(InvitationParticipantInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"timeout", n => { Timeout = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteBoolValue("maskCallee", MaskCallee);
            writer.WriteBoolValue("maskCaller", MaskCaller);
            writer.WriteEnumValue<CallDisposition>("targetDisposition", TargetDisposition);
            writer.WriteCollectionOfObjectValues<InvitationParticipantInfo>("targets", Targets);
            writer.WriteIntValue("timeout", Timeout);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
