using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The base presentation value entity that stores the value for a single group policy presentation.</summary>
    public class GroupPolicyPresentationValue : Entity, IParsable {
        /// <summary>The date and time the object was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The group policy definition value associated with the presentation value.</summary>
        public GroupPolicyDefinitionValue DefinitionValue {
            get { return BackingStore?.Get<GroupPolicyDefinitionValue>("definitionValue"); }
            set { BackingStore?.Set("definitionValue", value); }
        }
        /// <summary>The date and time the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The group policy presentation associated with the presentation value.</summary>
        public GroupPolicyPresentation Presentation {
            get { return BackingStore?.Get<GroupPolicyPresentation>("presentation"); }
            set { BackingStore?.Set("presentation", value); }
        }
        /// <summary>
        /// Instantiates a new groupPolicyPresentationValue and sets the default values.
        /// </summary>
        public GroupPolicyPresentationValue() : base() {
            Type = "#microsoft.graph.groupPolicyPresentationValue";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyPresentationValue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.groupPolicyPresentationValueBoolean" => new GroupPolicyPresentationValueBoolean(),
                "#microsoft.graph.groupPolicyPresentationValueDecimal" => new GroupPolicyPresentationValueDecimal(),
                "#microsoft.graph.groupPolicyPresentationValueList" => new GroupPolicyPresentationValueList(),
                "#microsoft.graph.groupPolicyPresentationValueLongDecimal" => new GroupPolicyPresentationValueLongDecimal(),
                "#microsoft.graph.groupPolicyPresentationValueMultiText" => new GroupPolicyPresentationValueMultiText(),
                "#microsoft.graph.groupPolicyPresentationValueText" => new GroupPolicyPresentationValueText(),
                _ => new GroupPolicyPresentationValue(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"definitionValue", n => { DefinitionValue = n.GetObjectValue<GroupPolicyDefinitionValue>(GroupPolicyDefinitionValue.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"presentation", n => { Presentation = n.GetObjectValue<GroupPolicyPresentation>(GroupPolicyPresentation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<GroupPolicyDefinitionValue>("definitionValue", DefinitionValue);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<GroupPolicyPresentation>("presentation", Presentation);
        }
    }
}
