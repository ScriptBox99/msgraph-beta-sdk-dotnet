using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class DirectorySetting : Entity, IParsable {
        /// <summary>Display name of this group of settings, which comes from the associated template. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>Unique identifier for the template used to create this group of settings. Read-only.</summary>
        public string TemplateId { get; set; }
        /// <summary>Collection of name-value pairs corresponding to the name and defaultValue properties in the referenced directorySettingTemplates object.</summary>
        public List<SettingValue> Values { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DirectorySetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectorySetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as DirectorySetting).DisplayName = n.GetStringValue(); } },
                {"templateId", (o,n) => { (o as DirectorySetting).TemplateId = n.GetStringValue(); } },
                {"values", (o,n) => { (o as DirectorySetting).Values = n.GetCollectionOfObjectValues<SettingValue>(SettingValue.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteCollectionOfObjectValues<SettingValue>("values", Values);
        }
    }
}
