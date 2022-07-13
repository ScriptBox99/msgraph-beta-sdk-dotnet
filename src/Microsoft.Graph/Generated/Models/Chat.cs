using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Chat : Entity, IParsable {
        /// <summary>The chatType property</summary>
        public Microsoft.Graph.Beta.Models.ChatType? ChatType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ChatType?>("chatType"); }
            set { BackingStore?.Set("chatType", value); }
        }
        /// <summary>Date and time at which the chat was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>A collection of all the apps in the chat. Nullable.</summary>
        public List<TeamsAppInstallation> InstalledApps {
            get { return BackingStore?.Get<List<TeamsAppInstallation>>("installedApps"); }
            set { BackingStore?.Set("installedApps", value); }
        }
        /// <summary>Preview of the last message sent in the chat. Null if no messages have been sent in the chat. Currently, only the list chats operation supports this property.</summary>
        public ChatMessageInfo LastMessagePreview {
            get { return BackingStore?.Get<ChatMessageInfo>("lastMessagePreview"); }
            set { BackingStore?.Set("lastMessagePreview", value); }
        }
        /// <summary>Date and time at which the chat was renamed or list of members were last changed. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>A collection of all the members in the chat. Nullable.</summary>
        public List<ConversationMember> Members {
            get { return BackingStore?.Get<List<ConversationMember>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
        /// <summary>A collection of all the messages in the chat. Nullable.</summary>
        public List<ChatMessage> Messages {
            get { return BackingStore?.Get<List<ChatMessage>>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
        /// <summary>Represents details about an online meeting. If the chat isn&apos;t associated with an online meeting, the property is empty. Read-only.</summary>
        public TeamworkOnlineMeetingInfo OnlineMeetingInfo {
            get { return BackingStore?.Get<TeamworkOnlineMeetingInfo>("onlineMeetingInfo"); }
            set { BackingStore?.Set("onlineMeetingInfo", value); }
        }
        /// <summary>A collection of all the Teams async operations that ran or are running on the chat. Nullable.</summary>
        public List<TeamsAsyncOperation> Operations {
            get { return BackingStore?.Get<List<TeamsAsyncOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
        /// <summary>A collection of permissions granted to apps for the chat.</summary>
        public List<ResourceSpecificPermissionGrant> PermissionGrants {
            get { return BackingStore?.Get<List<ResourceSpecificPermissionGrant>>("permissionGrants"); }
            set { BackingStore?.Set("permissionGrants", value); }
        }
        /// <summary>A collection of all the pinned messages in the chat. Nullable.</summary>
        public List<PinnedChatMessageInfo> PinnedMessages {
            get { return BackingStore?.Get<List<PinnedChatMessageInfo>>("pinnedMessages"); }
            set { BackingStore?.Set("pinnedMessages", value); }
        }
        /// <summary>A collection of all the tabs in the chat. Nullable.</summary>
        public List<TeamsTab> Tabs {
            get { return BackingStore?.Get<List<TeamsTab>>("tabs"); }
            set { BackingStore?.Set("tabs", value); }
        }
        /// <summary>The identifier of the tenant in which the chat was created. Read-only.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>(Optional) Subject or topic for the chat. Only available for group chats.</summary>
        public string Topic {
            get { return BackingStore?.Get<string>("topic"); }
            set { BackingStore?.Set("topic", value); }
        }
        /// <summary>Represents caller-specific information about the chat, such as last message read date and time. This property is populated only when the request is made in a delegated context.</summary>
        public ChatViewpoint Viewpoint {
            get { return BackingStore?.Get<ChatViewpoint>("viewpoint"); }
            set { BackingStore?.Set("viewpoint", value); }
        }
        /// <summary>The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Chat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Chat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"chatType", n => { ChatType = n.GetEnumValue<ChatType>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<TeamsAppInstallation>(TeamsAppInstallation.CreateFromDiscriminatorValue).ToList(); } },
                {"lastMessagePreview", n => { LastMessagePreview = n.GetObjectValue<ChatMessageInfo>(ChatMessageInfo.CreateFromDiscriminatorValue); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<ConversationMember>(ConversationMember.CreateFromDiscriminatorValue).ToList(); } },
                {"messages", n => { Messages = n.GetCollectionOfObjectValues<ChatMessage>(ChatMessage.CreateFromDiscriminatorValue).ToList(); } },
                {"onlineMeetingInfo", n => { OnlineMeetingInfo = n.GetObjectValue<TeamworkOnlineMeetingInfo>(TeamworkOnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<TeamsAsyncOperation>(TeamsAsyncOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"permissionGrants", n => { PermissionGrants = n.GetCollectionOfObjectValues<ResourceSpecificPermissionGrant>(ResourceSpecificPermissionGrant.CreateFromDiscriminatorValue).ToList(); } },
                {"pinnedMessages", n => { PinnedMessages = n.GetCollectionOfObjectValues<PinnedChatMessageInfo>(PinnedChatMessageInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"tabs", n => { Tabs = n.GetCollectionOfObjectValues<TeamsTab>(TeamsTab.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"topic", n => { Topic = n.GetStringValue(); } },
                {"viewpoint", n => { Viewpoint = n.GetObjectValue<ChatViewpoint>(ChatViewpoint.CreateFromDiscriminatorValue); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ChatType>("chatType", ChatType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteObjectValue<ChatMessageInfo>("lastMessagePreview", LastMessagePreview);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfObjectValues<ConversationMember>("members", Members);
            writer.WriteCollectionOfObjectValues<ChatMessage>("messages", Messages);
            writer.WriteObjectValue<TeamworkOnlineMeetingInfo>("onlineMeetingInfo", OnlineMeetingInfo);
            writer.WriteCollectionOfObjectValues<TeamsAsyncOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ResourceSpecificPermissionGrant>("permissionGrants", PermissionGrants);
            writer.WriteCollectionOfObjectValues<PinnedChatMessageInfo>("pinnedMessages", PinnedMessages);
            writer.WriteCollectionOfObjectValues<TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("topic", Topic);
            writer.WriteObjectValue<ChatViewpoint>("viewpoint", Viewpoint);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
