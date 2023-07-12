using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TeamCreatedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Initiator {
            get { return BackingStore?.Get<IdentitySet?>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#nullable restore
#else
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#endif
        /// <summary>Description for the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamDescription {
            get { return BackingStore?.Get<string?>("teamDescription"); }
            set { BackingStore?.Set("teamDescription", value); }
        }
#nullable restore
#else
        public string TeamDescription {
            get { return BackingStore?.Get<string>("teamDescription"); }
            set { BackingStore?.Set("teamDescription", value); }
        }
#endif
        /// <summary>Display name of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamDisplayName {
            get { return BackingStore?.Get<string?>("teamDisplayName"); }
            set { BackingStore?.Set("teamDisplayName", value); }
        }
#nullable restore
#else
        public string TeamDisplayName {
            get { return BackingStore?.Get<string>("teamDisplayName"); }
            set { BackingStore?.Set("teamDisplayName", value); }
        }
#endif
        /// <summary>Unique identifier of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamId {
            get { return BackingStore?.Get<string?>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
#nullable restore
#else
        public string TeamId {
            get { return BackingStore?.Get<string>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new teamCreatedEventMessageDetail and sets the default values.
        /// </summary>
        public TeamCreatedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.teamCreatedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamCreatedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamCreatedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"teamDescription", n => { TeamDescription = n.GetStringValue(); } },
                {"teamDisplayName", n => { TeamDisplayName = n.GetStringValue(); } },
                {"teamId", n => { TeamId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteStringValue("teamDescription", TeamDescription);
            writer.WriteStringValue("teamDisplayName", TeamDisplayName);
            writer.WriteStringValue("teamId", TeamId);
        }
    }
}
