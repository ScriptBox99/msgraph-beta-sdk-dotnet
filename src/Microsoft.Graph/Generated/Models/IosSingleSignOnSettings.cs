// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// iOS Kerberos authentication settings for single sign-on
    /// </summary>
    public class IosSingleSignOnSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>List of app identifiers that are allowed to use this login. If this field is omitted, the login applies to all applications on the device. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppListItem>? AllowedAppsList {
            get { return BackingStore?.Get<List<AppListItem>?>("allowedAppsList"); }
            set { BackingStore?.Set("allowedAppsList", value); }
        }
#nullable restore
#else
        public List<AppListItem> AllowedAppsList {
            get { return BackingStore?.Get<List<AppListItem>>("allowedAppsList"); }
            set { BackingStore?.Set("allowedAppsList", value); }
        }
#endif
        /// <summary>List of HTTP URLs that must be matched in order to use this login. With iOS 9.0 or later, a wildcard characters may be used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedUrls {
            get { return BackingStore?.Get<List<string>?>("allowedUrls"); }
            set { BackingStore?.Set("allowedUrls", value); }
        }
#nullable restore
#else
        public List<string> AllowedUrls {
            get { return BackingStore?.Get<List<string>>("allowedUrls"); }
            set { BackingStore?.Set("allowedUrls", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The display name of login settings shown on the receiving device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>A Kerberos principal name. If not provided, the user is prompted for one during profile installation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KerberosPrincipalName {
            get { return BackingStore?.Get<string?>("kerberosPrincipalName"); }
            set { BackingStore?.Set("kerberosPrincipalName", value); }
        }
#nullable restore
#else
        public string KerberosPrincipalName {
            get { return BackingStore?.Get<string>("kerberosPrincipalName"); }
            set { BackingStore?.Set("kerberosPrincipalName", value); }
        }
#endif
        /// <summary>A Kerberos realm name. Case sensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KerberosRealm {
            get { return BackingStore?.Get<string?>("kerberosRealm"); }
            set { BackingStore?.Set("kerberosRealm", value); }
        }
#nullable restore
#else
        public string KerberosRealm {
            get { return BackingStore?.Get<string>("kerberosRealm"); }
            set { BackingStore?.Set("kerberosRealm", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new iosSingleSignOnSettings and sets the default values.
        /// </summary>
        public IosSingleSignOnSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IosSingleSignOnSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosSingleSignOnSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedAppsList", n => { AllowedAppsList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"allowedUrls", n => { AllowedUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"kerberosPrincipalName", n => { KerberosPrincipalName = n.GetStringValue(); } },
                {"kerberosRealm", n => { KerberosRealm = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AppListItem>("allowedAppsList", AllowedAppsList);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedUrls", AllowedUrls);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("kerberosPrincipalName", KerberosPrincipalName);
            writer.WriteStringValue("kerberosRealm", KerberosRealm);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
