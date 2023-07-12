using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Android Device Owner Global Proxy Direct.
    /// </summary>
    public class AndroidDeviceOwnerGlobalProxyDirect : AndroidDeviceOwnerGlobalProxy, IParsable {
        /// <summary>The excluded hosts</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludedHosts {
            get { return BackingStore?.Get<List<string>?>("excludedHosts"); }
            set { BackingStore?.Set("excludedHosts", value); }
        }
#nullable restore
#else
        public List<string> ExcludedHosts {
            get { return BackingStore?.Get<List<string>>("excludedHosts"); }
            set { BackingStore?.Set("excludedHosts", value); }
        }
#endif
        /// <summary>The host name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Host {
            get { return BackingStore?.Get<string?>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#nullable restore
#else
        public string Host {
            get { return BackingStore?.Get<string>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#endif
        /// <summary>The port</summary>
        public int? Port {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
        }
        /// <summary>
        /// Instantiates a new androidDeviceOwnerGlobalProxyDirect and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerGlobalProxyDirect() : base() {
            OdataType = "#microsoft.graph.androidDeviceOwnerGlobalProxyDirect";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerGlobalProxyDirect CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerGlobalProxyDirect();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"excludedHosts", n => { ExcludedHosts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"host", n => { Host = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("excludedHosts", ExcludedHosts);
            writer.WriteStringValue("host", Host);
            writer.WriteIntValue("port", Port);
        }
    }
}
