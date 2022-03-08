using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class GroupPolicyOperation : Entity, IParsable {
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The group policy operation status. Possible values are: unknown, inProgress, success, failed.</summary>
        public GroupPolicyOperationStatus? OperationStatus { get; set; }
        /// <summary>The type of group policy operation. Possible values are: none, upload, uploadNewVersion, addLanguageFiles, removeLanguageFiles, updateLanguageFiles, remove.</summary>
        public GroupPolicyOperationType? OperationType { get; set; }
        /// <summary>The group policy operation status detail.</summary>
        public string StatusDetails { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"lastModifiedDateTime", (o,n) => { (o as GroupPolicyOperation).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationStatus", (o,n) => { (o as GroupPolicyOperation).OperationStatus = n.GetEnumValue<GroupPolicyOperationStatus>(); } },
                {"operationType", (o,n) => { (o as GroupPolicyOperation).OperationType = n.GetEnumValue<GroupPolicyOperationType>(); } },
                {"statusDetails", (o,n) => { (o as GroupPolicyOperation).StatusDetails = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<GroupPolicyOperationStatus>("operationStatus", OperationStatus);
            writer.WriteEnumValue<GroupPolicyOperationType>("operationType", OperationType);
            writer.WriteStringValue("statusDetails", StatusDetails);
        }
    }
}
