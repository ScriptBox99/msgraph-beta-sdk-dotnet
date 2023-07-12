using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ChatMessageMentionedIdentitySet : IdentitySet, IParsable {
        /// <summary>If present, represents a conversation (for example, team or channel) @mentioned in a message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkConversationIdentity? Conversation {
            get { return BackingStore?.Get<TeamworkConversationIdentity?>("conversation"); }
            set { BackingStore?.Set("conversation", value); }
        }
#nullable restore
#else
        public TeamworkConversationIdentity Conversation {
            get { return BackingStore?.Get<TeamworkConversationIdentity>("conversation"); }
            set { BackingStore?.Set("conversation", value); }
        }
#endif
        /// <summary>If present, represents a tag @mentioned in a team message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkTagIdentity? Tag {
            get { return BackingStore?.Get<TeamworkTagIdentity?>("tag"); }
            set { BackingStore?.Set("tag", value); }
        }
#nullable restore
#else
        public TeamworkTagIdentity Tag {
            get { return BackingStore?.Get<TeamworkTagIdentity>("tag"); }
            set { BackingStore?.Set("tag", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new chatMessageMentionedIdentitySet and sets the default values.
        /// </summary>
        public ChatMessageMentionedIdentitySet() : base() {
            OdataType = "#microsoft.graph.chatMessageMentionedIdentitySet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ChatMessageMentionedIdentitySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessageMentionedIdentitySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conversation", n => { Conversation = n.GetObjectValue<TeamworkConversationIdentity>(TeamworkConversationIdentity.CreateFromDiscriminatorValue); } },
                {"tag", n => { Tag = n.GetObjectValue<TeamworkTagIdentity>(TeamworkTagIdentity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamworkConversationIdentity>("conversation", Conversation);
            writer.WriteObjectValue<TeamworkTagIdentity>("tag", Tag);
        }
    }
}
