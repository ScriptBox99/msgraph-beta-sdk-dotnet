using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Remote assistance settings for the account
    /// </summary>
    public class RemoteAssistanceSettings : Entity, IParsable {
        /// <summary>Indicates if sessions to unenrolled devices are allowed for the account. This setting is configurable by the admin. Default value is false.</summary>
        public bool? AllowSessionsToUnenrolledDevices {
            get { return BackingStore?.Get<bool?>("allowSessionsToUnenrolledDevices"); }
            set { BackingStore?.Set("allowSessionsToUnenrolledDevices", value); }
        }
        /// <summary>Indicates if sessions to block chat function. This setting is configurable by the admin. Default value is false.</summary>
        public bool? BlockChat {
            get { return BackingStore?.Get<bool?>("blockChat"); }
            set { BackingStore?.Set("blockChat", value); }
        }
        /// <summary>State of remote assistance for the account</summary>
        public Microsoft.Graph.Beta.Models.RemoteAssistanceState? RemoteAssistanceState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RemoteAssistanceState?>("remoteAssistanceState"); }
            set { BackingStore?.Set("remoteAssistanceState", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RemoteAssistanceSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteAssistanceSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowSessionsToUnenrolledDevices", n => { AllowSessionsToUnenrolledDevices = n.GetBoolValue(); } },
                {"blockChat", n => { BlockChat = n.GetBoolValue(); } },
                {"remoteAssistanceState", n => { RemoteAssistanceState = n.GetEnumValue<RemoteAssistanceState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowSessionsToUnenrolledDevices", AllowSessionsToUnenrolledDevices);
            writer.WriteBoolValue("blockChat", BlockChat);
            writer.WriteEnumValue<RemoteAssistanceState>("remoteAssistanceState", RemoteAssistanceState);
        }
    }
}
