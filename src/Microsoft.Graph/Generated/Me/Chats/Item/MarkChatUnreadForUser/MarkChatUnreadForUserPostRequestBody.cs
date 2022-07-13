using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.Chats.Item.MarkChatUnreadForUser {
    /// <summary>Provides operations to call the markChatUnreadForUser method.</summary>
    public class MarkChatUnreadForUserPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The lastMessageReadDateTime property</summary>
        public DateTimeOffset? LastMessageReadDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastMessageReadDateTime"); }
            set { BackingStore?.Set("lastMessageReadDateTime", value); }
        }
        /// <summary>The tenantId property</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>The user property</summary>
        public TeamworkUserIdentity User {
            get { return BackingStore?.Get<TeamworkUserIdentity>("user"); }
            set { BackingStore?.Set("user", value); }
        }
        /// <summary>
        /// Instantiates a new markChatUnreadForUserPostRequestBody and sets the default values.
        /// </summary>
        public MarkChatUnreadForUserPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MarkChatUnreadForUserPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MarkChatUnreadForUserPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"lastMessageReadDateTime", n => { LastMessageReadDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("lastMessageReadDateTime", LastMessageReadDateTime);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<TeamworkUserIdentity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
