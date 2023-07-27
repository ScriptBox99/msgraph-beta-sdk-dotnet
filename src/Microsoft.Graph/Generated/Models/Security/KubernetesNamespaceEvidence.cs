using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class KubernetesNamespaceEvidence : AlertEvidence, IParsable {
        /// <summary>The cluster property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesClusterEvidence? Cluster {
            get { return BackingStore?.Get<KubernetesClusterEvidence?>("cluster"); }
            set { BackingStore?.Set("cluster", value); }
        }
#nullable restore
#else
        public KubernetesClusterEvidence Cluster {
            get { return BackingStore?.Get<KubernetesClusterEvidence>("cluster"); }
            set { BackingStore?.Set("cluster", value); }
        }
#endif
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary? Labels {
            get { return BackingStore?.Get<Dictionary?>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#nullable restore
#else
        public Dictionary Labels {
            get { return BackingStore?.Get<Dictionary>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new kubernetesNamespaceEvidence and sets the default values.
        /// </summary>
        public KubernetesNamespaceEvidence() : base() {
            OdataType = "#microsoft.graph.security.kubernetesNamespaceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KubernetesNamespaceEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesNamespaceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cluster", n => { Cluster = n.GetObjectValue<KubernetesClusterEvidence>(KubernetesClusterEvidence.CreateFromDiscriminatorValue); } },
                {"labels", n => { Labels = n.GetObjectValue<Dictionary>(Dictionary.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<KubernetesClusterEvidence>("cluster", Cluster);
            writer.WriteObjectValue<Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
        }
    }
}
