using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of application entities.</summary>
    public class SynchronizationTemplate : Entity, IParsable {
        /// <summary>Identifier of the application this template belongs to.</summary>
        public string ApplicationId { get; set; }
        /// <summary>true if this template is recommended to be the default for the application.</summary>
        public bool? Default { get; set; }
        /// <summary>Description of the template.</summary>
        public string Description { get; set; }
        /// <summary>true if this template should appear in the collection of templates available for the application instance (service principal).</summary>
        public bool? Discoverable { get; set; }
        /// <summary>One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.</summary>
        public string FactoryTag { get; set; }
        /// <summary>Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.</summary>
        public List<MetadataEntry> Metadata { get; set; }
        /// <summary>Default synchronization schema for the jobs based on this template.</summary>
        public SynchronizationSchema Schema { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SynchronizationTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationId", (o,n) => { (o as SynchronizationTemplate).ApplicationId = n.GetStringValue(); } },
                {"default", (o,n) => { (o as SynchronizationTemplate).Default = n.GetBoolValue(); } },
                {"description", (o,n) => { (o as SynchronizationTemplate).Description = n.GetStringValue(); } },
                {"discoverable", (o,n) => { (o as SynchronizationTemplate).Discoverable = n.GetBoolValue(); } },
                {"factoryTag", (o,n) => { (o as SynchronizationTemplate).FactoryTag = n.GetStringValue(); } },
                {"metadata", (o,n) => { (o as SynchronizationTemplate).Metadata = n.GetCollectionOfObjectValues<MetadataEntry>(MetadataEntry.CreateFromDiscriminatorValue).ToList(); } },
                {"schema", (o,n) => { (o as SynchronizationTemplate).Schema = n.GetObjectValue<SynchronizationSchema>(SynchronizationSchema.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteBoolValue("default", Default);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("discoverable", Discoverable);
            writer.WriteStringValue("factoryTag", FactoryTag);
            writer.WriteCollectionOfObjectValues<MetadataEntry>("metadata", Metadata);
            writer.WriteObjectValue<SynchronizationSchema>("schema", Schema);
        }
    }
}
