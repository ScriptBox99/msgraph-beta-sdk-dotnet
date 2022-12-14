using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Windows Network Isolation Policy
    /// </summary>
    public class WindowsNetworkIsolationPolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Contains a list of enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy. This collection can contain a maximum of 500 elements.</summary>
        public List<ProxiedDomain> EnterpriseCloudResources {
            get { return BackingStore?.Get<List<ProxiedDomain>>("enterpriseCloudResources"); }
            set { BackingStore?.Set("enterpriseCloudResources", value); }
        }
        /// <summary>This is the comma-separated list of internal proxy servers. For example, &apos;157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59&apos;. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseCloudResources policy to force traffic to the matched cloud resources through these proxies.</summary>
        public List<string> EnterpriseInternalProxyServers {
            get { return BackingStore?.Get<List<string>>("enterpriseInternalProxyServers"); }
            set { BackingStore?.Set("enterpriseInternalProxyServers", value); }
        }
        /// <summary>Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to. This collection can contain a maximum of 500 elements.</summary>
        public List<IpRange> EnterpriseIPRanges {
            get { return BackingStore?.Get<List<IpRange>>("enterpriseIPRanges"); }
            set { BackingStore?.Set("enterpriseIPRanges", value); }
        }
        /// <summary>Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false.</summary>
        public bool? EnterpriseIPRangesAreAuthoritative {
            get { return BackingStore?.Get<bool?>("enterpriseIPRangesAreAuthoritative"); }
            set { BackingStore?.Set("enterpriseIPRangesAreAuthoritative", value); }
        }
        /// <summary>This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected. These locations will be considered a safe destination for enterprise data to be shared to.</summary>
        public List<string> EnterpriseNetworkDomainNames {
            get { return BackingStore?.Get<List<string>>("enterpriseNetworkDomainNames"); }
            set { BackingStore?.Set("enterpriseNetworkDomainNames", value); }
        }
        /// <summary>This is a list of proxy servers. Any server not on this list is considered non-enterprise.</summary>
        public List<string> EnterpriseProxyServers {
            get { return BackingStore?.Get<List<string>>("enterpriseProxyServers"); }
            set { BackingStore?.Set("enterpriseProxyServers", value); }
        }
        /// <summary>Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false</summary>
        public bool? EnterpriseProxyServersAreAuthoritative {
            get { return BackingStore?.Get<bool?>("enterpriseProxyServersAreAuthoritative"); }
            set { BackingStore?.Set("enterpriseProxyServersAreAuthoritative", value); }
        }
        /// <summary>List of domain names that can used for work or personal resource.</summary>
        public List<string> NeutralDomainResources {
            get { return BackingStore?.Get<List<string>>("neutralDomainResources"); }
            set { BackingStore?.Set("neutralDomainResources", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new windowsNetworkIsolationPolicy and sets the default values.
        /// </summary>
        public WindowsNetworkIsolationPolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WindowsNetworkIsolationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsNetworkIsolationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"enterpriseCloudResources", n => { EnterpriseCloudResources = n.GetCollectionOfObjectValues<ProxiedDomain>(ProxiedDomain.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enterpriseInternalProxyServers", n => { EnterpriseInternalProxyServers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"enterpriseIPRanges", n => { EnterpriseIPRanges = n.GetCollectionOfObjectValues<IpRange>(IpRange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"enterpriseIPRangesAreAuthoritative", n => { EnterpriseIPRangesAreAuthoritative = n.GetBoolValue(); } },
                {"enterpriseNetworkDomainNames", n => { EnterpriseNetworkDomainNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"enterpriseProxyServers", n => { EnterpriseProxyServers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"enterpriseProxyServersAreAuthoritative", n => { EnterpriseProxyServersAreAuthoritative = n.GetBoolValue(); } },
                {"neutralDomainResources", n => { NeutralDomainResources = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ProxiedDomain>("enterpriseCloudResources", EnterpriseCloudResources);
            writer.WriteCollectionOfPrimitiveValues<string>("enterpriseInternalProxyServers", EnterpriseInternalProxyServers);
            writer.WriteCollectionOfObjectValues<IpRange>("enterpriseIPRanges", EnterpriseIPRanges);
            writer.WriteBoolValue("enterpriseIPRangesAreAuthoritative", EnterpriseIPRangesAreAuthoritative);
            writer.WriteCollectionOfPrimitiveValues<string>("enterpriseNetworkDomainNames", EnterpriseNetworkDomainNames);
            writer.WriteCollectionOfPrimitiveValues<string>("enterpriseProxyServers", EnterpriseProxyServers);
            writer.WriteBoolValue("enterpriseProxyServersAreAuthoritative", EnterpriseProxyServersAreAuthoritative);
            writer.WriteCollectionOfPrimitiveValues<string>("neutralDomainResources", NeutralDomainResources);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
