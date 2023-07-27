using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AmazonResourceEvidence : AlertEvidence, IParsable {
        /// <summary>The unique identifier for the Amazon account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AmazonAccountId {
            get { return BackingStore?.Get<string?>("amazonAccountId"); }
            set { BackingStore?.Set("amazonAccountId", value); }
        }
#nullable restore
#else
        public string AmazonAccountId {
            get { return BackingStore?.Get<string>("amazonAccountId"); }
            set { BackingStore?.Set("amazonAccountId", value); }
        }
#endif
        /// <summary>The Amazon resource identifier (ARN) for the cloud resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AmazonResourceId {
            get { return BackingStore?.Get<string?>("amazonResourceId"); }
            set { BackingStore?.Set("amazonResourceId", value); }
        }
#nullable restore
#else
        public string AmazonResourceId {
            get { return BackingStore?.Get<string>("amazonResourceId"); }
            set { BackingStore?.Set("amazonResourceId", value); }
        }
#endif
        /// <summary>The name of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceName {
            get { return BackingStore?.Get<string?>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
#nullable restore
#else
        public string ResourceName {
            get { return BackingStore?.Get<string>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
#endif
        /// <summary>The type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType {
            get { return BackingStore?.Get<string?>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#nullable restore
#else
        public string ResourceType {
            get { return BackingStore?.Get<string>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new amazonResourceEvidence and sets the default values.
        /// </summary>
        public AmazonResourceEvidence() : base() {
            OdataType = "#microsoft.graph.security.amazonResourceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AmazonResourceEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AmazonResourceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"amazonAccountId", n => { AmazonAccountId = n.GetStringValue(); } },
                {"amazonResourceId", n => { AmazonResourceId = n.GetStringValue(); } },
                {"resourceName", n => { ResourceName = n.GetStringValue(); } },
                {"resourceType", n => { ResourceType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("amazonAccountId", AmazonAccountId);
            writer.WriteStringValue("amazonResourceId", AmazonResourceId);
            writer.WriteStringValue("resourceName", ResourceName);
            writer.WriteStringValue("resourceType", ResourceType);
        }
    }
}
