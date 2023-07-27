using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class KubernetesClusterEvidence : AlertEvidence, IParsable {
        /// <summary>The cloudResource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AlertEvidence? CloudResource {
            get { return BackingStore?.Get<AlertEvidence?>("cloudResource"); }
            set { BackingStore?.Set("cloudResource", value); }
        }
#nullable restore
#else
        public AlertEvidence CloudResource {
            get { return BackingStore?.Get<AlertEvidence>("cloudResource"); }
            set { BackingStore?.Set("cloudResource", value); }
        }
#endif
        /// <summary>The distribution property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Distribution {
            get { return BackingStore?.Get<string?>("distribution"); }
            set { BackingStore?.Set("distribution", value); }
        }
#nullable restore
#else
        public string Distribution {
            get { return BackingStore?.Get<string>("distribution"); }
            set { BackingStore?.Set("distribution", value); }
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
        /// <summary>The platform property</summary>
        public KubernetesPlatform? Platform {
            get { return BackingStore?.Get<KubernetesPlatform?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>The version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new kubernetesClusterEvidence and sets the default values.
        /// </summary>
        public KubernetesClusterEvidence() : base() {
            OdataType = "#microsoft.graph.security.kubernetesClusterEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KubernetesClusterEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesClusterEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cloudResource", n => { CloudResource = n.GetObjectValue<AlertEvidence>(AlertEvidence.CreateFromDiscriminatorValue); } },
                {"distribution", n => { Distribution = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<KubernetesPlatform>(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AlertEvidence>("cloudResource", CloudResource);
            writer.WriteStringValue("distribution", Distribution);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<KubernetesPlatform>("platform", Platform);
            writer.WriteStringValue("version", Version);
        }
    }
}
