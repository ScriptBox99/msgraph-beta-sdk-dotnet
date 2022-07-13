using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkNetworkConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The default gateway is the path used to pass information when the destination is unknown to the device.</summary>
        public string DefaultGateway {
            get { return BackingStore?.Get<string>("defaultGateway"); }
            set { BackingStore?.Set("defaultGateway", value); }
        }
        /// <summary>The network domain of the device, for example, contoso.com.</summary>
        public string DomainName {
            get { return BackingStore?.Get<string>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
        /// <summary>The device name on a network.</summary>
        public string HostName {
            get { return BackingStore?.Get<string>("hostName"); }
            set { BackingStore?.Set("hostName", value); }
        }
        /// <summary>The IP address is a numerical label that uniquely identifies every device connected to the internet.</summary>
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
        /// <summary>True if DHCP is enabled.</summary>
        public bool? IsDhcpEnabled {
            get { return BackingStore?.Get<bool?>("isDhcpEnabled"); }
            set { BackingStore?.Set("isDhcpEnabled", value); }
        }
        /// <summary>True if the PC port is enabled.</summary>
        public bool? IsPCPortEnabled {
            get { return BackingStore?.Get<bool?>("isPCPortEnabled"); }
            set { BackingStore?.Set("isPCPortEnabled", value); }
        }
        /// <summary>A primary DNS is the first point of contact for a device that translates the hostname into an IP address.</summary>
        public string PrimaryDns {
            get { return BackingStore?.Get<string>("primaryDns"); }
            set { BackingStore?.Set("primaryDns", value); }
        }
        /// <summary>A secondary DNS is used when the primary DNS is not available.</summary>
        public string SecondaryDns {
            get { return BackingStore?.Get<string>("secondaryDns"); }
            set { BackingStore?.Set("secondaryDns", value); }
        }
        /// <summary>A subnet mask is a number that distinguishes the network address and the host address within an IP address.</summary>
        public string SubnetMask {
            get { return BackingStore?.Get<string>("subnetMask"); }
            set { BackingStore?.Set("subnetMask", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkNetworkConfiguration and sets the default values.
        /// </summary>
        public TeamworkNetworkConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkNetworkConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkNetworkConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultGateway", n => { DefaultGateway = n.GetStringValue(); } },
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"hostName", n => { HostName = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"isDhcpEnabled", n => { IsDhcpEnabled = n.GetBoolValue(); } },
                {"isPCPortEnabled", n => { IsPCPortEnabled = n.GetBoolValue(); } },
                {"primaryDns", n => { PrimaryDns = n.GetStringValue(); } },
                {"secondaryDns", n => { SecondaryDns = n.GetStringValue(); } },
                {"subnetMask", n => { SubnetMask = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultGateway", DefaultGateway);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteBoolValue("isDhcpEnabled", IsDhcpEnabled);
            writer.WriteBoolValue("isPCPortEnabled", IsPCPortEnabled);
            writer.WriteStringValue("primaryDns", PrimaryDns);
            writer.WriteStringValue("secondaryDns", SecondaryDns);
            writer.WriteStringValue("subnetMask", SubnetMask);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
